namespace Gra
{
    partial class NyanCat
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            nyan = new PictureBox();
            pictureBox1 = new PictureBox();
            serce1 = new PictureBox();
            serce2 = new PictureBox();
            serce3 = new PictureBox();
            label1 = new Label();
            scoreLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)nyan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serce1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serce2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serce3).BeginInit();
            SuspendLayout();
            // 
            // nyan
            // 
            nyan.Image = Properties.Resources.nyancat;
            nyan.Location = new Point(425, 475);
            nyan.Name = "nyan";
            nyan.Size = new Size(50, 50);
            nyan.SizeMode = PictureBoxSizeMode.StretchImage;
            nyan.TabIndex = 8;
            nyan.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.donut;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // serce1
            // 
            serce1.Image = Properties.Resources.serce;
            serce1.Location = new Point(740, 12);
            serce1.Name = "serce1";
            serce1.Size = new Size(40, 40);
            serce1.SizeMode = PictureBoxSizeMode.StretchImage;
            serce1.TabIndex = 10;
            serce1.TabStop = false;
            // 
            // serce2
            // 
            serce2.Image = Properties.Resources.serce;
            serce2.Location = new Point(786, 12);
            serce2.Name = "serce2";
            serce2.Size = new Size(40, 40);
            serce2.SizeMode = PictureBoxSizeMode.StretchImage;
            serce2.TabIndex = 11;
            serce2.TabStop = false;
            // 
            // serce3
            // 
            serce3.Image = Properties.Resources.serce;
            serce3.Location = new Point(832, 12);
            serce3.Name = "serce3";
            serce3.Size = new Size(40, 40);
            serce3.SizeMode = PictureBoxSizeMode.StretchImage;
            serce3.TabIndex = 12;
            serce3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(58, 22);
            label1.Name = "label1";
            label1.Size = new Size(19, 30);
            label1.TabIndex = 13;
            label1.Text = ":";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            scoreLabel.Location = new Point(83, 22);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(0, 30);
            scoreLabel.TabIndex = 14;
            // 
            // NyanCat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            Controls.Add(serce3);
            Controls.Add(serce2);
            Controls.Add(serce1);
            Controls.Add(pictureBox1);
            Controls.Add(nyan);
            Name = "NyanCat";
            Text = "NyanCat";
            ((System.ComponentModel.ISupportInitialize)nyan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)serce1).EndInit();
            ((System.ComponentModel.ISupportInitialize)serce2).EndInit();
            ((System.ComponentModel.ISupportInitialize)serce3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox nyan;
        private PictureBox pictureBox1;
        private PictureBox serce1;
        private PictureBox serce2;
        private PictureBox serce3;
        private Label label1;
        private Label scoreLabel;
    }
}