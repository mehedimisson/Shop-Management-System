namespace project
{
    partial class ProductHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIdLb = new System.Windows.Forms.Label();
            this.proNameLb = new System.Windows.Forms.Label();
            this.priceLb = new System.Windows.Forms.Label();
            this.quantityLb = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.quanText = new System.Windows.Forms.TextBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.putCartBtn = new System.Windows.Forms.Button();
            this.orderquanLb = new System.Windows.Forms.Label();
            this.orderquanText = new System.Windows.Forms.TextBox();
            this.goCartBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(604, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // proIdLb
            // 
            this.proIdLb.AutoSize = true;
            this.proIdLb.Location = new System.Drawing.Point(51, 22);
            this.proIdLb.Name = "proIdLb";
            this.proIdLb.Size = new System.Drawing.Size(35, 13);
            this.proIdLb.TabIndex = 1;
            this.proIdLb.Text = "Pro Id";
            // 
            // proNameLb
            // 
            this.proNameLb.AutoSize = true;
            this.proNameLb.Location = new System.Drawing.Point(51, 56);
            this.proNameLb.Name = "proNameLb";
            this.proNameLb.Size = new System.Drawing.Size(54, 13);
            this.proNameLb.TabIndex = 2;
            this.proNameLb.Text = "Pro Name";
            // 
            // priceLb
            // 
            this.priceLb.AutoSize = true;
            this.priceLb.Location = new System.Drawing.Point(51, 93);
            this.priceLb.Name = "priceLb";
            this.priceLb.Size = new System.Drawing.Size(31, 13);
            this.priceLb.TabIndex = 3;
            this.priceLb.Text = "Price";
            // 
            // quantityLb
            // 
            this.quantityLb.AutoSize = true;
            this.quantityLb.Location = new System.Drawing.Point(51, 131);
            this.quantityLb.Name = "quantityLb";
            this.quantityLb.Size = new System.Drawing.Size(46, 13);
            this.quantityLb.TabIndex = 4;
            this.quantityLb.Text = "Quantity";
            // 
            // idText
            // 
            this.idText.Enabled = false;
            this.idText.Location = new System.Drawing.Point(157, 15);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 5;
            // 
            // nameText
            // 
            this.nameText.Enabled = false;
            this.nameText.Location = new System.Drawing.Point(157, 49);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 6;
            // 
            // priceText
            // 
            this.priceText.Enabled = false;
            this.priceText.Location = new System.Drawing.Point(157, 86);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(100, 20);
            this.priceText.TabIndex = 7;
            // 
            // quanText
            // 
            this.quanText.Enabled = false;
            this.quanText.Location = new System.Drawing.Point(157, 124);
            this.quanText.Name = "quanText";
            this.quanText.Size = new System.Drawing.Size(100, 20);
            this.quanText.TabIndex = 8;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(687, 33);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 9;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(782, 33);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(75, 23);
            this.buyBtn.TabIndex = 10;
            this.buyBtn.Text = "Order Now";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // putCartBtn
            // 
            this.putCartBtn.Location = new System.Drawing.Point(881, 33);
            this.putCartBtn.Name = "putCartBtn";
            this.putCartBtn.Size = new System.Drawing.Size(75, 23);
            this.putCartBtn.TabIndex = 11;
            this.putCartBtn.Text = "Put in Cart";
            this.putCartBtn.UseVisualStyleBackColor = true;
            this.putCartBtn.Click += new System.EventHandler(this.putCartBtn_Click);
            // 
            // orderquanLb
            // 
            this.orderquanLb.AutoSize = true;
            this.orderquanLb.Location = new System.Drawing.Point(41, 168);
            this.orderquanLb.Name = "orderquanLb";
            this.orderquanLb.Size = new System.Drawing.Size(77, 26);
            this.orderquanLb.TabIndex = 12;
            this.orderquanLb.Text = "How many you\r\n   want to buy:";
            // 
            // orderquanText
            // 
            this.orderquanText.Location = new System.Drawing.Point(157, 168);
            this.orderquanText.Name = "orderquanText";
            this.orderquanText.Size = new System.Drawing.Size(100, 20);
            this.orderquanText.TabIndex = 13;
            // 
            // goCartBtn
            // 
            this.goCartBtn.Location = new System.Drawing.Point(881, 146);
            this.goCartBtn.Name = "goCartBtn";
            this.goCartBtn.Size = new System.Drawing.Size(75, 23);
            this.goCartBtn.TabIndex = 14;
            this.goCartBtn.Text = "Go To Cart";
            this.goCartBtn.UseVisualStyleBackColor = true;
            this.goCartBtn.Click += new System.EventHandler(this.goCartBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(792, 249);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 15;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(792, 310);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // ProductHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.goCartBtn);
            this.Controls.Add(this.orderquanText);
            this.Controls.Add(this.orderquanLb);
            this.Controls.Add(this.putCartBtn);
            this.Controls.Add(this.buyBtn);
            //this.Controls.Add(this.showBtn);
            this.Controls.Add(this.quanText);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.quantityLb);
            this.Controls.Add(this.priceLb);
            this.Controls.Add(this.proNameLb);
            this.Controls.Add(this.proIdLb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductHome";
            this.Size = new System.Drawing.Size(990, 536);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label proIdLb;
        private System.Windows.Forms.Label proNameLb;
        private System.Windows.Forms.Label priceLb;
        private System.Windows.Forms.Label quantityLb;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.TextBox quanText;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button putCartBtn;
        private System.Windows.Forms.Label orderquanLb;
        private System.Windows.Forms.TextBox orderquanText;
        private System.Windows.Forms.Button goCartBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}
