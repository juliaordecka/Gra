namespace Gra
{
    partial class Form4
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
            textBox1 = new TextBox();
            label1 = new Label();
            infoLabel = new Label();
            zapisz = new Button();
            cofnij = new Button();
            zatwierdz = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 73);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 22);
            label1.TabIndex = 1;
            label1.Text = "Podaj nick";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(218, 106);
            infoLabel.Margin = new Padding(2, 0, 2, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(12, 15);
            infoLabel.TabIndex = 2;
            infoLabel.Text = "-";
            // 
            // zapisz
            // 
            zapisz.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            zapisz.Location = new Point(56, 172);
            zapisz.Margin = new Padding(2, 2, 2, 2);
            zapisz.Name = "zapisz";
            zapisz.Size = new Size(112, 33);
            zapisz.TabIndex = 3;
            zapisz.Text = "Zaloguj";
            zapisz.UseVisualStyleBackColor = true;
            zapisz.Click += zapisz_Click;
            // 
            // cofnij
            // 
            cofnij.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic);
            cofnij.Location = new Point(304, 172);
            cofnij.Margin = new Padding(2, 2, 2, 2);
            cofnij.Name = "cofnij";
            cofnij.Size = new Size(112, 33);
            cofnij.TabIndex = 4;
            cofnij.Text = "Cofnij";
            cofnij.UseVisualStyleBackColor = true;
            cofnij.Click += cofnij_Click;
            // 
            // zatwierdz
            // 
            zatwierdz.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic);
            zatwierdz.Location = new Point(177, 172);
            zatwierdz.Margin = new Padding(2, 2, 2, 2);
            zatwierdz.Name = "zatwierdz";
            zatwierdz.Size = new Size(112, 33);
            zatwierdz.TabIndex = 5;
            zatwierdz.Text = "Zatwierdz";
            zatwierdz.UseVisualStyleBackColor = true;
            zatwierdz.Click += zatwierdz_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(459, 259);
            Controls.Add(zatwierdz);
            Controls.Add(cofnij);
            Controls.Add(zapisz);
            Controls.Add(infoLabel);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label infoLabel;
        private Button zapisz;
        private Button cofnij;
        private Button zatwierdz;
    }
}