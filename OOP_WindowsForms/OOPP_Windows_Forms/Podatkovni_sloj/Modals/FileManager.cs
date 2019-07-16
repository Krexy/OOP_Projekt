using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podatkovni_sloj.Modals
{
    public static class FileManager
    {

        private static readonly string PATH = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
        public static readonly string SETTINGS_PATH = Path.Combine(PATH, "Settings.txt");
        public static readonly string FAVPLAYERS_PATH = Path.Combine(PATH, "FavPlayers.txt");
        public static readonly string PLAYERS_PATH = Path.Combine(PATH, "Players.txt");
        public static readonly string FAV_COUNTRY = Path.Combine(PATH, "Country.txt");
        public static readonly string PICTURE_DIR = $@"{PATH}\Slike\";
        private static readonly char SPLITTER = '|';
        public static string ApplicationLanguage { get; set; }
        public static int ApplicationWidth = -1;
        public static int ApplicationHeight = -1;
        public static IDictionary<string, Bitmap> playerPictures = new Dictionary<string, Bitmap>();
        public static IDictionary<string, string> playerPicturesPath = new Dictionary<string, string>();
        public static IDictionary<string, Bitmap> favPlayerPictures = new Dictionary<string, Bitmap>();
        public static IDictionary<string, string> favPlayerPicturesPath = new Dictionary<string, string>();
        public static IList<string> playerPicturesForFile = new List<string>();
        private static IList<string> playerPicturesFromFile = new List<string>();
        public static IList<string> favPlayerPicturesForFile = new List<string>();
        private static IList<string> favPlayerPicturesFromFile = new List<string>();

        static FileManager()
        {
            ApplicationLanguage = "hr";
            playerPicturesFromFile = ReadFromFile(PLAYERS_PATH);
            playerPicturesFromFile.ToList().ForEach(item => StorePlayerPicture(item, playerPicturesPath));
            favPlayerPicturesFromFile = ReadFromFile(FAVPLAYERS_PATH);
            favPlayerPicturesFromFile.ToList().ForEach(item => StorePlayerPicture(item, favPlayerPicturesPath));
        }

        public static void FillPlayerDictionary(string name, Bitmap image, IDictionary<string,Bitmap> location)
        {
            if (location.ContainsKey(name))
            {
                location[name] = image;
            }
            else
            {
                location.Add(name, image);
            }
        }

        public static void StorePlayerPicture(string picture, IDictionary<string, string> location)
        {
            var p_name = picture.Split(SPLITTER)[0];
            var path = picture.Split(SPLITTER)[1];
            if (location.ContainsKey(p_name))
            {
                location[p_name] = $"{path}";
            }
            else
            {
                location.Add(p_name, $"{path}");
            }
        }

        public static void SaveLanguage(string language,int width, int height)
        {
            WriteToFile(new[] { language + SPLITTER + width.ToString() + SPLITTER + height.ToString() }, SETTINGS_PATH);
            LoadLanguage();

        }

        private static void SetLanguage(string info)
        {
            string language = info.Split(SPLITTER)[0];
            if (language == "Hrvatski")
            {
                ApplicationLanguage = "hr";
            }
            else if (language == "Engleski")
            {
                ApplicationLanguage = "en";
            }
            string width = info.Split(SPLITTER)[1];
            string height = info.Split(SPLITTER)[2];
            if (width != "-1" || height != "-1")
            {
                ApplicationWidth = int.Parse(width);
                ApplicationHeight = int.Parse(height);
            }
        }

        public static void WriteToFile(string[] content, string path)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(path))
            {
                for (int i = 0; i < content.Length; i++)
                {
                    file.WriteLine(content[i]);
                }
            }
        }

        public static bool LoadLanguage() {
            List<string> temp = ReadFromFile(SETTINGS_PATH);
            if (temp.Count == 0 || temp[0] == "")
            {
                return false;
            }
            else
            {
                SetLanguage(temp[0]);
            }
            return true;
        }

        public static List<string> ReadFromFile(string PATH)
        {
            List<string> lines = new List<string>();
            using (System.IO.StreamReader file =
            new System.IO.StreamReader(PATH))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }

        public static void SavePlayers(IDictionary<string,string> source ,IList<string> destination)
        {
            //priprema slika za pohranu pri zatvaranju
            foreach (var item in source)
            {
                destination.Add($"{item.Key}{SPLITTER}{item.Value}");
            }
        }

        //public static void SaveFavPlayer()
        //{
        //    foreach (var item in favPlayerPicturesPath)
        //    {
        //        favPlayerPicturesForFile.Add($"{item.Key}{SPLITTER}{item.Value}");
        //    }
        //}

        //public static Bitmap LoadFavPlayerPictureFromCache(string name)
        //{
        //    foreach (var picture in favPlayerPicturesPath)
        //    {
        //        if (picture.Key == name)
        //        {
        //            if (File.Exists(picture.Value))
        //            {
        //                return new Bitmap(picture.Value);
        //            }
        //        }
        //    }
        //    return null;
        //}

        public static Bitmap ChoosePicture(string p_name, bool favorite)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (favorite)
                {
                    StorePlayerPicture(p_name, ofd,favPlayerPicturesPath);
                }
                else
                {
                    StorePlayerPicture(p_name, ofd, playerPicturesPath);
                }

                if (!File.Exists($"{PICTURE_DIR}{ofd.SafeFileName}"))
                {
                    File.Copy(ofd.FileName, $"{PICTURE_DIR}{ofd.SafeFileName}");
                }
                return new Bitmap(ofd.FileName);
            }
            return null;
        }

        private static void StorePlayerPicture(string p_name, OpenFileDialog ofd, IDictionary<string, string> location)
        {
            if (location.ContainsKey(p_name) || favPlayerPicturesPath.ContainsKey(p_name))
            {
                location[p_name] = $"{PICTURE_DIR}{ofd.SafeFileName}";
            }
            else
            {
                location.Add(p_name, $"{PICTURE_DIR}{ofd.SafeFileName}");
            }
        }

        public static Bitmap LoadPlayerPictureFromCache(string name,IDictionary<string,string> location)
        {
            foreach (var picture in location)
            {
                if (picture.Key == name)
                {
                    if (File.Exists(picture.Value))
                    {
                        return new Bitmap(picture.Value);
                    }
                }
            }
            return null;
        }

        public static void RemoveFromDictionary(string p_name,IDictionary<string,Bitmap> location)
        {
            if (location.ContainsKey(p_name))
            {
                location.Remove(p_name);
            }
        }
    }
}
