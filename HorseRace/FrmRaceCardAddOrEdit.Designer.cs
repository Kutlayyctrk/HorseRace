namespace HorseRace
{
    partial class FrmRaceCardAddOrEdit
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
            this.BtnAddOrEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbRace = new System.Windows.Forms.ComboBox();
            this.LstRaces = new System.Windows.Forms.ListBox();
            this.BtnRaceAdd = new System.Windows.Forms.Button();
            this.BtnDeleteRace = new System.Windows.Forms.Button();
            this.BtnActivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddOrEdit
            // 
            this.BtnAddOrEdit.Location = new System.Drawing.Point(134, 196);
            this.BtnAddOrEdit.Name = "BtnAddOrEdit";
            this.BtnAddOrEdit.Size = new System.Drawing.Size(100, 23);
            this.BtnAddOrEdit.TabIndex = 5;
            this.BtnAddOrEdit.UseVisualStyleBackColor = true;
            this.BtnAddOrEdit.Click += new System.EventHandler(this.BtnAddOrEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bulletin Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(108, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(170, 22);
            this.TxtName.TabIndex = 0;
            // 
            // TxtPlace
            // 
            this.TxtPlace.Location = new System.Drawing.Point(108, 46);
            this.TxtPlace.Name = "TxtPlace";
            this.TxtPlace.Size = new System.Drawing.Size(170, 22);
            this.TxtPlace.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Place Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Race:";
            // 
            // CmbRace
            // 
            this.CmbRace.FormattingEnabled = true;
            this.CmbRace.Location = new System.Drawing.Point(108, 88);
            this.CmbRace.Name = "CmbRace";
            this.CmbRace.Size = new System.Drawing.Size(170, 24);
            this.CmbRace.TabIndex = 2;
            // 
            // LstRaces
            // 
            this.LstRaces.FormattingEnabled = true;
            this.LstRaces.ItemHeight = 16;
            this.LstRaces.Location = new System.Drawing.Point(296, 12);
            this.LstRaces.Name = "LstRaces";
            this.LstRaces.Size = new System.Drawing.Size(240, 260);
            this.LstRaces.TabIndex = 12;
            // 
            // BtnRaceAdd
            // 
            this.BtnRaceAdd.Location = new System.Drawing.Point(134, 130);
            this.BtnRaceAdd.Name = "BtnRaceAdd";
            this.BtnRaceAdd.Size = new System.Drawing.Size(100, 23);
            this.BtnRaceAdd.TabIndex = 3;
            this.BtnRaceAdd.Text = "Add Race";
            this.BtnRaceAdd.UseVisualStyleBackColor = true;
            this.BtnRaceAdd.Click += new System.EventHandler(this.BtnRaceAdd_Click);
            // 
            // BtnDeleteRace
            // 
            this.BtnDeleteRace.Location = new System.Drawing.Point(367, 278);
            this.BtnDeleteRace.Name = "BtnDeleteRace";
            this.BtnDeleteRace.Size = new System.Drawing.Size(107, 23);
            this.BtnDeleteRace.TabIndex = 4;
            this.BtnDeleteRace.Text = "Delete Race";
            this.BtnDeleteRace.UseVisualStyleBackColor = true;
            this.BtnDeleteRace.Click += new System.EventHandler(this.BtnDeleteRace_Click);
            // 
            // BtnActivate
            // 
            this.BtnActivate.Location = new System.Drawing.Point(134, 167);
            this.BtnActivate.Name = "BtnActivate";
            this.BtnActivate.Size = new System.Drawing.Size(100, 23);
            this.BtnActivate.TabIndex = 13;
            this.BtnActivate.Text = "Activate";
            this.BtnActivate.UseVisualStyleBackColor = true;
            this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // FrmRaceCardAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 322);
            this.Controls.Add(this.BtnActivate);
            this.Controls.Add(this.BtnDeleteRace);
            this.Controls.Add(this.BtnRaceAdd);
            this.Controls.Add(this.LstRaces);
            this.Controls.Add(this.CmbRace);
            this.Controls.Add(this.BtnAddOrEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Name = "FrmRaceCardAddOrEdit";
            this.Text = "FrmRaceCardAddOrEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddOrEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbRace;
        private System.Windows.Forms.ListBox LstRaces;
        private System.Windows.Forms.Button BtnRaceAdd;
        private System.Windows.Forms.Button BtnDeleteRace;
        private System.Windows.Forms.Button BtnActivate;
    }
}