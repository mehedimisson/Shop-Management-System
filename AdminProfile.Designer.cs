namespace project
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            this.jobText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.idText = new System.Windows.Forms.TextBox();
            this.genderLb = new System.Windows.Forms.Label();
            this.passLb = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.useridLb = new System.Windows.Forms.Label();
            this.phText = new System.Windows.Forms.TextBox();
            this.phoneLb = new System.Windows.Forms.Label();
            this.salText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.refBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.backButton = new project.RoundButton();
            this.SuspendLayout();
            // 
            // jobText
            // 
            this.jobText.BackColor = System.Drawing.Color.White;
            this.jobText.ForeColor = System.Drawing.Color.Black;
            this.jobText.Location = new System.Drawing.Point(543, 269);
            this.jobText.Margin = new System.Windows.Forms.Padding(4);
            this.jobText.Name = "jobText";
            this.jobText.Size = new System.Drawing.Size(192, 22);
            this.jobText.TabIndex = 22;
            // 
            // passText
            // 
            this.passText.BackColor = System.Drawing.Color.White;
            this.passText.ForeColor = System.Drawing.Color.Black;
            this.passText.Location = new System.Drawing.Point(543, 201);
            this.passText.Margin = new System.Windows.Forms.Padding(4);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(192, 22);
            this.passText.TabIndex = 20;
            this.passText.TextChanged += new System.EventHandler(this.passText_TextChanged);
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.Color.White;
            this.nameText.ForeColor = System.Drawing.Color.Black;
            this.nameText.Location = new System.Drawing.Point(543, 136);
            this.nameText.Margin = new System.Windows.Forms.Padding(4);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(192, 22);
            this.nameText.TabIndex = 19;
            // 
            // idText
            // 
            this.idText.BackColor = System.Drawing.Color.White;
            this.idText.Enabled = false;
            this.idText.ForeColor = System.Drawing.Color.Black;
            this.idText.Location = new System.Drawing.Point(543, 68);
            this.idText.Margin = new System.Windows.Forms.Padding(4);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(192, 22);
            this.idText.TabIndex = 18;
            // 
            // genderLb
            // 
            this.genderLb.AutoSize = true;
            this.genderLb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.genderLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genderLb.Location = new System.Drawing.Point(239, 265);
            this.genderLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLb.Name = "genderLb";
            this.genderLb.Size = new System.Drawing.Size(51, 25);
            this.genderLb.TabIndex = 17;
            this.genderLb.Text = "Job:";
            // 
            // passLb
            // 
            this.passLb.AutoSize = true;
            this.passLb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.passLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passLb.Location = new System.Drawing.Point(239, 194);
            this.passLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passLb.Name = "passLb";
            this.passLb.Size = new System.Drawing.Size(104, 25);
            this.passLb.TabIndex = 15;
            this.passLb.Text = "Password:";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLb.Location = new System.Drawing.Point(239, 136);
            this.nameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(70, 25);
            this.nameLb.TabIndex = 14;
            this.nameLb.Text = "Name:";
            // 
            // useridLb
            // 
            this.useridLb.AutoSize = true;
            this.useridLb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.useridLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.useridLb.Location = new System.Drawing.Point(239, 68);
            this.useridLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.useridLb.Name = "useridLb";
            this.useridLb.Size = new System.Drawing.Size(37, 25);
            this.useridLb.TabIndex = 13;
            this.useridLb.Text = "ID:";
            // 
            // phText
            // 
            this.phText.BackColor = System.Drawing.Color.White;
            this.phText.ForeColor = System.Drawing.Color.Black;
            this.phText.Location = new System.Drawing.Point(543, 420);
            this.phText.Margin = new System.Windows.Forms.Padding(4);
            this.phText.Name = "phText";
            this.phText.Size = new System.Drawing.Size(192, 22);
            this.phText.TabIndex = 24;
            // 
            // phoneLb
            // 
            this.phoneLb.AutoSize = true;
            this.phoneLb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.phoneLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneLb.Location = new System.Drawing.Point(239, 413);
            this.phoneLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLb.Name = "phoneLb";
            this.phoneLb.Size = new System.Drawing.Size(75, 25);
            this.phoneLb.TabIndex = 23;
            this.phoneLb.Text = "Phone:";
            // 
            // salText
            // 
            this.salText.BackColor = System.Drawing.Color.White;
            this.salText.ForeColor = System.Drawing.Color.Black;
            this.salText.Location = new System.Drawing.Point(543, 325);
            this.salText.Margin = new System.Windows.Forms.Padding(4);
            this.salText.Name = "salText";
            this.salText.Size = new System.Drawing.Size(192, 22);
            this.salText.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(239, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Salary:";
            // 
            // addText
            // 
            this.addText.BackColor = System.Drawing.Color.White;
            this.addText.ForeColor = System.Drawing.Color.Black;
            this.addText.Location = new System.Drawing.Point(543, 490);
            this.addText.Margin = new System.Windows.Forms.Padding(4);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(192, 22);
            this.addText.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(239, 483);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Address:";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(835, 288);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 28);
            this.clearBtn.TabIndex = 31;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(835, 191);
            this.refBtn.Margin = new System.Windows.Forms.Padding(4);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(100, 28);
            this.refBtn.TabIndex = 30;
            this.refBtn.Text = "Refresh";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(835, 423);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 28);
            this.UpdateBtn.TabIndex = 29;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click_1);
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
            this.backButton.Size = new System.Drawing.Size(106, 81);
            this.backButton.TabIndex = 32;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.icons8_businessman_480;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1010, 635);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.addText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phText);
            this.Controls.Add(this.phoneLb);
            this.Controls.Add(this.jobText);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.genderLb);
            this.Controls.Add(this.passLb);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.useridLb);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminProfile";
            this.Text = "Admin Profile";
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jobText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label genderLb;
        private System.Windows.Forms.Label passLb;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label useridLb;
        private System.Windows.Forms.TextBox phText;
        private System.Windows.Forms.Label phoneLb;
        private System.Windows.Forms.TextBox salText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button refBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private RoundButton backButton;
    }
}