using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EU4Backupper
{
    static class Globals
    {
        public static bool running = false;
        public static bool autoStart = false;
        public static bool autoReboot = true;
        public static string campaignName = "";
        public static string saveGameLocation = "";
        public static string gameExe = "";
        public static int autoSaveInterval = 2;

        public static void Load()
        {
            string[] lines = File.Exists("./mem.txt") ? File.ReadAllLines("./mem.txt") : new string[0];

            foreach (string line in lines)
            {
                if (line.StartsWith("name")) campaignName = line.Substring(6);
                if (line.StartsWith("autoStart")) autoStart = bool.Parse(line.Substring(11));
                if (line.StartsWith("autoReboot")) autoReboot = bool.Parse(line.Substring(12));
                if (line.StartsWith("saveFolder")) saveGameLocation = line.Substring(12);
                if (line.StartsWith("gameExe")) gameExe = line.Substring(9);
                if (line.StartsWith("interval")) autoSaveInterval = int.Parse(line.Substring(10));
            }

            running = autoStart;
        }

        public static void Save()
        {
            List<string> lines = new();

            lines.Add("name: " + campaignName);
            lines.Add("autoStart: " + autoStart.ToString());
            lines.Add("autoReboot: " + autoReboot.ToString());
            lines.Add("saveFolder: " + saveGameLocation);
            lines.Add("gameExe: " + gameExe);
            lines.Add("interval: " + autoSaveInterval);

            File.WriteAllLines("./mem.txt", lines);
        }

        static string NowTime()
        {
            return DateTime.Now.ToString().Replace('/', '-').Replace(':', '.');
        }

        public static void AutoBackup()
        {
            CreateFolders();
            string source = saveGameLocation + "/" + campaignName + ".eu4";
            string dest = Path.GetFullPath("./Backups/" + campaignName + "/Auto/" + NowTime() + ".eu4");
            Copy(source, dest, false);
        }

        public static bool SaveMilestone(string name = "")
        {
            bool force = true;
            if (name == "")
            {
                force = false;
                name = NowTime();
            }
            string source = saveGameLocation + "/" + campaignName + ".eu4";
            string dest = Path.GetFullPath("./Backups/" + campaignName + "/Milestones/" + name + ".eu4");
            return Copy(source, dest, force);
        }

        public static bool RestoreLastMilestone()
        {
            var directory = new DirectoryInfo("./Backups/" + campaignName + "/Milestones/");
            if (!directory.Exists) return false;
            var last = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).FirstOrDefault();
            if (last == null) return false;
            return Restore(last.FullName);
        }

        public static bool Restore(string source)
        {
            try
            {
                File.Delete(saveGameLocation + "/" + campaignName + ".eu4");
                File.Delete(saveGameLocation + "/" + campaignName + "_Backup.eu4");
                File.Copy(source, saveGameLocation + "/" + campaignName + ".eu4");

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void CreateFolders()
        {
            if (!Directory.Exists("./" + campaignName))
            {
                Directory.CreateDirectory("./Backups/" + campaignName);
                Directory.CreateDirectory("./Backups/" + campaignName + "/Auto");
                Directory.CreateDirectory("./Backups/" + campaignName + "/Milestones");
            }
        }

        public static bool Copy(string source, string dest, bool force)
        {
            try
            {
                //Creates the folders if it is the first time
                CreateFolders();

                var directory = new DirectoryInfo(Path.GetDirectoryName(dest));

                //Gets the last modified
                var last = directory.GetFiles().OrderByDescending(f => f.CreationTime).FirstOrDefault();
                bool exists = last != null ? File.ReadAllBytes(last.FullName).SequenceEqual(File.ReadAllBytes(source)) : false;

                if (force || Directory.GetFiles(Path.GetDirectoryName(dest)).Count() == 0 || !exists)
                {
                    File.Copy(source, dest);
                    return true;
                }
                return exists;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static void RestartGame()
        {
            Task.Run(async () =>
            {
                Process[] eus = Process.GetProcessesByName("eu4");
                foreach (Process eu in eus)
                {
                    eu.Kill();
                    eu.WaitForExit();
                    eu.Dispose();
                }

                Process.Start(gameExe, "steam://rungameid/236850");

                IntPtr launcher = await Task.Run(() => GetLauncher());
                if (launcher == IntPtr.Zero) return;

                Interop.RECT rect = new Interop.RECT();

                Interop.GetWindowRect(new HandleRef(null, launcher), out rect);

                int x = ((rect.Right - rect.Left) / 6) * 4;
                int y = ((rect.Bottom - rect.Top) / 8) * 3;

                Stopwatch sw = new Stopwatch();
                sw.Restart();

                while (Process.GetProcessesByName("eu4").Length == 0)
                {
                    await Task.Run(() => Interop.SetForegroundWindow(launcher));
                    Thread.Sleep(100);
                    if (Interop.GetForegroundWindow() == launcher)
                        Interop.ClickOnPoint(launcher, new Point(x, y));
                    //if (sw.ElapsedMilliseconds > 4000)
                        //return;
                }
                sw.Stop();

                Thread.Sleep(5000);
                var cleanup = Process.GetProcessesByName("eu4");
                while (cleanup.Length != 1)
                {
                    cleanup.First().Kill();
                    cleanup = Process.GetProcessesByName("eu4");
                }
            });
        }

        static IntPtr GetLauncher()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            Process? p = null;
            do
            {
                Thread.Sleep(10);
                p = Process.GetProcessesByName("Paradox Launcher").FirstOrDefault();
                if (sw.ElapsedMilliseconds > 7500)
                    return IntPtr.Zero;
            } while (p == null);

            sw.Restart();
            Interop.RECT rect;
            do
            {
                Thread.Sleep(10);
                Interop.GetWindowRect(new HandleRef(null, p.MainWindowHandle), out rect);
                if (sw.ElapsedMilliseconds > 2500)
                    return IntPtr.Zero;
            }
            while (rect.Top == rect.Bottom);
            sw.Stop();
            return p.MainWindowHandle;
        }
    }






    public class Interop
    {
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(HandleRef hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        [DllImport("user32.dll")]
        static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);

#pragma warning disable 649
        internal struct INPUT
        {
            public UInt32 Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT
        {
            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

        internal struct MOUSEINPUT
        {
            public Int32 X;
            public Int32 Y;
            public UInt32 MouseData;
            public UInt32 Flags;
            public UInt32 Time;
            public IntPtr ExtraInfo;
        }

#pragma warning restore 649


        public static void ClickOnPoint(IntPtr wndHandle, Point clientPoint)
        {
            var oldPos = Cursor.Position;

            /// get screen coordinates
            ClientToScreen(wndHandle, ref clientPoint);

            /// set cursor on coords, and press mouse
            Cursor.Position = new Point(clientPoint.X, clientPoint.Y);

            var inputMouseDown = new INPUT();
            inputMouseDown.Type = 0; /// input type mouse
            inputMouseDown.Data.Mouse.Flags = 0x0002; /// left button down

            var inputMouseUp = new INPUT();
            inputMouseUp.Type = 0; /// input type mouse
            inputMouseUp.Data.Mouse.Flags = 0x0004; /// left button up

            var inputs = new INPUT[] { inputMouseDown, inputMouseUp };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

            /// return mouse 
            Cursor.Position = oldPos;
        }

    }
}