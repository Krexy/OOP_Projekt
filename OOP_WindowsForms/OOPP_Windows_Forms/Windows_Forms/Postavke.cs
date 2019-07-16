using Podatkovni_sloj.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Forms.Properties;

namespace Windows_Forms
{
    public partial class Postavke : Form
    {
        public Postavke()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(FileManager.ApplicationLanguage);
            InitializeComponent();
            SetComponentLanguage();
        }

        private void SetComponentLanguage()
        {
            lblNaslov.Text = Resources.OdaberiJezik;
            btnEngleski.Text = Resources.Engleski;
            btnHrvatski.Text = Resources.Hrvatski;
        }

        private void OnLanguageBtnClick(object sender, EventArgs e)
        {
            var btn = sender as Button;

            string msg1 = Resources.SpremanjeJezika1;
            string msg2 = Resources.SpremanjeJezika2;
            DialogResult result = MessageBox.Show(msg1 + btn.Text + msg2, Resources.SpremanjeJezikaNaslov,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FileManager.SaveLanguage(btn.AccessibleName, -1, -1);
                Close();
            }

        }
    }
}
