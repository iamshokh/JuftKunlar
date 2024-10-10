namespace Magazin
{
    partial class Registration
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            RegistrLogin = new TextBox();
            RegistrPassword = new TextBox();
            RegistrNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // RegistrLogin
            // 
            RegistrLogin.Location = new Point(110, 160);
            RegistrLogin.Multiline = true;
            RegistrLogin.Name = "RegistrLogin";
            RegistrLogin.Size = new Size(252, 41);
            RegistrLogin.TabIndex = 0;
            RegistrLogin.TextChanged += textBox1_TextChanged;
            // 
            // RegistrPassword
            // 
            RegistrPassword.Location = new Point(110, 257);
            RegistrPassword.Multiline = true;
            RegistrPassword.Name = "RegistrPassword";
            RegistrPassword.Size = new Size(252, 41);
            RegistrPassword.TabIndex = 1;
            RegistrPassword.TextChanged += RegistrPassword_TextChanged;
            // 
            // RegistrNumber
            // 
            RegistrNumber.Location = new Point(110, 362);
            RegistrNumber.Multiline = true;
            RegistrNumber.Name = "RegistrNumber";
            RegistrNumber.Size = new Size(252, 41);
            RegistrNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(110, 129);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(110, 226);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 4;
            label2.Text = "Parol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(110, 331);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 5;
            label3.Text = "Telefon raqam";
            // 
            // button1
            // 
            button1.Location = new Point(173, 441);
            button1.Name = "button1";
            button1.Size = new Size(115, 39);
            button1.TabIndex = 6;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(140, 57);
            label4.Name = "label4";
            label4.Size = new Size(166, 37);
            label4.TabIndex = 7;
            label4.Text = "Registratsiya";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 575);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegistrNumber);
            Controls.Add(RegistrPassword);
            Controls.Add(RegistrLogin);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox RegistrLogin;
        private TextBox RegistrPassword;
        private TextBox RegistrNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
    }
}