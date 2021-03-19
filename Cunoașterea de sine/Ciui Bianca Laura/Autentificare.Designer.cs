namespace Ciui_Bianca_Laura
{
    partial class Autentificare
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.ParolaTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreareContButton = new System.Windows.Forms.Button();
            this.iesireButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.emailTextBox.Location = new System.Drawing.Point(204, 77);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(198, 21);
            this.emailTextBox.TabIndex = 0;
            // 
            // ParolaTextBox
            // 
            this.ParolaTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.ParolaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParolaTextBox.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ParolaTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ParolaTextBox.Location = new System.Drawing.Point(204, 106);
            this.ParolaTextBox.Name = "ParolaTextBox";
            this.ParolaTextBox.PasswordChar = '•';
            this.ParolaTextBox.Size = new System.Drawing.Size(198, 22);
            this.ParolaTextBox.TabIndex = 1;
            this.ParolaTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.LightBlue;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LoginButton.Location = new System.Drawing.Point(321, 154);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(81, 41);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.MouseLeave += new System.EventHandler(this.LoginButton_MouseLeave);
            this.LoginButton.MouseHover += new System.EventHandler(this.LoginButton_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "e-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(109, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(483, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nu aveți cont?";
            // 
            // CreareContButton
            // 
            this.CreareContButton.BackColor = System.Drawing.Color.LightBlue;
            this.CreareContButton.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.CreareContButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreareContButton.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreareContButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CreareContButton.Location = new System.Drawing.Point(476, 305);
            this.CreareContButton.Name = "CreareContButton";
            this.CreareContButton.Size = new System.Drawing.Size(150, 32);
            this.CreareContButton.TabIndex = 6;
            this.CreareContButton.Text = "Creare cont nou";
            this.CreareContButton.UseVisualStyleBackColor = false;
            this.CreareContButton.Click += new System.EventHandler(this.CreareContButton_Click);
            this.CreareContButton.MouseLeave += new System.EventHandler(this.CreareContButton_MouseLeave);
            this.CreareContButton.MouseHover += new System.EventHandler(this.CreareContButton_MouseHover);
            // 
            // iesireButton
            // 
            this.iesireButton.BackColor = System.Drawing.Color.LightBlue;
            this.iesireButton.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.iesireButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iesireButton.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iesireButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iesireButton.Location = new System.Drawing.Point(571, 25);
            this.iesireButton.Name = "iesireButton";
            this.iesireButton.Size = new System.Drawing.Size(55, 30);
            this.iesireButton.TabIndex = 7;
            this.iesireButton.Text = "Ieșire";
            this.iesireButton.UseVisualStyleBackColor = false;
            this.iesireButton.Click += new System.EventHandler(this.iesireButton_Click);
            this.iesireButton.MouseLeave += new System.EventHandler(this.iesireButton_MouseLeave);
            this.iesireButton.MouseHover += new System.EventHandler(this.iesireButton_MouseHover);
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ciui_Bianca_Laura.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 359);
            this.Controls.Add(this.iesireButton);
            this.Controls.Add(this.CreareContButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ParolaTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Name = "Autentificare";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare Client";
            this.Load += new System.EventHandler(this.Autentificare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox ParolaTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreareContButton;
        private System.Windows.Forms.Button iesireButton;
    }
}