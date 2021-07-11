namespace project
{
    partial class CartWindow
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
            this.backBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgrid
            // 
            this.dvgrid.AllowUserToAddRows = false;
            this.dvgrid.AllowUserToDeleteRows = false;
            this.dvgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgrid.Location = new System.Drawing.Point(69, 63);
            this.dvgrid.Name = "dvgrid";
            this.dvgrid.ReadOnly = true;
            this.dvgrid.Size = new System.Drawing.Size(744, 136);
            this.dvgrid.TabIndex = 1;
            // 
            // confBtn
            // 
            this.confBtn.Location = new System.Drawing.Point(522, 461);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(107, 29);
            this.confBtn.TabIndex = 2;
            this.confBtn.Text = "Confirm All";
            this.confBtn.UseVisualStyleBackColor = true;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            this.dvgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgrid_CellClick);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(702, 461);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(96, 29);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(633, 260);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(96, 29);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // CartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 570);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.confBtn);
            this.Controls.Add(this.dvgrid);
            this.Name = "CartWindow";
            this.Text = "CartWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dvgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgrid;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button delBtn;
    }
}