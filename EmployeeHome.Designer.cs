namespace project
{
    partial class EmployeeHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeHome));
            this.addProductButton = new project.RoundButton();
            this.viewProductButton = new project.RoundButton();
            this.bookingListButton = new project.RoundButton();
            this.purchaseHistoryButton = new project.RoundButton();
            this.label6 = new System.Windows.Forms.Label();
            this.logoutButton = new project.RoundButton();
            this.label4 = new System.Windows.Forms.Label();
            this.profileButton = new project.RoundButton();
            this.SuspendLayout();
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.Cyan;
            this.addProductButton.Location = new System.Drawing.Point(254, 220);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(124, 98);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // viewProductButton
            // 
            this.viewProductButton.BackColor = System.Drawing.Color.Cyan;
            this.viewProductButton.Location = new System.Drawing.Point(489, 220);
            this.viewProductButton.Name = "viewProductButton";
            this.viewProductButton.Size = new System.Drawing.Size(124, 98);
            this.viewProductButton.TabIndex = 1;
            this.viewProductButton.Text = "View Product";
            this.viewProductButton.UseVisualStyleBackColor = false;
            this.viewProductButton.Click += new System.EventHandler(this.viewProductButton_Click);
            // 
            // bookingListButton
            // 
            this.bookingListButton.BackColor = System.Drawing.Color.Cyan;
            this.bookingListButton.Location = new System.Drawing.Point(753, 220);
            this.bookingListButton.Name = "bookingListButton";
            this.bookingListButton.Size = new System.Drawing.Size(145, 98);
            this.bookingListButton.TabIndex = 2;
            this.bookingListButton.Text = "Pending Orders";
            this.bookingListButton.UseVisualStyleBackColor = false;
            this.bookingListButton.Click += new System.EventHandler(this.bookingListButton_Click);
            // 
            // purchaseHistoryButton
            // 
            this.purchaseHistoryButton.BackColor = System.Drawing.Color.Cyan;
            this.purchaseHistoryButton.Location = new System.Drawing.Point(518, 396);
            this.purchaseHistoryButton.Name = "purchaseHistoryButton";
            this.purchaseHistoryButton.Size = new System.Drawing.Size(124, 98);
            this.purchaseHistoryButton.TabIndex = 3;
            this.purchaseHistoryButton.Text = "Purchase History";
            this.purchaseHistoryButton.UseVisualStyleBackColor = false;
            this.purchaseHistoryButton.Click += new System.EventHandler(this.purchaseHistoryButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(1081, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "LogOut";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Image = global::project.Properties.Resources.icons8_shutdown_64;
            this.logoutButton.Location = new System.Drawing.Point(1045, 473);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(126, 112);
            this.logoutButton.TabIndex = 13;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1092, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "My Profile";
            // 
            // profileButton
            // 
            this.profileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Image = global::project.Properties.Resources.icons8_businessman_80__2_;
            this.profileButton.Location = new System.Drawing.Point(1061, 38);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(126, 112);
            this.profileButton.TabIndex = 15;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::project.Properties.Resources.Capture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1261, 625);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.purchaseHistoryButton);
            this.Controls.Add(this.bookingListButton);
            this.Controls.Add(this.viewProductButton);
            this.Controls.Add(this.addProductButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeHome";
            this.Text = "Employee Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton addProductButton;
        private RoundButton viewProductButton;
        private RoundButton bookingListButton;
        private RoundButton purchaseHistoryButton;
        private System.Windows.Forms.Label label6;
        private RoundButton logoutButton;
        private System.Windows.Forms.Label label4;
        private RoundButton profileButton;
    }
}