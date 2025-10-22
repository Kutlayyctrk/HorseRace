namespace HorseRace
{
    partial class FrmRaceDayAddOrEdit
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LstBulletin = new System.Windows.Forms.ListBox();
            this.BtnDeleteBulletin = new System.Windows.Forms.Button();
            this.BtnAddBulletin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBulletin = new System.Windows.Forms.ComboBox();
            this.BtnActivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddOrEdit
            // 
            this.BtnAddOrEdit.Location = new System.Drawing.Point(159, 234);
            this.BtnAddOrEdit.Name = "BtnAddOrEdit";
            this.BtnAddOrEdit.Size = new System.Drawing.Size(123, 23);
            this.BtnAddOrEdit.TabIndex = 5;
            this.BtnAddOrEdit.UseVisualStyleBackColor = true;
            this.BtnAddOrEdit.Click += new System.EventHandler(this.BtnAddOrEdit_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(143, 3);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(139, 22);
            this.TxtName.TabIndex = 0;
            // 
            // DtpDate
            // 
            this.DtpDate.Location = new System.Drawing.Point(82, 44);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(200, 22);
            this.DtpDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Race Day Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Time:";
            // 
            // LstBulletin
            // 
            this.LstBulletin.FormattingEnabled = true;
            this.LstBulletin.ItemHeight = 16;
            this.LstBulletin.Location = new System.Drawing.Point(361, 9);
            this.LstBulletin.Name = "LstBulletin";
            this.LstBulletin.Size = new System.Drawing.Size(172, 212);
            this.LstBulletin.TabIndex = 4;
            // 
            // BtnDeleteBulletin
            // 
            this.BtnDeleteBulletin.Location = new System.Drawing.Point(384, 234);
            this.BtnDeleteBulletin.Name = "BtnDeleteBulletin";
            this.BtnDeleteBulletin.Size = new System.Drawing.Size(123, 23);
            this.BtnDeleteBulletin.TabIndex = 4;
            this.BtnDeleteBulletin.Text = "Delete Bulletin";
            this.BtnDeleteBulletin.UseVisualStyleBackColor = true;
            this.BtnDeleteBulletin.Click += new System.EventHandler(this.BtnDeleteBulletin_Click);
            // 
            // BtnAddBulletin
            // 
            this.BtnAddBulletin.Location = new System.Drawing.Point(159, 134);
            this.BtnAddBulletin.Name = "BtnAddBulletin";
            this.BtnAddBulletin.Size = new System.Drawing.Size(123, 23);
            this.BtnAddBulletin.TabIndex = 3;
            this.BtnAddBulletin.Text = "Add Bulletin";
            this.BtnAddBulletin.UseVisualStyleBackColor = true;
            this.BtnAddBulletin.Click += new System.EventHandler(this.BtnAddBulletin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bulletin:";
            // 
            // CmbBulletin
            // 
            this.CmbBulletin.FormattingEnabled = true;
            this.CmbBulletin.Location = new System.Drawing.Point(143, 87);
            this.CmbBulletin.Name = "CmbBulletin";
            this.CmbBulletin.Size = new System.Drawing.Size(139, 24);
            this.CmbBulletin.TabIndex = 2;
            // 
            // BtnActivate
            // 
            this.BtnActivate.Location = new System.Drawing.Point(159, 198);
            this.BtnActivate.Name = "BtnActivate";
            this.BtnActivate.Size = new System.Drawing.Size(123, 23);
            this.BtnActivate.TabIndex = 7;
            this.BtnActivate.Text = "Activate";
            this.BtnActivate.UseVisualStyleBackColor = true;
            this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // FrmRaceDayAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 289);
            this.Controls.Add(this.BtnActivate);
            this.Controls.Add(this.CmbBulletin);
            this.Controls.Add(this.BtnAddBulletin);
            this.Controls.Add(this.BtnDeleteBulletin);
            this.Controls.Add(this.LstBulletin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnAddOrEdit);
            this.Name = "FrmRaceDayAddOrEdit";
            this.Text = "FrmRaceDayAddOrEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddOrEdit;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LstBulletin;
        private System.Windows.Forms.Button BtnDeleteBulletin;
        private System.Windows.Forms.Button BtnAddBulletin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbBulletin;
        private System.Windows.Forms.Button BtnActivate;
    }
}