using Podatkovni_sloj.Modals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Player.xaml
    /// </summary>
    public partial class Player : UserControl
    {
        private Matches match;
        private Podatkovni_sloj.Modals.Player player;
        public Player(Podatkovni_sloj.Modals.Player player,Matches match)
        {
            this.match = match;
            this.player = player;
            InitializeComponent();
            SetPlayer(player,match);
            //Thickness padding = Padding;
            //padding.Left = MainWindow.rnd.Next(0, 50);
            ////margin.Bottom = MainWindow.rnd.Next(0, 50);
            ////margin.Top = MainWindow.rnd.Next(0, 50);
            //padding.Right= MainWindow.rnd.Next(0, 50);
            //Padding = padding;

        }

        private void SetPlayer(Podatkovni_sloj.Modals.Player player,Matches match)
        {

            System.Drawing.Bitmap image;
            image = FileManager.LoadPlayerPictureFromCache(player.Name, FileManager.playerPicturesPath);

            if (image == null)
            {
                image = Properties.Resources.p5;
            }
            pImage.Source = MainWindow.BitmapToImageSource(image);
            pNumber.Text = player.Shirt_Number.ToString();
            pName.Text = player.Name;
            
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var temp = new PlayerStats(player,pImage.Source,match);
            temp.ShowDialog();
        }
    }
}
