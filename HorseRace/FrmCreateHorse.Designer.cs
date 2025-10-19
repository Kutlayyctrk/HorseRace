namespace HorseRace
{
    partial class FrmCreateHorse
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
            this.BtnAddHorse = new System.Windows.Forms.Button();
            this.BtnDeleteHorse = new System.Windows.Forms.Button();
            this.BtnEditHorse = new System.Windows.Forms.Button();
            this.dgvResultHorse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultHorse)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddHorse
            // 
            this.BtnAddHorse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddHorse.Location = new System.Drawing.Point(192, 37);
            this.BtnAddHorse.Name = "BtnAddHorse";
            this.BtnAddHorse.Size = new System.Drawing.Size(105, 23);
            this.BtnAddHorse.TabIndex = 0;
            this.BtnAddHorse.Text = "Add Horse";
            this.BtnAddHorse.UseVisualStyleBackColor = true;
            this.BtnAddHorse.Click += new System.EventHandler(this.BtnAddHorse_Click);
            // 
            // BtnDeleteHorse
            // 
            this.BtnDeleteHorse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDeleteHorse.Location = new System.Drawing.Point(319, 37);
            this.BtnDeleteHorse.Name = "BtnDeleteHorse";
            this.BtnDeleteHorse.Size = new System.Drawing.Size(119, 23);
            this.BtnDeleteHorse.TabIndex = 1;
            this.BtnDeleteHorse.Text = "Delete Horse";
            this.BtnDeleteHorse.UseVisualStyleBackColor = true;
            this.BtnDeleteHorse.Click += new System.EventHandler(this.BtnDeleteHorse_Click);
            // 
            // BtnEditHorse
            // 
            this.BtnEditHorse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEditHorse.Location = new System.Drawing.Point(471, 37);
            this.BtnEditHorse.Name = "BtnEditHorse";
            this.BtnEditHorse.Size = new System.Drawing.Size(105, 23);
            this.BtnEditHorse.TabIndex = 2;
            this.BtnEditHorse.Text = "Edit Horse";
            this.BtnEditHorse.UseVisualStyleBackColor = true;
            this.BtnEditHorse.Click += new System.EventHandler(this.BtnEditHorse_Click);
            // 
            // dgvResultHorse
            // 
            this.dgvResultHorse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultHorse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultHorse.Location = new System.Drawing.Point(132, 78);
            this.dgvResultHorse.Name = "dgvResultHorse";
            this.dgvResultHorse.RowHeadersWidth = 51;
            this.dgvResultHorse.RowTemplate.Height = 24;
            this.dgvResultHorse.Size = new System.Drawing.Size(509, 350);
            this.dgvResultHorse.TabIndex = 3;
            this.dgvResultHorse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultHorse_CellClick);
            // 
            // FrmCreateHorse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResultHorse);
            this.Controls.Add(this.BtnEditHorse);
            this.Controls.Add(this.BtnDeleteHorse);
            this.Controls.Add(this.BtnAddHorse);
            this.Name = "FrmCreateHorse";
            this.Text = "FrmCreateHorse";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultHorse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddHorse;
        private System.Windows.Forms.Button BtnDeleteHorse;
        private System.Windows.Forms.Button BtnEditHorse;
        private System.Windows.Forms.DataGridView dgvResultHorse;
    }
}