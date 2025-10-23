namespace HorseRace
{
    partial class FrmInfo
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
            this.DgvRaceDayResult = new System.Windows.Forms.DataGridView();
            this.DgvRaceCardResult = new System.Windows.Forms.DataGridView();
            this.DgvRaceResult = new System.Windows.Forms.DataGridView();
            this.DgvHorseResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRaceDayResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRaceCardResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRaceResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorseResult)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRaceDayResult
            // 
            this.DgvRaceDayResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRaceDayResult.Location = new System.Drawing.Point(12, 12);
            this.DgvRaceDayResult.Name = "DgvRaceDayResult";
            this.DgvRaceDayResult.RowHeadersWidth = 51;
            this.DgvRaceDayResult.RowTemplate.Height = 24;
            this.DgvRaceDayResult.Size = new System.Drawing.Size(420, 945);
            this.DgvRaceDayResult.TabIndex = 0;
            this.DgvRaceDayResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRaceDayResult_CellClick);
            this.DgvRaceDayResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRaceDayResult_CellContentClick);
            // 
            // DgvRaceCardResult
            // 
            this.DgvRaceCardResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRaceCardResult.Location = new System.Drawing.Point(467, 12);
            this.DgvRaceCardResult.Name = "DgvRaceCardResult";
            this.DgvRaceCardResult.RowHeadersWidth = 51;
            this.DgvRaceCardResult.RowTemplate.Height = 24;
            this.DgvRaceCardResult.Size = new System.Drawing.Size(420, 945);
            this.DgvRaceCardResult.TabIndex = 0;
            this.DgvRaceCardResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRaceCardResult_CellClick);
            // 
            // DgvRaceResult
            // 
            this.DgvRaceResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRaceResult.Location = new System.Drawing.Point(925, 12);
            this.DgvRaceResult.Name = "DgvRaceResult";
            this.DgvRaceResult.RowHeadersWidth = 51;
            this.DgvRaceResult.RowTemplate.Height = 24;
            this.DgvRaceResult.Size = new System.Drawing.Size(420, 945);
            this.DgvRaceResult.TabIndex = 0;
            this.DgvRaceResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRaceResult_CellClick);
            // 
            // DgvHorseResult
            // 
            this.DgvHorseResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHorseResult.Location = new System.Drawing.Point(1385, 12);
            this.DgvHorseResult.Name = "DgvHorseResult";
            this.DgvHorseResult.RowHeadersWidth = 51;
            this.DgvHorseResult.RowTemplate.Height = 24;
            this.DgvHorseResult.Size = new System.Drawing.Size(420, 945);
            this.DgvHorseResult.TabIndex = 0;
            
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 969);
            this.Controls.Add(this.DgvHorseResult);
            this.Controls.Add(this.DgvRaceResult);
            this.Controls.Add(this.DgvRaceCardResult);
            this.Controls.Add(this.DgvRaceDayResult);
            this.Name = "FrmInfo";
            this.Text = "FrmInfo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRaceDayResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRaceCardResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRaceResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHorseResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRaceDayResult;
        private System.Windows.Forms.DataGridView DgvRaceCardResult;
        private System.Windows.Forms.DataGridView DgvRaceResult;
        private System.Windows.Forms.DataGridView DgvHorseResult;
    }
}