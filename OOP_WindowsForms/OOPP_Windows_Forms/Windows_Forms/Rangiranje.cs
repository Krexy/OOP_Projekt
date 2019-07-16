using Podatkovni_sloj.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms.Properties;

namespace Windows_Forms
{
    public partial class Rangiranje : Form
    {
        private string TeamName { get; set; }
        private string TeamCode { get; set; }
        public List<Matches> Matches { get; set; }
        private List<Bitmap> btms = new List<Bitmap>();
        private int page_count = 1;
        private int btm_portion = 0;
        private int offsetY = 0;
        private IDictionary<string, Bitmap> igraci = new Dictionary<string, Bitmap>();

        public Rangiranje(string team, List<Matches> matches, IDictionary<string, Bitmap> igraci)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FileManager.ApplicationLanguage);
            TeamName = team.Substring(0, team.Length - 5);
            Matches = matches;
            this.igraci = igraci;
            InitializeComponent();
            SetComponentLanguage();
            InitializeRows();
        }

        private void SetComponentLanguage()
        {
            btnPrint.Text = Resources.Printanje;
            cLocation.HeaderText = Resources.Lokacija;
            cAttendance.HeaderText = Resources.Dolaznost;
            cAwayTeam.HeaderText = Resources.StraniTim;
            cHomeTeam.HeaderText = Resources.DomaciTim;
            cPlayerName.HeaderText = Resources.ImeIgraca;
            cPlayerPicture.HeaderText = Resources.SlikaIgraca;
            cYellowCards.HeaderText = Resources.ZutiKartoni;
            cApperance.HeaderText = Resources.Nastupi;
            cGoalsScored.HeaderText = Resources.ZabijeniGolovi;
            lblUtakmice.Text = Resources.Utakmice;
            llblIgraci.Text = Resources.Igraci;
        }

        private void InitializeRows()
        {
            Matches.ForEach(m => dgvUtakmice.Rows.Add(m.Location, m.Attendance, m.Home_Team_Country, m.Away_Team_Country));

            for (int i = 0; i < igraci.Count; i++)
            {
                var p_name = igraci.Keys.ToList()[i];
                var p_image = igraci.Values.ToList()[i];
                dgvIgraci.Rows.Add(
                    p_image,
                    p_name,
                    GetAppearance(p_name),
                    GetGoalsScored(p_name),
                    GetYellowCardCount(p_name));
            }
        }

        private int GetYellowCardCount(string p_name)
        {
            int counter = 0;
            foreach (var match in Matches)
            {
                foreach (var e in match.Home_Team_Country == TeamName ? match.Home_Team_Events : match.Away_Team_Events)
                {
                    if (e.Type_Of_Event == "yellow-card")
                    {
                        if (e.Player == p_name)
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }

        private int GetGoalsScored(string p_name)
        {
            int counter = 0;
            foreach (var match in Matches)
            {
                foreach (var e in match.Home_Team_Country == TeamName ? match.Home_Team_Events : match.Away_Team_Events)
                {
                    if (e.Type_Of_Event == "goal-penalty" || e.Type_Of_Event == "goal")
                    {
                        if (e.Player == p_name)
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }

        private int GetAppearance(string p_name)
        {
            int counter = 0;
            foreach (var match in Matches)
            {
                foreach (var player in 
                    match.Home_Team_Country == TeamName ? 
                    match.Home_Team_Statistics.Starting_Eleven : 
                    match.Away_Team_Statistics.Starting_Eleven
                    )
                {
                    if (player.Name == p_name)
                    {
                        counter++;
                    }
                    //else if (PlayerSubstitutedIn(player.Name))
                    //{
                    //    counter++;
                    //}
                }
            }
            return counter;
        }

        private bool PlayerSubstitutedIn(string igrac)
        {
            foreach (var match in Matches)
            {
                foreach (var e in match.Home_Team_Country == TeamName ? match.Home_Team_Events : match.Away_Team_Events)
                {
                    if (e.Type_Of_Event == "substitution-in")
                    {
                        if (e.Player == igrac)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    page_count = 1;
                    offsetY = 0;
                    InitializePrint(dgvUtakmice);
                    break;
                case 1:
                    page_count = 4;
                    offsetY = 235;
                    InitializePrint(dgvIgraci);
                    break;
                default:
                    break;
            }
        }

        private void InitializePrint(DataGridView dgv)
        {
            int height = dgv.Height;
            dgv.Height = dgv.RowCount * dgv.RowTemplate.Height * 2;
            int rows = dgv.Rows.Count;

            //header
            btms.Add(new Bitmap(dgv.Width, 80));
            dgv.DrawToBitmap(btms[0], new Rectangle(0, 0, dgv.Width, 80));
            //body
            btms.Add(new Bitmap(dgv.Width, dgv.Height));
            dgv.DrawToBitmap(btms[1], new Rectangle(0, 0, dgv.Width, dgv.Height));

            dgv.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(btms[0], 0, 0);
            e.Graphics.DrawImage(btms[1], new Rectangle(0, 80, e.PageBounds.Width, btms[1].Height), new Rectangle(0, 80+(1050*btm_portion), btms[1].Width, btms[1].Height - offsetY), GraphicsUnit.Pixel);

            if (page_count > 1)
            {
                e.HasMorePages = true;
                btm_portion++;
                page_count--;
                return;
            }
            else
            {
                e.HasMorePages = false;
                btms.Clear();
                btm_portion = 0;
            }
        }
    }
}
