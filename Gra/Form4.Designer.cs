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
            textBox1.Location = new Point(213, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 84);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "Podaj nick";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(312, 177);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(19, 25);
            infoLabel.TabIndex = 2;
            infoLabel.Text = "-";
            // 
            // zapisz
            // 
            zapisz.Location = new Point(90, 289);
            zapisz.Name = "zapisz";
            zapisz.Size = new Size(112, 34);
            zapisz.TabIndex = 3;
            zapisz.Text = "Zaloguj";
            zapisz.UseVisualStyleBackColor = true;
            zapisz.Click += zapisz_Click;
            // 
            // cofnij
            // 
            cofnij.Location = new Point(444, 289);
            cofnij.Name = "cofnij";
            cofnij.Size = new Size(112, 34);
            cofnij.TabIndex = 4;
            cofnij.Text = "Cofnij";
            cofnij.UseVisualStyleBackColor = true;
            cofnij.Click += cofnij_Click;
            // 
            // zatwierdz
            // 
            zatwierdz.Location = new Point(263, 289);
            zatwierdz.Name = "zatwierdz";
            zatwierdz.Size = new Size(112, 34);
            zatwierdz.TabIndex = 5;
            zatwierdz.Text = "Zatwierdz";
            zatwierdz.UseVisualStyleBackColor = true;
            zatwierdz.Click += zatwierdz_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 431);
            Controls.Add(zatwierdz);
            Controls.Add(cofnij);
            Controls.Add(zapisz);
            Controls.Add(infoLabel);
            Controls.Add(label1);
            Controls.Add(textBox1);
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