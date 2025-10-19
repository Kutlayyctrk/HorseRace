namespace HorseRace
{
    partial class FrmCreateRace
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
            this.dgvResultRace = new System.Windows.Forms.DataGridView();
            this.BtnEditRace = new System.Windows.Forms.Button();
            this.BtnDeleteRace = new System.Windows.Forms.Button();
            this.BtnAddRace = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultRace)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultRace
            // 
            this.dgvResultRace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultRace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultRace.Location = new System.Drawing.Point(146, 71);
            this.dgvResultRace.Name = "dgvResultRace";
            this.dgvResultRace.RowHeadersWidth = 51;
            this.dgvResultRace.RowTemplate.Height = 24;
            this.dgvResultRace.Size = new System.Drawing.Size(509, 350);
            this.dgvResultRace.TabIndex = 3;
            this.dgvResultRace.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultRace_CellClick);
            // 
            // BtnEditRace
            // 
            this.BtnEditRace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEditRace.Location = new System.Drawing.Point(485, 30);
            this.BtnEditRace.Name = "BtnEditRace";
            this.BtnEditRace.Size = new System.Drawing.Size(105, 23);
            this.BtnEditRace.TabIndex = 2;
            this.BtnEditRace.Text = "Edit Race";
            this.BtnEditRace.UseVisualStyleBackColor = true;
            this.BtnEditRace.Click += new System.EventHandler(this.BtnEditRace_Click);
            // 
            // BtnDeleteRace
            // 
            this.BtnDeleteRace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDeleteRace.Location = new System.Drawing.Point(344, 30);
            this.BtnDeleteRace.Name = "BtnDeleteRace";
            this.BtnDeleteRace.Size = new System.Drawing.Size(105, 23);
            this.BtnDeleteRace.TabIndex = 1;
            this.BtnDeleteRace.Text = "Delete Race";
            this.BtnDeleteRace.UseVisualStyleBackColor = true;
            this.BtnDeleteRace.Click += new System.EventHandler(this.BtnDeleteRace_Click);
            // 
            // BtnAddRace
            // 
            this.BtnAddRace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddRace.Location = new System.Drawing.Point(206, 30);
            this.BtnAddRace.Name = "BtnAddRace";
            this.BtnAddRace.Size = new System.Drawing.Size(105, 23);
            this.BtnAddRace.TabIndex = 0;
            this.BtnAddRace.Text = "Add Race";
            this.BtnAddRace.UseVisualStyleBackColor = true;
            this.BtnAddRace.Click += new System.EventHandler(this.BtnAddRace_Click);
            // 
            // FrmCreateRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResultRace);
            this.Controls.Add(this.BtnEditRace);
            this.Controls.Add(this.BtnDeleteRace);
            this.Controls.Add(this.BtnAddRace);
            this.Name = "FrmCreateRace";
            this.Text = "FrmCreateRace";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultRace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultRace;
        private System.Windows.Forms.Button BtnEditRace;
        private System.Windows.Forms.Button BtnDeleteRace;
        private System.Windows.Forms.Button BtnAddRace;
    }
}