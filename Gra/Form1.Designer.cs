﻿namespace Gra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Wybierz gre";
            // 
            // button1
            // 
            button1.Location = new Point(161, 238);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 1;
            button1.Text = "Pasjans";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(423, 238);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(157, 36);
            button2.TabIndex = 2;
            button2.Text = "Walnij dydelfa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(716, 238);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(118, 36);
            button3.TabIndex = 3;
            button3.Text = "Nyan Cat";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(252, 331);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Zaloguj sie";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(438, 331);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "Ranking";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}