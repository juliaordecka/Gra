namespace Gra
{
    partial class Form3
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
            startButton = new Button();
            label1 = new Label();
            game_timer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            timeLabel = new Label();
            gameBoard = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            scoreLabel = new Label();
            dissapearance_timer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            closeButton = new Button();
            lifeLabel = new Label();
            gameBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(39, 36);
            startButton.Name = "startButton";
            startButton.Size = new Size(112, 34);
            startButton.TabIndex = 0;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 40);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "SCORE:";
            // 
            // game_timer
            // 
            game_timer.Tick += Game_timer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 40);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 4;
            label2.Text = "TIME LEFT:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 13F);
            timeLabel.Location = new Point(613, 29);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(0, 36);
            timeLabel.TabIndex = 5;
            // 
            // gameBoard
            // 
            gameBoard.AllowDrop = true;
            gameBoard.BackColor = Color.Ivory;
            gameBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            gameBoard.ColumnCount = 4;
            gameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gameBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            gameBoard.Controls.Add(pictureBox1, 0, 0);
            gameBoard.Controls.Add(pictureBox2, 1, 0);
            gameBoard.Controls.Add(pictureBox3, 2, 0);
            gameBoard.Controls.Add(pictureBox4, 3, 0);
            gameBoard.Controls.Add(pictureBox5, 0, 1);
            gameBoard.Controls.Add(pictureBox6, 1, 1);
            gameBoard.Controls.Add(pictureBox7, 2, 1);
            gameBoard.Controls.Add(pictureBox8, 3, 1);
            gameBoard.Dock = DockStyle.Bottom;
            gameBoard.Location = new Point(0, 114);
            gameBoard.Name = "gameBoard";
            gameBoard.RowCount = 2;
            gameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gameBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gameBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gameBoard.Size = new Size(767, 414);
            gameBoard.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.istockphoto_996288992_612x612;
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.istockphoto_996288992_612x612;
            pictureBox2.Location = new Point(196, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 198);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.istockphoto_996288992_612x612;
            pictureBox3.Location = new Point(387, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(183, 198);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.istockphoto_996288992_612x612;
            pictureBox4.Location = new Point(578, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(184, 198);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources.istockphoto_996288992_612x612;
            pictureBox5.Location = new Point(5, 211);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(183, 198);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Image = Properties.Resources.istockphoto_996288992_612x612;
            pictureBox6.Location = new Point(196, 211);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(183, 198);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Fill;
            pictureBox7.Image = Properties.Resources.istockphoto_996288992_612x612;
            pictureBox7.Location = new Point(387, 211);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(183, 198);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Fill;
            pictureBox8.Enabled = false;
            pictureBox8.Image = Properties.Resources.istockphoto_996288992_612x612;
            pictureBox8.Location = new Point(578, 211);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(184, 198);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            pictureBox8.Visible = false;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 12F);
            scoreLabel.Location = new Point(405, 35);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(27, 32);
            scoreLabel.TabIndex = 7;
            scoreLabel.Text = "0";
            // 
            // dissapearance_timer
            // 
            dissapearance_timer.Interval = 2000;
            dissapearance_timer.Tick += dissapearance_timer_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 78);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 8;
            label3.Text = "LIFE:";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(176, 36);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 34);
            closeButton.TabIndex = 9;
            closeButton.Text = "CLOSE";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // lifeLabel
            // 
            lifeLabel.AutoSize = true;
            lifeLabel.Font = new Font("Segoe UI", 12F);
            lifeLabel.Location = new Point(405, 72);
            lifeLabel.Name = "lifeLabel";
            lifeLabel.Size = new Size(27, 32);
            lifeLabel.TabIndex = 10;
            lifeLabel.Text = "4";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 528);
            Controls.Add(lifeLabel);
            Controls.Add(closeButton);
            Controls.Add(label3);
            Controls.Add(scoreLabel);
            Controls.Add(gameBoard);
            Controls.Add(timeLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startButton);
            Name = "Form3";
            Text = "Walnij dydelfa";
            gameBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private Label label1;
        private System.Windows.Forms.Timer game_timer;
        private Label label2;
        private Label timeLabel;
        private TableLayoutPanel gameBoard;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private Label scoreLabel;
        public PictureBox pictureBox4;
        private System.Windows.Forms.Timer dissapearance_timer;
        private Label label3;
        private Button closeButton;
        private Label lifeLabel;
    }
}