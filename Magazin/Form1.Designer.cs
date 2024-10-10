namespace Magazin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LoginButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            Login = new Label();
            passwordbox = new TextBox();
            loginbox = new TextBox();
            Ok = new Button();
            RegistrButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(41, 89);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(117, 41);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(passwordbox);
            panel1.Controls.Add(loginbox);
            panel1.Controls.Add(Ok);
            panel1.Controls.Add(RegistrButton);
            panel1.Controls.Add(LoginButton);
            panel1.Location = new Point(196, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 492);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(110, 235);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 6;
            label1.Text = "Parol*";
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Login.Location = new Point(110, 157);
            Login.Name = "Login";
            Login.Size = new Size(81, 31);
            Login.TabIndex = 5;
            Login.Text = "Login*";
            // 
            // passwordbox
            // 
            passwordbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordbox.Location = new Point(110, 269);
            passwordbox.Multiline = true;
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(216, 44);
            passwordbox.TabIndex = 4;
            // 
            // loginbox
            // 
            loginbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginbox.Location = new Point(110, 191);
            loginbox.Multiline = true;
            loginbox.Name = "loginbox";
            loginbox.Size = new Size(216, 37);
            loginbox.TabIndex = 3;
            // 
            // Ok
            // 
            Ok.Location = new Point(124, 359);
            Ok.Name = "Ok";
            Ok.Size = new Size(117, 41);
            Ok.TabIndex = 2;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // RegistrButton
            // 
            RegistrButton.Location = new Point(209, 89);
            RegistrButton.Name = "RegistrButton";
            RegistrButton.Size = new Size(117, 41);
            RegistrButton.TabIndex = 1;
            RegistrButton.Text = "Registratsiya";
            RegistrButton.UseVisualStyleBackColor = true;
            RegistrButton.Click += RegistrButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 559);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button LoginButton;
        private Panel panel1;
        private Label Login;
        private TextBox passwordbox;
        private TextBox loginbox;
        private Button Ok;
        private Button RegistrButton;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
