namespace HorseRace
{
    partial class FrmCreateRaceDay
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
            this.dgvResultRaceDay = new System.Windows.Forms.DataGridView();
            this.BtnEditRaceDay = new System.Windows.Forms.Button();
            this.BtnDeleteRaceDay = new System.Windows.Forms.Button();
            this.BtnAddRaceDay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultRaceDay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResultRaceDay
            // 
            this.dgvResultRaceDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultRaceDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultRaceDay.Location = new System.Drawing.Point(146, 71);
            this.dgvResultRaceDay.Name = "dgvResultRaceDay";
            this.dgvResultRaceDay.RowHeadersWidth = 51;
            this.dgvResultRaceDay.RowTemplate.Height = 24;
            this.dgvResultRaceDay.Size = new System.Drawing.Size(509, 350);
            this.dgvResultRaceDay.TabIndex = 3;
            this.dgvResultRaceDay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultRaceDay_CellClick);
            // 
            // BtnEditRaceDay
            // 
            this.BtnEditRaceDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEditRaceDay.Location = new System.Drawing.Point(474, 30);
            this.BtnEditRaceDay.Name = "BtnEditRaceDay";
            this.BtnEditRaceDay.Size = new System.Drawing.Size(116, 23);
            this.BtnEditRaceDay.TabIndex = 2;
            this.BtnEditRaceDay.Text = "Edit Race Day";
            this.BtnEditRaceDay.UseVisualStyleBackColor = true;
            this.BtnEditRaceDay.Click += new System.EventHandler(this.BtnEditRaceDay_Click);
            // 
            // BtnDeleteRaceDay
            // 
            this.BtnDeleteRaceDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnDeleteRaceDay.Location = new System.Drawing.Point(331, 30);
            this.BtnDeleteRaceDay.Name = "BtnDeleteRaceDay";
            this.BtnDeleteRaceDay.Size = new System.Drawing.Size(137, 23);
            this.BtnDeleteRaceDay.TabIndex = 1;
            this.BtnDeleteRaceDay.Text = "Delete Race Day";
            this.BtnDeleteRaceDay.UseVisualStyleBackColor = true;
            this.BtnDeleteRaceDay.Click += new System.EventHandler(this.BtnDeleteRaceDay_Click);
            // 
            // BtnAddRaceDay
            // 
            this.BtnAddRaceDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAddRaceDay.Location = new System.Drawing.Point(206, 30);
            this.BtnAddRaceDay.Name = "BtnAddRaceDay";
            this.BtnAddRaceDay.Size = new System.Drawing.Size(119, 23);
            this.BtnAddRaceDay.TabIndex = 0;
            this.BtnAddRaceDay.Text = "Add Race Day";
            this.BtnAddRaceDay.UseVisualStyleBackColor = true;
            this.BtnAddRaceDay.Click += new System.EventHandler(this.BtnAddRaceDay_Click);
            // 
            // FrmCreateRaceDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResultRaceDay);
            this.Controls.Add(this.BtnEditRaceDay);
            this.Controls.Add(this.BtnDeleteRaceDay);
            this.Controls.Add(this.BtnAddRaceDay);
            this.Name = "FrmCreateRaceDay";
            this.Text = "FrmCreateRaceDay";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultRaceDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultRaceDay;
        private System.Windows.Forms.Button BtnEditRaceDay;
        private System.Windows.Forms.Button BtnDeleteRaceDay;
        private System.Windows.Forms.Button BtnAddRaceDay;
    }
}