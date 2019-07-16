namespace Windows_Forms
{
    partial class Rangiranje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rangiranje));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.lblUtakmice = new System.Windows.Forms.TabPage();
            this.dgvUtakmice = new System.Windows.Forms.DataGridView();
            this.cLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAttendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHomeTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAwayTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llblIgraci = new System.Windows.Forms.TabPage();
            this.dgvIgraci = new System.Windows.Forms.DataGridView();
            this.cPlayerPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.cPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApperance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cYellowCards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGoalsScored = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.lblUtakmice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).BeginInit();
            this.llblIgraci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.lblUtakmice);
            this.tabControl.Controls.Add(this.llblIgraci);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // lblUtakmice
            // 
            this.lblUtakmice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUtakmice.Controls.Add(this.dgvUtakmice);
            resources.ApplyResources(this.lblUtakmice, "lblUtakmice");
            this.lblUtakmice.Name = "lblUtakmice";
            // 
            // dgvUtakmice
            // 
            this.dgvUtakmice.AllowUserToAddRows = false;
            this.dgvUtakmice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUtakmice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            resources.ApplyResources(this.dgvUtakmice, "dgvUtakmice");
            this.dgvUtakmice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUtakmice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLocation,
            this.cAttendance,
            this.cHomeTeam,
            this.cAwayTeam});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUtakmice.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvUtakmice.EnableHeadersVisualStyles = false;
            this.dgvUtakmice.MultiSelect = false;
            this.dgvUtakmice.Name = "dgvUtakmice";
            this.dgvUtakmice.ReadOnly = true;
            this.dgvUtakmice.RowHeadersVisible = false;
            this.dgvUtakmice.RowTemplate.Height = 150;
            this.dgvUtakmice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cLocation
            // 
            this.cLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cLocation.DefaultCellStyle = dataGridViewCellStyle15;
            resources.ApplyResources(this.cLocation, "cLocation");
            this.cLocation.Name = "cLocation";
            this.cLocation.ReadOnly = true;
            this.cLocation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cAttendance
            // 
            this.cAttendance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cAttendance.DefaultCellStyle = dataGridViewCellStyle16;
            resources.ApplyResources(this.cAttendance, "cAttendance");
            this.cAttendance.Name = "cAttendance";
            this.cAttendance.ReadOnly = true;
            this.cAttendance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cHomeTeam
            // 
            this.cHomeTeam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cHomeTeam.DefaultCellStyle = dataGridViewCellStyle17;
            resources.ApplyResources(this.cHomeTeam, "cHomeTeam");
            this.cHomeTeam.Name = "cHomeTeam";
            this.cHomeTeam.ReadOnly = true;
            this.cHomeTeam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cAwayTeam
            // 
            this.cAwayTeam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cAwayTeam.DefaultCellStyle = dataGridViewCellStyle18;
            resources.ApplyResources(this.cAwayTeam, "cAwayTeam");
            this.cAwayTeam.Name = "cAwayTeam";
            this.cAwayTeam.ReadOnly = true;
            this.cAwayTeam.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // llblIgraci
            // 
            this.llblIgraci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.llblIgraci.Controls.Add(this.dgvIgraci);
            resources.ApplyResources(this.llblIgraci, "llblIgraci");
            this.llblIgraci.Name = "llblIgraci";
            // 
            // dgvIgraci
            // 
            this.dgvIgraci.AllowUserToAddRows = false;
            this.dgvIgraci.AllowUserToDeleteRows = false;
            this.dgvIgraci.AllowUserToResizeColumns = false;
            this.dgvIgraci.AllowUserToResizeRows = false;
            this.dgvIgraci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIgraci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            resources.ApplyResources(this.dgvIgraci, "dgvIgraci");
            this.dgvIgraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIgraci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPlayerPicture,
            this.cPlayerName,
            this.cApperance,
            this.cYellowCards,
            this.cGoalsScored});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIgraci.DefaultCellStyle = dataGridViewCellStyle25;
            this.dgvIgraci.EnableHeadersVisualStyles = false;
            this.dgvIgraci.GridColor = System.Drawing.Color.Silver;
            this.dgvIgraci.MultiSelect = false;
            this.dgvIgraci.Name = "dgvIgraci";
            this.dgvIgraci.ReadOnly = true;
            this.dgvIgraci.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIgraci.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvIgraci.RowHeadersVisible = false;
            this.dgvIgraci.RowTemplate.Height = 150;
            this.dgvIgraci.RowTemplate.ReadOnly = true;
            this.dgvIgraci.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cPlayerPicture
            // 
            this.cPlayerPicture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.cPlayerPicture, "cPlayerPicture");
            this.cPlayerPicture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.cPlayerPicture.Name = "cPlayerPicture";
            this.cPlayerPicture.ReadOnly = true;
            this.cPlayerPicture.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cPlayerName
            // 
            this.cPlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cPlayerName.DefaultCellStyle = dataGridViewCellStyle21;
            resources.ApplyResources(this.cPlayerName, "cPlayerName");
            this.cPlayerName.Name = "cPlayerName";
            this.cPlayerName.ReadOnly = true;
            this.cPlayerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cApperance
            // 
            this.cApperance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cApperance.DefaultCellStyle = dataGridViewCellStyle22;
            resources.ApplyResources(this.cApperance, "cApperance");
            this.cApperance.Name = "cApperance";
            this.cApperance.ReadOnly = true;
            this.cApperance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cYellowCards
            // 
            this.cYellowCards.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cYellowCards.DefaultCellStyle = dataGridViewCellStyle23;
            resources.ApplyResources(this.cYellowCards, "cYellowCards");
            this.cYellowCards.Name = "cYellowCards";
            this.cYellowCards.ReadOnly = true;
            this.cYellowCards.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // cGoalsScored
            // 
            this.cGoalsScored.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cGoalsScored.DefaultCellStyle = dataGridViewCellStyle24;
            resources.ApplyResources(this.cGoalsScored, "cGoalsScored");
            this.cGoalsScored.Name = "cGoalsScored";
            this.cGoalsScored.ReadOnly = true;
            this.cGoalsScored.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.FlatAppearance.BorderSize = 3;
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Rangiranje
            // 
            this.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tabControl);
            this.Name = "Rangiranje";
            this.tabControl.ResumeLayout(false);
            this.lblUtakmice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmice)).EndInit();
            this.llblIgraci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgraci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage lblUtakmice;
        private System.Windows.Forms.TabPage llblIgraci;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgvUtakmice;
        private System.Windows.Forms.DataGridView dgvIgraci;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHomeTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAwayTeam;
        private System.Windows.Forms.DataGridViewImageColumn cPlayerPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApperance;
        private System.Windows.Forms.DataGridViewTextBoxColumn cYellowCards;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGoalsScored;
    }
}