namespace JustRIpeFarm
{
    partial class LoginScreen
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
            this.pageDesc = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pageDesc
            // 
            this.pageDesc.AutoSize = true;
            this.pageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pageDesc.Location = new System.Drawing.Point(13, 188);
            this.pageDesc.Name = "pageDesc";
            this.pageDesc.Size = new System.Drawing.Size(195, 20);
            this.pageDesc.TabIndex = 0;
            this.pageDesc.Text = "Enter the following to login";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(12, 140);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(278, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Welcome to JustRipe Farm!";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.username_label.Location = new System.Drawing.Point(14, 224);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(98, 17);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username/ID :";
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(17, 247);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(273, 20);
            this.username_textBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::JustRIpeFarm.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(91, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 105);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.password_label.Location = new System.Drawing.Point(17, 289);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(77, 17);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Password :";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(17, 311);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(273, 20);
            this.password_textBox.TabIndex = 6;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(55, 357);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(177, 357);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 416);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pageDesc);
            this.Name = "LoginScreen";
            this.Text = "Login - JustRipe Farm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pageDesc;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
    }
}

