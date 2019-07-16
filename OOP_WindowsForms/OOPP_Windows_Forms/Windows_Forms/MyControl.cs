using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms.Properties;
using System.IO;
using Podatkovni_sloj.Modals;
using System.Windows.Input;

namespace Windows_Forms
{
    public partial class MyControl : UserControl
    {
        public bool Selected { get; set; }
        public bool IsFav { get; set; }
        public MyControl()
        {
            InitializeComponent();
            Selected = false;
            IsFav = false;
        }

        private void pbPlayer_Click(object sender, EventArgs e)
        {
            Bitmap btm = FileManager.ChoosePicture(lblName.Text, IsFav) ?? Resources.p5;
            pbPlayer.Image = btm;
            if (IsFav)
            {
                FileManager.FillPlayerDictionary(lblName.Text, btm, FileManager.favPlayerPictures);
            }
            else
            {
                FileManager.FillPlayerDictionary(lblName.Text, btm, FileManager.playerPictures);
            }
        }

        private void MyControl_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Keyboard.IsKeyDown(Key.LeftCtrl))
            {
                SelectDeselectControl();
            }
            else if (e.Button == MouseButtons.Left)
            {
                Cursor = System.Windows.Forms.Cursors.Hand;
                DoDragDrop(this, DragDropEffects.Move);
            }
            else if (e.Button == MouseButtons.Right)
            {
                var flp = (sender as MyControl).Parent;
                if (flp.Name == "flpFavorite")
                {
                    flp.ContextMenuStrip.AccessibleName = "fav";
                }
                else
                {
                    flp.ContextMenuStrip.AccessibleName = "igraci";
                }
            }
        }

        public void SelectDeselectControl()
        {
            if (Selected)
            {
                BackColor = Color.Black;
                Selected = false;
            }
            else
            {
                BackColor = Color.FromArgb(255, 20, 20, 20);
                Selected = true;
            }
        }

        private void Child_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (sender is PictureBox picture)
            {
                MyControl_MouseDown((sender as PictureBox).Parent, e);
            }
            else if (sender is Label lbl)
            {
                MyControl_MouseDown(lbl.Parent, e);
            }
        }
    }
}
