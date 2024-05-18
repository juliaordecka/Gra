namespace Gra
{
    partial class Logowanie
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
            cofnij = new Button();
            this.zapisz = new Button();
            infoLabel = new Label();
            label1 = new Label();
            nickname = new TextBox();
            SuspendLayout();
            // 
            // cofnij
            // 
            cofnij.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic);
            cofnij.Location = new Point(320, 191);
            cofnij.Margin = new Padding(2);
            cofnij.Name = "cofnij";
            cofnij.Size = new Size(112, 33);
            cofnij.TabIndex = 10;
            cofnij.Text = "Cofnij";
            cofnij.UseVisualStyleBackColor = true;
            cofnij.Click += cofnij_Click;
            // 
            // zaloguj
            // 
            this.zapisz.Font = new Font("Rockwell", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            this.zapisz.Location = new Point(181, 191);
            this.zapisz.Margin = new Padding(2);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new Size(112, 33);
            this.zapisz.TabIndex = 9;
            this.zapisz.Text = "Zaloguj";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += this.zapisz_Click;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(293, 128);
            infoLabel.Margin = new Padding(2, 0, 2, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(12, 15);
            infoLabel.TabIndex = 8;
            infoLabel.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 22);
            label1.TabIndex = 7;
            label1.Text = "Podaj nick";
            // 
            // nickname
            // 
            nickname.Location = new Point(224, 95);
            nickname.Margin = new Padding(2);
            nickname.Name = "nickname";
            nickname.Size = new Size(160, 23);
            nickname.TabIndex = 6;
            // 
            // Logowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 318);
            Controls.Add(cofnij);
            Controls.Add(this.zapisz);
            Controls.Add(infoLabel);
            Controls.Add(label1);
            Controls.Add(nickname);
            Name = "Logowanie";
            Text = "Logowanie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button zatwierdz;
        private Button cofnij;
        private Button zapisz;
        private Label infoLabel;
        private Label label1;
        private TextBox nickname;
    }
}