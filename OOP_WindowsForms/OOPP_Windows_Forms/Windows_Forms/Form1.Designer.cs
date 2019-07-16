namespace RWA__WindowsForms_Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.flpIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.prebaciIgraceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpFavorite = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRangiranje = new System.Windows.Forms.Button();
            this.lblDovuci = new System.Windows.Forms.Label();
            this.lblDrzave = new System.Windows.Forms.Label();
            this.lblSlika = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.lblKapetan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            this.cbTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.cbTeams, "cbTeams");
            this.cbTeams.ForeColor = System.Drawing.Color.Black;
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.SelectedIndexChanged += new System.EventHandler(this.cbTeams_SelectedIndexChanged);
            // 
            // flpIgraci
            // 
            this.flpIgraci.AllowDrop = true;
            resources.ApplyResources(this.flpIgraci, "flpIgraci");
            this.flpIgraci.ContextMenuStrip = this.cms;
            this.flpIgraci.Name = "flpIgraci";
            this.flpIgraci.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_DragDrop);
            this.flpIgraci.DragOver += new System.Windows.Forms.DragEventHandler(this.flp_DragOver);
            this.flpIgraci.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_MouseDown);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prebaciIgraceToolStripMenuItem});
            this.cms.Name = "cms";
            resources.ApplyResources(this.cms, "cms");
            // 
            // prebaciIgraceToolStripMenuItem
            // 
            this.prebaciIgraceToolStripMenuItem.Name = "prebaciIgraceToolStripMenuItem";
            resources.ApplyResources(this.prebaciIgraceToolStripMenuItem, "prebaciIgraceToolStripMenuItem");
            this.prebaciIgraceToolStripMenuItem.Click += new System.EventHandler(this.prebaciIgraceToolStripMenuItem_Click);
            // 
            // flpFavorite
            // 
            this.flpFavorite.AllowDrop = true;
            this.flpFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flpFavorite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFavorite.ContextMenuStrip = this.cms;
            resources.ApplyResources(this.flpFavorite, "flpFavorite");
            this.flpFavorite.Name = "flpFavorite";
            this.flpFavorite.DragDrop += new System.Windows.Forms.DragEventHandler(this.flp_DragDrop);
            this.flpFavorite.DragOver += new System.Windows.Forms.DragEventHandler(this.flp_DragOver);
            this.flpFavorite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flp_MouseDown);
            // 
            // btnRangiranje
            // 
            this.btnRangiranje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnRangiranje, "btnRangiranje");
            this.btnRangiranje.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRangiranje.FlatAppearance.BorderSize = 3;
            this.btnRangiranje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRangiranje.Name = "btnRangiranje";
            this.btnRangiranje.UseVisualStyleBackColor = false;
            this.btnRangiranje.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDovuci
            // 
            resources.ApplyResources(this.lblDovuci, "lblDovuci");
            this.lblDovuci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDovuci.Name = "lblDovuci";
            // 
            // lblDrzave
            // 
            resources.ApplyResources(this.lblDrzave, "lblDrzave");
            this.lblDrzave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDrzave.Name = "lblDrzave";
            // 
            // lblSlika
            // 
            resources.ApplyResources(this.lblSlika, "lblSlika");
            this.lblSlika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSlika.Name = "lblSlika";
            // 
            // lblIme
            // 
            resources.ApplyResources(this.lblIme, "lblIme");
            this.lblIme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIme.Name = "lblIme";
            // 
            // lblBroj
            // 
            resources.ApplyResources(this.lblBroj, "lblBroj");
            this.lblBroj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBroj.Name = "lblBroj";
            // 
            // lblPozicija
            // 
            resources.ApplyResources(this.lblPozicija, "lblPozicija");
            this.lblPozicija.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPozicija.Name = "lblPozicija";
            // 
            // lblKapetan
            // 
            resources.ApplyResources(this.lblKapetan, "lblKapetan");
            this.lblKapetan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblKapetan.Name = "lblKapetan";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Windows_Forms.Properties.Resources.settings;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKapetan);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblSlika);
            this.Controls.Add(this.lblDrzave);
            this.Controls.Add(this.lblDovuci);
            this.Controls.Add(this.btnRangiranje);
            this.Controls.Add(this.flpFavorite);
            this.Controls.Add(this.flpIgraci);
            this.Controls.Add(this.cbTeams);
            this.Name = "Form1";
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.FlowLayoutPanel flpIgraci;
        private System.Windows.Forms.FlowLayoutPanel flpFavorite;
        private System.Windows.Forms.Button btnRangiranje;
        private System.Windows.Forms.Label lblDovuci;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem prebaciIgraceToolStripMenuItem;
        private System.Windows.Forms.Label lblDrzave;
        private System.Windows.Forms.Label lblSlika;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Label lblKapetan;
        private System.Windows.Forms.Button button1;
    }
}

