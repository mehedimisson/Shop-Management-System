namespace project
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            this.label2 = new System.Windows.Forms.Label();
            this.addEmployeeButton = new project.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.viewEmployeeButton = new project.RoundButton();
            this.backButton = new project.RoundButton();
            this.label6 = new System.Windows.Forms.Label();
            this.logoutButton = new project.RoundButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(640, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "View Employee";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.addEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addEmployeeButton.FlatAppearance.BorderSize = 0;
            this.addEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeButton.Image = global::project.Properties.Resources.icons8_businessman_65__1_;
            this.addEmployeeButton.Location = new System.Drawing.Point(195, 307);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(132, 112);
            this.addEmployeeButton.TabIndex = 4;
            this.addEmployeeButton.UseVisualStyleBackColor = false;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(319, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Employee";
            // 
            // viewEmployeeButton
            // 
            this.viewEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.viewEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.viewEmployeeButton.FlatAppearance.BorderSize = 0;
            this.viewEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewEmployeeButton.Image = global::project.Properties.Resources.icons8_businessman_65;
            this.viewEmployeeButton.Location = new System.Drawing.Point(502, 307);
            this.viewEmployeeButton.Name = "viewEmployeeButton";
            this.viewEmployeeButton.Size = new System.Drawing.Size(132, 112);
            this.viewEmployeeButton.TabIndex = 6;
            this.viewEmployeeButton.UseVisualStyleBackColor = false;
            this.viewEmployeeButton.Click += new System.EventHandler(this.viewEmployeeButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::project.Properties.Resources.icons8_back_64;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(132, 112);
            this.backButton.TabIndex = 10;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(963, 714);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "LogOut";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Image = global::project.Properties.Resources.icons8_shutdown_64;
            this.logoutButton.Location = new System.Drawing.Point(926, 619);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(126, 112);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.Capture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1064, 734);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewEmployeeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addEmployeeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManagement";
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private RoundButton addEmployeeButton;
        private System.Windows.Forms.Label label1;
        private RoundButton viewEmployeeButton;
        private RoundButton backButton;
        private System.Windows.Forms.Label label6;
        private RoundButton logoutButton;
    }
}