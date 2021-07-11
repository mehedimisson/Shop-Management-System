namespace project
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.logoutButton = new project.RoundButton();
            this.analysisButton = new project.RoundButton();
            this.profileButton = new project.RoundButton();
            this.historyButton = new project.RoundButton();
            this.employeeButton = new project.RoundButton();
            this.databaseButton = new project.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(485, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(123, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(730, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "History";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(816, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "My Profile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Analysis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(946, 693);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "LogOut";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Image = global::project.Properties.Resources.icons8_shutdown_64;
            this.logoutButton.Location = new System.Drawing.Point(909, 598);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(126, 112);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // analysisButton
            // 
            this.analysisButton.BackColor = System.Drawing.Color.Transparent;
            this.analysisButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.analysisButton.FlatAppearance.BorderSize = 0;
            this.analysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analysisButton.Image = global::project.Properties.Resources.icons8_statistics_96;
            this.analysisButton.Location = new System.Drawing.Point(419, 267);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(149, 135);
            this.analysisButton.TabIndex = 8;
            this.analysisButton.UseVisualStyleBackColor = false;
            this.analysisButton.Click += new System.EventHandler(this.analysisButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Image = global::project.Properties.Resources.icons8_businessman_80__2_;
            this.profileButton.Location = new System.Drawing.Point(785, 12);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(126, 112);
            this.profileButton.TabIndex = 6;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Image = global::project.Properties.Resources.icons8_delivery_time_64__1_;
            this.historyButton.Location = new System.Drawing.Point(693, 300);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(126, 112);
            this.historyButton.TabIndex = 4;
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // employeeButton
            // 
            this.employeeButton.BackColor = System.Drawing.Color.Transparent;
            this.employeeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.employeeButton.FlatAppearance.BorderSize = 0;
            this.employeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeButton.Image = global::project.Properties.Resources.icons8_registration_80;
            this.employeeButton.Location = new System.Drawing.Point(116, 290);
            this.employeeButton.Name = "employeeButton";
            this.employeeButton.Size = new System.Drawing.Size(132, 112);
            this.employeeButton.TabIndex = 2;
            this.employeeButton.UseVisualStyleBackColor = false;
            this.employeeButton.Click += new System.EventHandler(this.employeeButton_Click);
            // 
            // databaseButton
            // 
            this.databaseButton.BackColor = System.Drawing.Color.Transparent;
            this.databaseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.databaseButton.FlatAppearance.BorderSize = 0;
            this.databaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databaseButton.Image = global::project.Properties.Resources.icons8_database_administrator_80;
            this.databaseButton.Location = new System.Drawing.Point(448, 493);
            this.databaseButton.Name = "databaseButton";
            this.databaseButton.Size = new System.Drawing.Size(132, 112);
            this.databaseButton.TabIndex = 0;
            this.databaseButton.UseVisualStyleBackColor = false;
            this.databaseButton.Click += new System.EventHandler(this.databaseButton_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1064, 734);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.analysisButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.databaseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Name = "AdminHome";
            this.Text = "Admin Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton databaseButton;
        private System.Windows.Forms.Label label1;
        private RoundButton employeeButton;
        private System.Windows.Forms.Label label2;
        private RoundButton historyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RoundButton profileButton;
        private System.Windows.Forms.Label label5;
        private RoundButton analysisButton;
        private System.Windows.Forms.Label label6;
        private RoundButton logoutButton;
    }
}

