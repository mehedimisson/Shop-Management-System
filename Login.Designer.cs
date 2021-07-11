namespace project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.idtxt = new System.Windows.Forms.TextBox();
            this.pastxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.LogInButton = new System.Windows.Forms.Button();
            this.PassTxt = new System.Windows.Forms.Label();
            this.userIDtxt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(120, 82);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(157, 22);
            this.idtxt.TabIndex = 0;
            // 
            // pastxt
            // 
            this.pastxt.Location = new System.Drawing.Point(120, 179);
            this.pastxt.Name = "pastxt";
            this.pastxt.Size = new System.Drawing.Size(157, 22);
            this.pastxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.SignUpButton);
            this.groupBox1.Controls.Add(this.LogInButton);
            this.groupBox1.Controls.Add(this.PassTxt);
            this.groupBox1.Controls.Add(this.userIDtxt);
            this.groupBox1.Controls.Add(this.idtxt);
            this.groupBox1.Controls.Add(this.pastxt);
            this.groupBox1.Location = new System.Drawing.Point(535, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 375);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LogIn";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(202, 274);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(87, 26);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(71, 274);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(87, 26);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Login";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            this.LogInButton.Enter += new System.EventHandler(this.LogInButton_Enter);
            this.LogInButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LogInButton_KeyPress);
            // 
            // PassTxt
            // 
            this.PassTxt.AutoSize = true;
            this.PassTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PassTxt.Location = new System.Drawing.Point(23, 182);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(69, 17);
            this.PassTxt.TabIndex = 3;
            this.PassTxt.Text = "Password";
            // 
            // userIDtxt
            // 
            this.userIDtxt.AutoSize = true;
            this.userIDtxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userIDtxt.Location = new System.Drawing.Point(23, 86);
            this.userIDtxt.Name = "userIDtxt";
            this.userIDtxt.Size = new System.Drawing.Size(51, 17);
            this.userIDtxt.TabIndex = 2;
            this.userIDtxt.Text = "UserID";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources._9k6ktia6xRBvjuNQq9P3GU;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 517);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox pastxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label PassTxt;
        private System.Windows.Forms.Label userIDtxt;
    }
}