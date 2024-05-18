namespace Gra
{
    partial class ranking
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
            dataGridViewRanking = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRanking).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRanking
            // 
            dataGridViewRanking.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridViewRanking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRanking.GridColor = SystemColors.MenuHighlight;
            dataGridViewRanking.Location = new Point(41, 41);
            dataGridViewRanking.Name = "dataGridViewRanking";
            dataGridViewRanking.Size = new Size(415, 269);
            dataGridViewRanking.TabIndex = 0;
            // 
            // ranking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(505, 348);
            Controls.Add(dataGridViewRanking);
            Name = "ranking";
            Text = "ranking";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRanking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRanking;
    }
}