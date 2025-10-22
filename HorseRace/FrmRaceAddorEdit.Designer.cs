namespace HorseRace
{
    partial class FrmRaceAddorEdit
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
            this.LstHorses = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbHorse = new System.Windows.Forms.ComboBox();
            this.BtnHorseDelete = new System.Windows.Forms.Button();
            this.BtnHorseAdd = new System.Windows.Forms.Button();
            this.BtnActivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddOrEdit
            // 
            this.BtnAddOrEdit.Location = new System.Drawing.Point(152, 214);
            this.BtnAddOrEdit.Name = "BtnAddOrEdit";
            this.BtnAddOrEdit.Size = new System.Drawing.Size(100, 23);
            this.BtnAddOrEdit.TabIndex = 4;
            this.BtnAddOrEdit.UseVisualStyleBackColor = true;
            this.BtnAddOrEdit.Click += new System.EventHandler(this.BtnAddOrEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Race Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(114, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(170, 22);
            this.TxtName.TabIndex = 0;
            // 
            // LstHorses
            // 
            this.LstHorses.FormattingEnabled = true;
            this.LstHorses.ItemHeight = 16;
            this.LstHorses.Location = new System.Drawing.Point(320, 12);
            this.LstHorses.Name = "LstHorses";
            this.LstHorses.Size = new System.Drawing.Size(209, 164);
            this.LstHorses.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Horse:";
            // 
            // CmbHorse
            // 
            this.CmbHorse.FormattingEnabled = true;
            this.CmbHorse.Location = new System.Drawing.Point(114, 60);
            this.CmbHorse.Name = "CmbHorse";
            this.CmbHorse.Size = new System.Drawing.Size(170, 24);
            this.CmbHorse.TabIndex = 1;
            // 
            // BtnHorseDelete
            // 
            this.BtnHorseDelete.Location = new System.Drawing.Point(367, 193);
            this.BtnHorseDelete.Name = "BtnHorseDelete";
            this.BtnHorseDelete.Size = new System.Drawing.Size(110, 23);
            this.BtnHorseDelete.TabIndex = 3;
            this.BtnHorseDelete.Text = "Delete Horse";
            this.BtnHorseDelete.UseVisualStyleBackColor = true;
            this.BtnHorseDelete.Click += new System.EventHandler(this.BtnHorseDelete_Click);
            // 
            // BtnHorseAdd
            // 
            this.BtnHorseAdd.Location = new System.Drawing.Point(152, 99);
            this.BtnHorseAdd.Name = "BtnHorseAdd";
            this.BtnHorseAdd.Size = new System.Drawing.Size(100, 23);
            this.BtnHorseAdd.TabIndex = 2;
            this.BtnHorseAdd.Text = "Add Horse";
            this.BtnHorseAdd.UseVisualStyleBackColor = true;
            this.BtnHorseAdd.Click += new System.EventHandler(this.BtnHorseAdd_Click);
            // 
            // BtnActivate
            // 
            this.BtnActivate.Location = new System.Drawing.Point(152, 185);
            this.BtnActivate.Name = "BtnActivate";
            this.BtnActivate.Size = new System.Drawing.Size(100, 23);
            this.BtnActivate.TabIndex = 9;
            this.BtnActivate.Text = "Activate";
            this.BtnActivate.UseVisualStyleBackColor = true;
            this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // FrmRaceAddorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 249);
            this.Controls.Add(this.BtnActivate);
            this.Controls.Add(this.BtnHorseAdd);
            this.Controls.Add(this.BtnHorseDelete);
            this.Controls.Add(this.CmbHorse);
            this.Controls.Add(this.LstHorses);
            this.Controls.Add(this.BtnAddOrEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtName);
            this.Name = "FrmRaceAddorEdit";
            this.Text = "FrmRaceAddorEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddOrEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ListBox LstHorses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbHorse;
        private System.Windows.Forms.Button BtnHorseDelete;
        private System.Windows.Forms.Button BtnHorseAdd;
        private System.Windows.Forms.Button BtnActivate;
    }
}