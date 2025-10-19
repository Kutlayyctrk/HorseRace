namespace HorseRace
{
    partial class FrmCreateRaceCard
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
            this.dgvResultRaceCard = new System.Windows.Forms.DataGridView();
            this.BtnEditBulletin = new System.Windows.Forms.Button();
            this.BtnDeleteBulletin = new System.Windows.Forms.Button();
            this.BtnAddRaceCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultRaceCard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultRaceCard
            // 
            this.dgvResultRaceCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultRaceCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultRaceCard.Location = new System.Drawing.Point(146, 71);
            this.dgvResultRaceCard.Name = "dgvResultRaceCard";
            this.dgvResultRaceCard.RowHeadersWidth = 51;
            this.dgvResultRaceCard.RowTemplate.Height = 24;
            this.dgvResultRaceCard.Size = new System.Drawing.Size(509, 350);
            this.dgvResultRaceCard.TabIndex = 3;
            this.dgvResultRaceCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultRaceCard_CellClick);
            // 
            // BtnEditBulletin
            // 
            this.BtnEditBulletin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEditBulletin.Location = new System.Drawing.Point(485, 30);
            this.BtnEditBulletin.Name = "BtnEditBulletin";
            this.BtnEditBulletin.Size = new System.Drawing.Size(105, 23);
            this.BtnEditBulletin.TabIndex = 2;
            this.BtnEditBulletin.Text = "Edit Bulletin";
            this.BtnEditBulletin.UseVisualStyleBackColor = true;
            this.BtnEditBulletin.Click += new System.EventHandler(this.BtnEditBulletin_Click);
            // 
            // BtnDeleteBulletin
            // 
            this.BtnDeleteBulletin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDeleteBulletin.Location = new System.Drawing.Point(337, 30);
            this.BtnDeleteBulletin.Name = "BtnDeleteBulletin";
            this.BtnDeleteBulletin.Size = new System.Drawing.Size(125, 23);
            this.BtnDeleteBulletin.TabIndex = 1;
            this.BtnDeleteBulletin.Text = "Delete Bulletin";
            this.BtnDeleteBulletin.UseVisualStyleBackColor = true;
            this.BtnDeleteBulletin.Click += new System.EventHandler(this.BtnDeleteBulletin_Click);
            // 
            // BtnAddRaceCard
            // 
            this.BtnAddRaceCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddRaceCard.Location = new System.Drawing.Point(206, 30);
            this.BtnAddRaceCard.Name = "BtnAddRaceCard";
            this.BtnAddRaceCard.Size = new System.Drawing.Size(105, 23);
            this.BtnAddRaceCard.TabIndex = 0;
            this.BtnAddRaceCard.Text = "Add Bulletin";
            this.BtnAddRaceCard.UseVisualStyleBackColor = true;
            this.BtnAddRaceCard.Click += new System.EventHandler(this.BtnAddRaceCard_Click);
            // 
            // FrmCreateRaceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResultRaceCard);
            this.Controls.Add(this.BtnEditBulletin);
            this.Controls.Add(this.BtnDeleteBulletin);
            this.Controls.Add(this.BtnAddRaceCard);
            this.Name = "FrmCreateRaceCard";
            this.Text = "FrmCreateRaceCard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultRaceCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultRaceCard;
        private System.Windows.Forms.Button BtnEditBulletin;
        private System.Windows.Forms.Button BtnDeleteBulletin;
        private System.Windows.Forms.Button BtnAddRaceCard;
    }
}