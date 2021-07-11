namespace project
{
    partial class OrderToSales
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
            this.dvgrid = new System.Windows.Forms.DataGridView();
            this.confBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.backButton = new project.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgrid
            // 
            this.dvgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgrid.Location = new System.Drawing.Point(196, 106);
            this.dvgrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgrid.Name = "dvgrid";
            this.dvgrid.Size = new System.Drawing.Size(719, 337);
            this.dvgrid.TabIndex = 0;
            this.dvgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgrid_CellClick);
            this.dvgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgrid_CellContentClick);
            // 
            // confBtn
            // 
            this.confBtn.Location = new System.Drawing.Point(379, 484);
            this.confBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(100, 28);
            this.confBtn.TabIndex = 1;
            this.confBtn.Text = "Confirm";
            this.confBtn.UseVisualStyleBackColor = true;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(556, 484);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(99, 28);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::project.Properties.Resources.icons8_back_64;
            this.backButton.Location = new System.Drawing.Point(23, 21);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 99);
            this.backButton.TabIndex = 12;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OrderToSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 729);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.dvgrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderToSales";
            this.Text = "OrderToSales";
            ((System.ComponentModel.ISupportInitialize)(this.dvgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgrid;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.Button deleteBtn;
        private RoundButton backButton;
    }
}