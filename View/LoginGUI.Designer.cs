using System.Windows.Forms;

namespace SchoolManagementSystem.View
{
    partial class LoginGuı
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
            this.tab_Login = new System.Windows.Forms.TabControl();
            this.tab_teacherLog = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.text_teacherPass = new System.Windows.Forms.TextBox();
            this.text_teacherUsername = new System.Windows.Forms.TextBox();
            this.btn_teacherLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_studentLogin = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_exit2 = new System.Windows.Forms.Button();
            this.text_studentPass = new System.Windows.Forms.TextBox();
            this.text_studentUsername = new System.Windows.Forms.TextBox();
            this.button_studentLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_adminLogin = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_exit3 = new System.Windows.Forms.Button();
            this.text_adminPass = new System.Windows.Forms.TextBox();
            this.text_adminUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tab_Login.SuspendLayout();
            this.tab_teacherLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_studentLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tab_adminLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Login
            // 
            this.tab_Login.Controls.Add(this.tab_teacherLog);
            this.tab_Login.Controls.Add(this.tab_studentLogin);
            this.tab_Login.Controls.Add(this.tab_adminLogin);
            this.tab_Login.Location = new System.Drawing.Point(12, 12);
            this.tab_Login.Name = "tab_Login";
            this.tab_Login.SelectedIndex = 0;
            this.tab_Login.Size = new System.Drawing.Size(269, 330);
            this.tab_Login.TabIndex = 0;
            // 
            // tab_teacherLog
            // 
            this.tab_teacherLog.BackColor = System.Drawing.Color.Snow;
            this.tab_teacherLog.Controls.Add(this.pictureBox1);
            this.tab_teacherLog.Controls.Add(this.btn_exit);
            this.tab_teacherLog.Controls.Add(this.text_teacherPass);
            this.tab_teacherLog.Controls.Add(this.text_teacherUsername);
            this.tab_teacherLog.Controls.Add(this.btn_teacherLogin);
            this.tab_teacherLog.Controls.Add(this.label2);
            this.tab_teacherLog.Controls.Add(this.label1);
            this.tab_teacherLog.Location = new System.Drawing.Point(4, 22);
            this.tab_teacherLog.Name = "tab_teacherLog";
            this.tab_teacherLog.Padding = new System.Windows.Forms.Padding(3);
            this.tab_teacherLog.Size = new System.Drawing.Size(261, 304);
            this.tab_teacherLog.TabIndex = 0;
            this.tab_teacherLog.Text = "Teacher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagementSystem.Properties.Resources.usericon;
            this.pictureBox1.Location = new System.Drawing.Point(90, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.Location = new System.Drawing.Point(136, 272);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(84, 21);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // text_teacherPass
            // 
            this.text_teacherPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_teacherPass.Location = new System.Drawing.Point(39, 186);
            this.text_teacherPass.MaxLength = 30;
            this.text_teacherPass.Name = "text_teacherPass";
            this.text_teacherPass.Size = new System.Drawing.Size(181, 26);
            this.text_teacherPass.TabIndex = 4;
            this.text_teacherPass.UseSystemPasswordChar = true;
            // 
            // text_teacherUsername
            // 
            this.text_teacherUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_teacherUsername.Location = new System.Drawing.Point(39, 130);
            this.text_teacherUsername.MaxLength = 30;
            this.text_teacherUsername.Name = "text_teacherUsername";
            this.text_teacherUsername.Size = new System.Drawing.Size(181, 26);
            this.text_teacherUsername.TabIndex = 3;
            // 
            // btn_teacherLogin
            // 
            this.btn_teacherLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_teacherLogin.Location = new System.Drawing.Point(39, 229);
            this.btn_teacherLogin.Name = "btn_teacherLogin";
            this.btn_teacherLogin.Size = new System.Drawing.Size(181, 33);
            this.btn_teacherLogin.TabIndex = 2;
            this.btn_teacherLogin.Text = "Log In";
            this.btn_teacherLogin.UseVisualStyleBackColor = true;
            this.btn_teacherLogin.Click += new System.EventHandler(this.btn_teacherLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // tab_studentLogin
            // 
            this.tab_studentLogin.BackColor = System.Drawing.Color.Snow;
            this.tab_studentLogin.Controls.Add(this.pictureBox2);
            this.tab_studentLogin.Controls.Add(this.btn_exit2);
            this.tab_studentLogin.Controls.Add(this.text_studentPass);
            this.tab_studentLogin.Controls.Add(this.text_studentUsername);
            this.tab_studentLogin.Controls.Add(this.button_studentLogin);
            this.tab_studentLogin.Controls.Add(this.label3);
            this.tab_studentLogin.Controls.Add(this.label4);
            this.tab_studentLogin.Location = new System.Drawing.Point(4, 22);
            this.tab_studentLogin.Name = "tab_studentLogin";
            this.tab_studentLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tab_studentLogin.Size = new System.Drawing.Size(261, 304);
            this.tab_studentLogin.TabIndex = 1;
            this.tab_studentLogin.Text = "Student";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SchoolManagementSystem.Properties.Resources.usericon;
            this.pictureBox2.Location = new System.Drawing.Point(90, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btn_exit2
            // 
            this.btn_exit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit2.Location = new System.Drawing.Point(136, 272);
            this.btn_exit2.Name = "btn_exit2";
            this.btn_exit2.Size = new System.Drawing.Size(84, 21);
            this.btn_exit2.TabIndex = 10;
            this.btn_exit2.Text = "EXIT";
            this.btn_exit2.UseVisualStyleBackColor = true;
            this.btn_exit2.Click += new System.EventHandler(this.btn_exit2_Click);
            // 
            // text_studentPass
            // 
            this.text_studentPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_studentPass.Location = new System.Drawing.Point(39, 186);
            this.text_studentPass.MaxLength = 30;
            this.text_studentPass.Name = "text_studentPass";
            this.text_studentPass.Size = new System.Drawing.Size(181, 26);
            this.text_studentPass.TabIndex = 9;
            this.text_studentPass.UseSystemPasswordChar = true;
            // 
            // text_studentUsername
            // 
            this.text_studentUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_studentUsername.Location = new System.Drawing.Point(39, 130);
            this.text_studentUsername.MaxLength = 30;
            this.text_studentUsername.Name = "text_studentUsername";
            this.text_studentUsername.Size = new System.Drawing.Size(181, 26);
            this.text_studentUsername.TabIndex = 8;
            // 
            // button_studentLogin
            // 
            this.button_studentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_studentLogin.Location = new System.Drawing.Point(39, 229);
            this.button_studentLogin.Name = "button_studentLogin";
            this.button_studentLogin.Size = new System.Drawing.Size(181, 33);
            this.button_studentLogin.TabIndex = 7;
            this.button_studentLogin.Text = "Log In";
            this.button_studentLogin.UseVisualStyleBackColor = true;
            this.button_studentLogin.Click += new System.EventHandler(this.button_studentLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username:";
            // 
            // tab_adminLogin
            // 
            this.tab_adminLogin.BackColor = System.Drawing.Color.Snow;
            this.tab_adminLogin.Controls.Add(this.pictureBox3);
            this.tab_adminLogin.Controls.Add(this.btn_exit3);
            this.tab_adminLogin.Controls.Add(this.text_adminPass);
            this.tab_adminLogin.Controls.Add(this.text_adminUsername);
            this.tab_adminLogin.Controls.Add(this.button1);
            this.tab_adminLogin.Controls.Add(this.label5);
            this.tab_adminLogin.Controls.Add(this.label6);
            this.tab_adminLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tab_adminLogin.Location = new System.Drawing.Point(4, 22);
            this.tab_adminLogin.Name = "tab_adminLogin";
            this.tab_adminLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tab_adminLogin.Size = new System.Drawing.Size(261, 304);
            this.tab_adminLogin.TabIndex = 2;
            this.tab_adminLogin.Text = "Administrator";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SchoolManagementSystem.Properties.Resources.usericon;
            this.pictureBox3.Location = new System.Drawing.Point(90, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // btn_exit3
            // 
            this.btn_exit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit3.Location = new System.Drawing.Point(136, 272);
            this.btn_exit3.Name = "btn_exit3";
            this.btn_exit3.Size = new System.Drawing.Size(84, 21);
            this.btn_exit3.TabIndex = 10;
            this.btn_exit3.Text = "EXIT";
            this.btn_exit3.UseVisualStyleBackColor = true;
            this.btn_exit3.Click += new System.EventHandler(this.btn_exit3_Click);
            // 
            // text_adminPass
            // 
            this.text_adminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_adminPass.Location = new System.Drawing.Point(39, 186);
            this.text_adminPass.MaxLength = 30;
            this.text_adminPass.Name = "text_adminPass";
            this.text_adminPass.Size = new System.Drawing.Size(181, 26);
            this.text_adminPass.TabIndex = 9;
            this.text_adminPass.UseSystemPasswordChar = true;
            // 
            // text_adminUsername
            // 
            this.text_adminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_adminUsername.Location = new System.Drawing.Point(39, 130);
            this.text_adminUsername.MaxLength = 30;
            this.text_adminUsername.Name = "text_adminUsername";
            this.text_adminUsername.Size = new System.Drawing.Size(181, 26);
            this.text_adminUsername.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(39, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_adminLogin);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username:";
            // 
            // LoginGuı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(290, 351);
            this.Controls.Add(this.tab_Login);
            this.Name = "LoginGuı";
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.LoginGUI_Load);
            this.tab_Login.ResumeLayout(false);
            this.tab_teacherLog.ResumeLayout(false);
            this.tab_teacherLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_studentLogin.ResumeLayout(false);
            this.tab_studentLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tab_adminLogin.ResumeLayout(false);
            this.tab_adminLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button btn_exit2;
        private System.Windows.Forms.Button btn_exit3;

        private System.Windows.Forms.Button btn_exit;

        #endregion

        private System.Windows.Forms.TabControl tab_Login;
        private System.Windows.Forms.TabPage tab_teacherLog;
        private System.Windows.Forms.TabPage tab_studentLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_teacherLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_teacherUsername;
        private System.Windows.Forms.TextBox text_teacherPass;
        private System.Windows.Forms.TextBox text_studentPass;
        private System.Windows.Forms.TextBox text_studentUsername;
        private System.Windows.Forms.Button button_studentLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tab_adminLogin;
        private System.Windows.Forms.TextBox text_adminPass;
        private System.Windows.Forms.TextBox text_adminUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        

    }
}