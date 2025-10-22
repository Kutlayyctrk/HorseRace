namespace HorseRace
{
    partial class FrmHorseAddOrEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtRegion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnActivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddOrEdit
            // 
            this.BtnAddOrEdit.Location = new System.Drawing.Point(268, 165);
            this.BtnAddOrEdit.Name = "BtnAddOrEdit";
            this.BtnAddOrEdit.Size = new System.Drawing.Size(112, 23);
            this.BtnAddOrEdit.TabIndex = 3;
            this.BtnAddOrEdit.UseVisualStyleBackColor = true;
            this.BtnAddOrEdit.Click += new System.EventHandler(this.BtnAddOrEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(239, 65);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(170, 22);
            this.TxtAge.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(239, 21);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(170, 22);
            this.TxtName.TabIndex = 0;
            // 
            // TxtRegion
            // 
            this.TxtRegion.Location = new System.Drawing.Point(239, 108);
            this.TxtRegion.Name = "TxtRegion";
            this.TxtRegion.Size = new System.Drawing.Size(170, 22);
            this.TxtRegion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Region:";
            // 
            // BtnActivate
            // 
            this.BtnActivate.Location = new System.Drawing.Point(268, 136);
            this.BtnActivate.Name = "BtnActivate";
            this.BtnActivate.Size = new System.Drawing.Size(112, 23);
            this.BtnActivate.TabIndex = 7;
            this.BtnActivate.Text = "Activate";
            this.BtnActivate.UseVisualStyleBackColor = true;
            this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // FrmHorseAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 244);
            this.Controls.Add(this.BtnActivate);
            this.Controls.Add(this.BtnAddOrEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRegion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtName);
            this.Name = "FrmHorseAddOrEdit";
            this.Text = "FrmHorseAddOrEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddOrEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnActivate;
    }
}