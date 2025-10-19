namespace HorseRace
{
    partial class FrmCreateJockey
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
            this.dgvResultJockey = new System.Windows.Forms.DataGridView();
            this.BtnEditJockey = new System.Windows.Forms.Button();
            this.BtnDeleteJockey = new System.Windows.Forms.Button();
            this.BtnAddJockey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultJockey)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultJockey
            // 
            this.dgvResultJockey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultJockey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultJockey.Location = new System.Drawing.Point(146, 71);
            this.dgvResultJockey.Name = "dgvResultJockey";
            this.dgvResultJockey.RowHeadersWidth = 51;
            this.dgvResultJockey.RowTemplate.Height = 24;
            this.dgvResultJockey.Size = new System.Drawing.Size(505, 346);
            this.dgvResultJockey.TabIndex = 3;
            this.dgvResultJockey.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultJockey_CellClick);
            // 
            // BtnEditJockey
            // 
            this.BtnEditJockey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEditJockey.Location = new System.Drawing.Point(483, 30);
            this.BtnEditJockey.Name = "BtnEditJockey";
            this.BtnEditJockey.Size = new System.Drawing.Size(105, 23);
            this.BtnEditJockey.TabIndex = 2;
            this.BtnEditJockey.Text = "Edit Jockey";
            this.BtnEditJockey.UseVisualStyleBackColor = true;
            this.BtnEditJockey.Click += new System.EventHandler(this.BtnEditJockey_Click);
            // 
            // BtnDeleteJockey
            // 
            this.BtnDeleteJockey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDeleteJockey.Location = new System.Drawing.Point(342, 30);
            this.BtnDeleteJockey.Name = "BtnDeleteJockey";
            this.BtnDeleteJockey.Size = new System.Drawing.Size(114, 23);
            this.BtnDeleteJockey.TabIndex = 1;
            this.BtnDeleteJockey.Text = "Delete Jockey";
            this.BtnDeleteJockey.UseVisualStyleBackColor = true;
            this.BtnDeleteJockey.Click += new System.EventHandler(this.BtnDeleteJockey_Click);
            // 
            // BtnAddJockey
            // 
            this.BtnAddJockey.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddJockey.Location = new System.Drawing.Point(204, 30);
            this.BtnAddJockey.Name = "BtnAddJockey";
            this.BtnAddJockey.Size = new System.Drawing.Size(105, 23);
            this.BtnAddJockey.TabIndex = 0;
            this.BtnAddJockey.Text = "Add Jockey";
            this.BtnAddJockey.UseVisualStyleBackColor = true;
            this.BtnAddJockey.Click += new System.EventHandler(this.BtnAddJockey_Click);
            // 
            // FrmCreateJockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 446);
            this.Controls.Add(this.dgvResultJockey);
            this.Controls.Add(this.BtnEditJockey);
            this.Controls.Add(this.BtnDeleteJockey);
            this.Controls.Add(this.BtnAddJockey);
            this.Name = "FrmCreateJockey";
            this.Text = "FrmCreateJockey";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultJockey)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView dgvResultJockey;
        private System.Windows.Forms.Button BtnEditJockey;
        private System.Windows.Forms.Button BtnDeleteJockey;
        private System.Windows.Forms.Button BtnAddJockey;
    }
}