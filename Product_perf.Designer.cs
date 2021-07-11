namespace project
{
    partial class Product_perf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_perf));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.dayCB = new System.Windows.Forms.ComboBox();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.backButton = new project.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 364);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Location = new System.Drawing.Point(489, 472);
            this.CheckBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(100, 28);
            this.CheckBtn.TabIndex = 2;
            this.CheckBtn.Text = "Check";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // dayCB
            // 
            this.dayCB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dayCB.FormattingEnabled = true;
            this.dayCB.Items.AddRange(new object[] {
            "--Select Day--",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayCB.Location = new System.Drawing.Point(229, 547);
            this.dayCB.Margin = new System.Windows.Forms.Padding(4);
            this.dayCB.Name = "dayCB";
            this.dayCB.Size = new System.Drawing.Size(144, 24);
            this.dayCB.TabIndex = 16;
            this.dayCB.Text = "--Select Day--";
            // 
            // monthCB
            // 
            this.monthCB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Items.AddRange(new object[] {
            "--Select Month--",
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.monthCB.Location = new System.Drawing.Point(470, 547);
            this.monthCB.Margin = new System.Windows.Forms.Padding(4);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(144, 24);
            this.monthCB.TabIndex = 17;
            this.monthCB.Text = "--Select Month--";
            // 
            // yearCB
            // 
            this.yearCB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.yearCB.FormattingEnabled = true;
            this.yearCB.Items.AddRange(new object[] {
            "--Select Year--",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015"});
            this.yearCB.Location = new System.Drawing.Point(677, 547);
            this.yearCB.Margin = new System.Windows.Forms.Padding(4);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(144, 24);
            this.yearCB.TabIndex = 18;
            this.yearCB.Text = "--Select Year--";
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
            this.backButton.Size = new System.Drawing.Size(115, 99);
            this.backButton.TabIndex = 19;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Product_perf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 700);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.yearCB);
            this.Controls.Add(this.monthCB);
            this.Controls.Add(this.dayCB);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product_perf";
            this.Text = "Product Performance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.ComboBox dayCB;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.ComboBox yearCB;
        private RoundButton backButton;
    }
}