namespace HorseRace
{
    partial class FrmSelectJockey
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
            this.DgvJockeys = new System.Windows.Forms.DataGridView();
            this.TxtJockeyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelectJockey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJockeys)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvJockeys
            // 
            this.DgvJockeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvJockeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJockeys.Location = new System.Drawing.Point(12, 44);
            this.DgvJockeys.Name = "DgvJockeys";
            this.DgvJockeys.RowHeadersWidth = 51;
            this.DgvJockeys.RowTemplate.Height = 24;
            this.DgvJockeys.Size = new System.Drawing.Size(576, 255);
            this.DgvJockeys.TabIndex = 0;
            this.DgvJockeys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJockeys_CellClick);
            // 
            // TxtJockeyName
            // 
            this.TxtJockeyName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtJockeyName.Location = new System.Drawing.Point(245, 12);
            this.TxtJockeyName.Name = "TxtJockeyName";
            this.TxtJockeyName.Size = new System.Drawing.Size(162, 22);
            this.TxtJockeyName.TabIndex = 0;
            this.TxtJockeyName.TextChanged += new System.EventHandler(this.TxtJockeyName_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // BtnSelectJockey
            // 
            this.BtnSelectJockey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSelectJockey.Location = new System.Drawing.Point(216, 322);
            this.BtnSelectJockey.Name = "BtnSelectJockey";
            this.BtnSelectJockey.Size = new System.Drawing.Size(146, 29);
            this.BtnSelectJockey.TabIndex = 1;
            this.BtnSelectJockey.Text = "Approve";
            this.BtnSelectJockey.UseVisualStyleBackColor = true;
            this.BtnSelectJockey.Click += new System.EventHandler(this.BtnSelectJockey_Click);
            // 
            // FrmSelectJockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 363);
            this.Controls.Add(this.BtnSelectJockey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJockeyName);
            this.Controls.Add(this.DgvJockeys);
            this.Name = "FrmSelectJockey";
            this.Text = "FrmSelectJockey";
            ((System.ComponentModel.ISupportInitialize)(this.DgvJockeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvJockeys;
        private System.Windows.Forms.TextBox TxtJockeyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelectJockey;
    }
}