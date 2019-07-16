namespace Windows_Forms
{
    partial class MyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.pbFav = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblName.Location = new System.Drawing.Point(68, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(156, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ime:";
            this.lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Child_MouseDown);
            // 
            // lblNumber
            // 
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNumber.Location = new System.Drawing.Point(230, 21);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(30, 22);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Broj:";
            this.lblNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Child_MouseDown);
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPosition.Location = new System.Drawing.Point(275, 21);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(106, 22);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Pozicija:";
            this.lblPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Child_MouseDown);
            // 
            // lblCaptain
            // 
            this.lblCaptain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCaptain.Location = new System.Drawing.Point(387, 21);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(90, 22);
            this.lblCaptain.TabIndex = 6;
            this.lblCaptain.Text = "Kapetan:";
            this.lblCaptain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Child_MouseDown);
            // 
            // pbFav
            // 
            this.pbFav.Image = global::Windows_Forms.Properties.Resources.star;
            this.pbFav.Location = new System.Drawing.Point(514, 3);
            this.pbFav.Name = "pbFav";
            this.pbFav.Size = new System.Drawing.Size(50, 50);
            this.pbFav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFav.TabIndex = 8;
            this.pbFav.TabStop = false;
            this.pbFav.Visible = false;
            this.pbFav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Child_MouseDown);
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::Windows_Forms.Properties.Resources._3dplayer1;
            this.pbPlayer.Location = new System.Drawing.Point(3, 3);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 50);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 7;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Click += new System.EventHandler(this.pbPlayer_Click);
            // 
            // MyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pbFav);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Name = "MyControl";
            this.Size = new System.Drawing.Size(567, 57);
            this.tt.SetToolTip(this, "Press Ctrl + Left Click to Select");
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbFav;
        private System.Windows.Forms.ToolTip tt;
    }
}
