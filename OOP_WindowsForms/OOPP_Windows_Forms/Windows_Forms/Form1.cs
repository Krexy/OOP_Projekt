using Podatkovni_sloj.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using Windows_Forms;
using Windows_Forms.Properties;

namespace RWA__WindowsForms_Projekt
{
    public partial class Form1 : Form
    {
        private readonly Random rnd = new Random();
        private readonly string MISSING_DATA = "Nepostoji";
        private List<Matches> matches = new List<Matches>();
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FileManager.ApplicationLanguage);
            InitializeComponent();
            SetComponentLanguage();
            InitializeTeams();
        }

        private void SetComponentLanguage()
        {
            btnRangiranje.Text = Resources.Rangiranje;
            lblDrzave.Text = Resources.Drzave;
            lblBroj.Text = Resources.Broj;
            lblDovuci.Text = Resources.DovuciIgrace;
            lblIme.Text = Resources.Ime;
            lblKapetan.Text = Resources.Kapetan;
            lblPozicija.Text = Resources.Pozicija;
            lblSlika.Text = Resources.Slika;
        }

        private async void InitializeTeams()
        {
            var teams = await Podatkovni_sloj
                .Podaci
                .GetTeams();
            teams.ForEach(team => cbTeams.Items.Add($"{team.Country}({team.Fifa_Code})"));
        }

        private void CreateCircularProgressBar()
        {
            foreach (Control ctrl in Controls)
            {
                ctrl.Visible = false;
            }
            CircularProgressBar.CircularProgressBar bar = new CircularProgressBar.CircularProgressBar();
            bar.Location = new Point(Width / 2 - bar.Width / 2, Height / 2 - bar.Height / 2);
            bar.Value = 0;
            bar.Minimum = 0;
            bar.Maximum = 100;
            bar.SuperscriptText = "%";
            bar.Visible = true;
            Controls.Add(bar);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
                bar.Value = i;
                bar.Text = i.ToString();
                bar.SubscriptText = $".{rnd.Next(0, 100).ToString()}";
                bar.Update();
            }
            Controls.Remove(bar);
            bar.Dispose();
            foreach (Control ctrl in Controls)
            {
                ctrl.Visible = true;
            }
        }

        private async void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            CleanUp();
            string f_code = cbTeams.Text.Substring(cbTeams.Text.Length - 4, 3);
            matches = await Podatkovni_sloj
                        .Podaci
                        .GetMatches(f_code);
            CreateCircularProgressBar();
            if (matches[0].Home_Team.Code == f_code)
                LoadPlayers(matches[0].Home_Team_Statistics, f_code);
            else
                LoadPlayers(matches[0].Away_Team_Statistics, f_code);
            EnableControls();
        }

        private void CleanUp()
        {
            FileManager.playerPictures.Clear();
            flpIgraci.Controls.Clear();
            flpFavorite.Controls.Clear();
        }

        private void EnableControls()
        {
            btnRangiranje.Enabled = true;
            foreach (var ctrl in Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.Visible = true;
                }
            }
        }

        private void LoadPlayers(Team_Statistics x, string f_code)
        {
            {
                foreach (var player in x.Starting_Eleven)
                {
                    var control = new MyControl();
                    control.Controls["lblName"].Text = player.Name ?? MISSING_DATA;
                    control.Controls["lblNumber"].Text = player.Shirt_Number.ToString();
                    control.Controls["lblPosition"].Text = player.Position ?? MISSING_DATA;
                    control.Controls["lblCaptain"].Text = player.Captain == true ? Resources.Pozitivno : Resources.Negativno;
                    SetPlayerPicture(control, player.Name);
                    flpIgraci.Controls.Add(control);
                }
                foreach (var sub in x.Substitutes)
                {
                    var control = new MyControl();
                    control.Controls["lblName"].Text = sub.Name ?? MISSING_DATA;
                    control.Controls["lblNumber"].Text = sub.Shirt_Number.ToString();
                    control.Controls["lblPosition"].Text = sub.Position ?? MISSING_DATA;
                    control.Controls["lblCaptain"].Text = sub.Captain == true ? Resources.Pozitivno : Resources.Negativno;
                    SetPlayerPicture(control, sub.Name);
                    flpIgraci.Controls.Add(control);
                }
            }
        }

        private void SetPlayerPicture(MyControl control, string name)
        {
            foreach (var type in control.Controls)
            {
                if (type is PictureBox ctrl)
                {
                    if (ctrl.Name == "pbPlayer")
                    {
                        Bitmap image;
                        if (control.IsFav)
                        {
                            image = FileManager.LoadPlayerPictureFromCache(name, FileManager.favPlayerPicturesPath);
                        }
                        else
                        {
                            image = FileManager.LoadPlayerPictureFromCache(name, FileManager.playerPicturesPath);
                        }
                        if (image != null)
                        {
                            ctrl.Image = image;
                            if (control.IsFav)
                            {
                                FileManager.FillPlayerDictionary(name, image, FileManager.favPlayerPictures);
                            }
                            else
                            {
                                FileManager.FillPlayerDictionary(name, image, FileManager.playerPictures);
                            }
                        }
                        else
                        {
                            switch (rnd.Next(0, 2))
                            {
                                case 0:
                                    ctrl.Image = Resources.p5;
                                    if (control.IsFav)
                                    {
                                        FileManager.FillPlayerDictionary(name, Resources.p5, FileManager.favPlayerPictures);
                                    }
                                    else
                                    {
                                        FileManager.FillPlayerDictionary(name, Resources.p5, FileManager.playerPictures);
                                    }
                                    break;
                                case 1:
                                    ctrl.Image = Resources.p6;
                                    if (control.IsFav)
                                    {
                                        FileManager.FillPlayerDictionary(name, Resources.p6, FileManager.favPlayerPictures);
                                    }
                                    else
                                    {
                                        FileManager.FillPlayerDictionary(name, Resources.p6, FileManager.playerPictures);
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rangiranje = new Rangiranje(cbTeams.Text, matches, FileManager.playerPictures);
            rangiranje.ShowDialog(this);
            rangiranje.Dispose();
        }

        private void flp_DragDrop(object sender, DragEventArgs e)
        {
            MyControl ctrl = (MyControl)e.Data.GetData(typeof(MyControl));
            var flp = sender as FlowLayoutPanel;
            PrebaciIgraca(flp, ctrl);

        }

        private void PrebaciIgraca(FlowLayoutPanel flp, MyControl ctrl)
        {
            if (flp.Name == "flpFavorite")
            {
                if (flp.Controls.Count < 3)
                {
                    ctrl.IsFav = true;
                    SwapFavPlayers(ctrl, FileManager.playerPictures, FileManager.favPlayerPictures);
                    SetStar(flp, ctrl);
                    flp.Controls.Add(ctrl);
                }
            }
            else
            {
                ctrl.IsFav = false;
                SwapFavPlayers(ctrl, FileManager.favPlayerPictures, FileManager.playerPictures);
                SetStar(flp, ctrl);
                flp.Controls.Add(ctrl);
            }

        }

        private void SwapFavPlayers(MyControl ctrl, IDictionary<string, Bitmap> source, IDictionary<string, Bitmap> destination)
        {
            foreach (var item in ctrl.Controls)
            {
                if (item is Label lbl)
                {
                    if (lbl.Name == "lblName")
                    {
                        if (source.ContainsKey(lbl.Text))
                        {
                            FileManager.FillPlayerDictionary(lbl.Text, source[lbl.Text], destination);
                            FileManager.RemoveFromDictionary(lbl.Text, source);
                        }
                    }
                }
            }
        }

        private void SetStar(FlowLayoutPanel flp, MyControl ctrl)
        {

            foreach (var item in ctrl.Controls)
            {
                if (item is PictureBox picture)
                {
                    if (picture.Name == "pbFav")
                    {
                        if (flp.Name == "flpFavorite")
                        {
                            picture.Visible = true;
                        }
                        else
                        {
                            picture.Visible = false;
                        }
                    }
                }
            }
        }

        private void flp_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void prebaciIgraceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                if (item.GetCurrentParent().AccessibleName == "igraci")
                {
                    foreach (var ctrl in flpIgraci.Controls)
                    {
                        if (ctrl is MyControl mc)
                        {
                            if (mc.Selected == true)
                            {
                                mc.SelectDeselectControl();
                                PrebaciIgraca(flpFavorite, mc);
                            }
                        }
                    }
                }
                else
                {
                    foreach (var ctrl in flpFavorite.Controls)
                    {
                        if (ctrl is MyControl mc)
                        {
                            if (mc.Selected == true)
                            {
                                mc.SelectDeselectControl();
                                PrebaciIgraca(flpIgraci, mc);
                            }
                        }
                    }
                }
            }
        }

        public void flp_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((sender as FlowLayoutPanel).Name == "flpFavorite")
                {
                    cms.AccessibleName = "fav";
                }
                else
                {
                    cms.AccessibleName = "igraci";
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            string msg = Resources.Zatvaranje;
            DialogResult result = MessageBox.Show(msg, Resources.ZatvaranjeNaslov,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                FileManager.WriteToFile(new[] { cbTeams.Text }, FileManager.FAV_COUNTRY);
            else if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var temp = new Postavke();
            temp.ShowDialog();
            string msg = Resources.PromjenePostavki;
            MessageBox.Show(msg, Resources.PromjenePostavkiNaslov,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
