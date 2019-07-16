namespace Windows_Forms
{
    partial class Postavke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postavke));
            this.lblNaslov = new System.Windows.Forms.Label();
            this.btnHrvatski = new System.Windows.Forms.Button();
            this.btnEngleski = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            resources.ApplyResources(this.lblNaslov, "lblNaslov");
            this.lblNaslov.Name = "lblNaslov";
            // 
            // btnHrvatski
            // 
            resources.ApplyResources(this.btnHrvatski, "btnHrvatski");
            this.btnHrvatski.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHrvatski.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHrvatski.FlatAppearance.BorderSize = 3;
            this.btnHrvatski.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHrvatski.Name = "btnHrvatski";
            this.btnHrvatski.UseVisualStyleBackColor = false;
            this.btnHrvatski.Click += new System.EventHandler(this.OnLanguageBtnClick);
            // 
            // btnEngleski
            // 
            resources.ApplyResources(this.btnEngleski, "btnEngleski");
            this.btnEngleski.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEngleski.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEngleski.FlatAppearance.BorderSize = 3;
            this.btnEngleski.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEngleski.Name = "btnEngleski";
            this.btnEngleski.UseVisualStyleBackColor = false;
            this.btnEngleski.Click += new System.EventHandler(this.OnLanguageBtnClick);
            // 
            // Postavke
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.btnEngleski);
            this.Controls.Add(this.btnHrvatski);
            this.Controls.Add(this.lblNaslov);
            this.Name = "Postavke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button btnHrvatski;
        private System.Windows.Forms.Button btnEngleski;
    }
}