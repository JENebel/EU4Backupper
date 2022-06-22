using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
                if (line.StartsWith("name"))        campaignName = line.Substring(6);
                if (line.StartsWith("autoStart"))   autoStart = bool.Parse(line.Substring(11));
                if (line.StartsWith("autoReboot"))  autoReboot = bool.Parse(line.Substring(12));
                if (line.StartsWith("saveFolder"))  saveGameLocation = line.Substring(12);
                if (line.StartsWith("gameExe"))     gameExe = line.Substring(9);
                if (line.StartsWith("interval"))    autoSaveInterval = int.Parse(line.Substring(10));
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

        public static void AutoBackup()
        {
            CreateFolders();
            string source = saveGameLocation + "/" + campaignName + ".eu4";
            string dest = Path.GetFullPath("./Backups/" + campaignName + "/Auto/" + DateTime.Now.ToString().Replace('/', '-') + ".eu4");
            Copy(source, dest, false);
        }

        public static bool SaveMilestone(string name = "")
        {
            bool force = true;
            if (name == "")
            {
                force = false;
                name = DateTime.Now.ToString().Replace('/', '-');
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

                //If not already backed up
                if (force || (Directory.GetFiles(Path.GetDirectoryName(dest)).Count() == 0 || !File.ReadAllBytes(last.FullName).SequenceEqual(File.ReadAllBytes(source))))
                {
                    File.Copy(source, dest);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void RestartGame()
        {
            Process[] eus = Process.GetProcessesByName("eu4");
            foreach (Process eu in eus)
            {
                eu.Kill();
                eu.WaitForExit();
                eu.Dispose();
            }
            var proc = Process.Start(gameExe);
        }
    }
}