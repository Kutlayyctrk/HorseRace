namespace HorseRace
{
    partial class FrmMain
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
            this.BtnAddJockey = new System.Windows.Forms.Button();
            this.BtnAddHorse = new System.Windows.Forms.Button();
            this.BtnAddRaceDay = new System.Windows.Forms.Button();
            this.BtnAddBulletin = new System.Windows.Forms.Button();
            this.BtnAddRace = new System.Windows.Forms.Button();
            this.BtnShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddJockey
            // 
            this.BtnAddJockey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddJockey.Location = new System.Drawing.Point(102, 94);
            this.BtnAddJockey.Name = "BtnAddJockey";
            this.BtnAddJockey.Size = new System.Drawing.Size(150, 74);
            this.BtnAddJockey.TabIndex = 0;
            this.BtnAddJockey.Text = "Add Jockey";
            this.BtnAddJockey.UseVisualStyleBackColor = true;
            this.BtnAddJockey.Click += new System.EventHandler(this.BtnAddJockey_Click);
            // 
            // BtnAddHorse
            // 
            this.BtnAddHorse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddHorse.Location = new System.Drawing.Point(257, 94);
            this.BtnAddHorse.Name = "BtnAddHorse";
            this.BtnAddHorse.Size = new System.Drawing.Size(150, 74);
            this.BtnAddHorse.TabIndex = 0;
            this.BtnAddHorse.Text = "Add Horse";
            this.BtnAddHorse.UseVisualStyleBackColor = true;
            this.BtnAddHorse.Click += new System.EventHandler(this.BtnAddHorse_Click);
            // 
            // BtnAddRaceDay
            // 
            this.BtnAddRaceDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddRaceDay.Location = new System.Drawing.Point(412, 94);
            this.BtnAddRaceDay.Name = "BtnAddRaceDay";
            this.BtnAddRaceDay.Size = new System.Drawing.Size(150, 74);
            this.BtnAddRaceDay.TabIndex = 0;
            this.BtnAddRaceDay.Text = "Add RaceDay";
            this.BtnAddRaceDay.UseVisualStyleBackColor = true;
            this.BtnAddRaceDay.Click += new System.EventHandler(this.BtnAddRaceDay_Click);
            // 
            // BtnAddBulletin
            // 
            this.BtnAddBulletin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddBulletin.Location = new System.Drawing.Point(567, 94);
            this.BtnAddBulletin.Name = "BtnAddBulletin";
            this.BtnAddBulletin.Size = new System.Drawing.Size(150, 74);
            this.BtnAddBulletin.TabIndex = 0;
            this.BtnAddBulletin.Text = "Add Bulletin";
            this.BtnAddBulletin.UseVisualStyleBackColor = true;
            this.BtnAddBulletin.Click += new System.EventHandler(this.BtnAddBulletin_Click);
            // 
            // BtnAddRace
            // 
            this.BtnAddRace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddRace.Location = new System.Drawing.Point(722, 94);
            this.BtnAddRace.Name = "BtnAddRace";
            this.BtnAddRace.Size = new System.Drawing.Size(150, 74);
            this.BtnAddRace.TabIndex = 0;
            this.BtnAddRace.Text = "Add Race";
            this.BtnAddRace.UseVisualStyleBackColor = true;
            this.BtnAddRace.Click += new System.EventHandler(this.BtnAddRace_Click);
            // 
            // BtnShowInfo
            // 
            this.BtnShowInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnShowInfo.Location = new System.Drawing.Point(412, 174);
            this.BtnShowInfo.Name = "BtnShowInfo";
            this.BtnShowInfo.Size = new System.Drawing.Size(150, 74);
            this.BtnShowInfo.TabIndex = 0;
            this.BtnShowInfo.Text = "Info";
            this.BtnShowInfo.UseVisualStyleBackColor = true;
            this.BtnShowInfo.Click += new System.EventHandler(this.BtnShowInfo_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 472);
            this.Controls.Add(this.BtnAddRace);
            this.Controls.Add(this.BtnShowInfo);
            this.Controls.Add(this.BtnAddBulletin);
            this.Controls.Add(this.BtnAddRaceDay);
            this.Controls.Add(this.BtnAddHorse);
            this.Controls.Add(this.BtnAddJockey);
            this.Name = "FrmMain";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddJockey;
        private System.Windows.Forms.Button BtnAddHorse;
        private System.Windows.Forms.Button BtnAddRaceDay;
        private System.Windows.Forms.Button BtnAddBulletin;
        private System.Windows.Forms.Button BtnAddRace;
        private System.Windows.Forms.Button BtnShowInfo;
    }
}