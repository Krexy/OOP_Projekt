using Podatkovni_sloj.Modals;
using RWA__WindowsForms_Projekt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeResourceData();


            if (!FileManager.LoadLanguage())
            {
                //ako nepostoji
                Application.Run(new Postavke());
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new Form1());
            }
            FileManager.SavePlayers(FileManager.playerPicturesPath, FileManager.playerPicturesForFile);
            FileManager.WriteToFile(FileManager.playerPicturesForFile.ToArray(), FileManager.PLAYERS_PATH);
            FileManager.SavePlayers(FileManager.favPlayerPicturesPath, FileManager.favPlayerPicturesForFile);
            FileManager.WriteToFile(FileManager.favPlayerPicturesForFile.ToArray(), FileManager.FAVPLAYERS_PATH);

        }

        private static void InitializeResourceData()
        {
            if (!File.Exists(FileManager.SETTINGS_PATH))
            {
                using (File.Create(FileManager.SETTINGS_PATH)) { }
            }
            if (!File.Exists(FileManager.PLAYERS_PATH))
            {
                using (File.Create(FileManager.PLAYERS_PATH)) { }
            }
            if (!File.Exists(FileManager.FAVPLAYERS_PATH))
            {
                using (File.Create(FileManager.FAVPLAYERS_PATH)) { }
            }
        }
    }
}
