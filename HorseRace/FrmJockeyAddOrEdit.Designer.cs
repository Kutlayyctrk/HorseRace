namespace HorseRace
{
    partial class FrmJockeyAddOrEdit
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
            this.TxtJockeyName = new System.Windows.Forms.TextBox();
            this.TxtJockeyAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddOrEdit = new System.Windows.Forms.Button();
            this.BtnActivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtJockeyName
            // 
            this.TxtJockeyName.Location = new System.Drawing.Point(198, 60);
            this.TxtJockeyName.Name = "TxtJockeyName";
            this.TxtJockeyName.Size = new System.Drawing.Size(170, 22);
            this.TxtJockeyName.TabIndex = 0;
            // 
            // TxtJockeyAge
            // 
            this.TxtJockeyAge.Location = new System.Drawing.Point(198, 110);
            this.TxtJockeyAge.Name = "TxtJockeyAge";
            this.TxtJockeyAge.Size = new System.Drawing.Size(170, 22);
            this.TxtJockeyAge.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jockey Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jockey Age:";
            // 
            // BtnAddOrEdit
            // 
            this.BtnAddOrEdit.Location = new System.Drawing.Point(238, 189);
            this.BtnAddOrEdit.Name = "BtnAddOrEdit";
            this.BtnAddOrEdit.Size = new System.Drawing.Size(100, 23);
            this.BtnAddOrEdit.TabIndex = 2;
            this.BtnAddOrEdit.UseVisualStyleBackColor = true;
            this.BtnAddOrEdit.Click += new System.EventHandler(this.BtnAddOrEdit_Click);
            // 
            // BtnActivate
            // 
            this.BtnActivate.Location = new System.Drawing.Point(238, 160);
            this.BtnActivate.Name = "BtnActivate";
            this.BtnActivate.Size = new System.Drawing.Size(100, 23);
            this.BtnActivate.TabIndex = 3;
            this.BtnActivate.Text = "Activate";
            this.BtnActivate.UseVisualStyleBackColor = true;
            this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // FrmJockeyAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 323);
            this.Controls.Add(this.BtnActivate);
            this.Controls.Add(this.BtnAddOrEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJockeyAge);
            this.Controls.Add(this.TxtJockeyName);
            this.Name = "FrmJockeyAddOrEdit";
            this.Text = "FrmJockeyAddOrEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtJockeyName;
        private System.Windows.Forms.TextBox TxtJockeyAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddOrEdit;
        private System.Windows.Forms.Button BtnActivate;
    }
}