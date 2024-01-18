
namespace WindowsFormtesting1
{
    partial class manageOrders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblexite = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerGv = new System.Windows.Forms.DataGridView();
            this.productgv = new System.Windows.Forms.DataGridView();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.customerId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.qtyTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.orderGv = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.lblexite);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 118);
            this.panel1.TabIndex = 13;
            // 
            // lblexite
            // 
            this.lblexite.AutoSize = true;
            this.lblexite.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexite.ForeColor = System.Drawing.Color.Red;
            this.lblexite.Location = new System.Drawing.Point(748, 2);
            this.lblexite.Name = "lblexite";
            this.lblexite.Size = new System.Drawing.Size(36, 35);
            this.lblexite.TabIndex = 15;
            this.lblexite.Text = "X";
            this.lblexite.Click += new System.EventHandler(this.lblexite_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 62);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Orders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(55, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Customer List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerGv
            // 
            this.customerGv.AllowUserToOrderColumns = true;
            this.customerGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGv.Location = new System.Drawing.Point(12, 164);
            this.customerGv.Name = "customerGv";
            this.customerGv.Size = new System.Drawing.Size(285, 131);
            this.customerGv.TabIndex = 18;
            this.customerGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProduct_CellContentClick);
            // 
            // productgv
            // 
            this.productgv.AllowUserToOrderColumns = true;
            this.productgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productgv.Location = new System.Drawing.Point(487, 164);
            this.productgv.Name = "productgv";
            this.productgv.Size = new System.Drawing.Size(285, 131);
            this.productgv.TabIndex = 20;
            this.productgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productgv_CellClick);
            this.productgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productgv_CellContentClick);
            this.productgv.SelectionChanged += new System.EventHandler(this.productgv_SelectionChanged);
            // 
            // txtusername
            // 
            this.txtusername.ForeColor = System.Drawing.Color.Olive;
            this.txtusername.Location = new System.Drawing.Point(100, 325);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 21;
            this.txtusername.Text = "oderid";
            // 
            // customerId
            // 
            this.customerId.ForeColor = System.Drawing.Color.Olive;
            this.customerId.Location = new System.Drawing.Point(100, 361);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(100, 20);
            this.customerId.TabIndex = 22;
            this.customerId.Text = "customerid";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "OrderDate";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 389);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // searchCombo
            // 
            this.searchCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCombo.ForeColor = System.Drawing.Color.DarkGreen;
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Location = new System.Drawing.Point(487, 142);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(121, 21);
            this.searchCombo.TabIndex = 29;
            this.searchCombo.Text = "select category";
            this.searchCombo.SelectedIndexChanged += new System.EventHandler(this.searchCombo_SelectedIndexChanged);
            this.searchCombo.SelectionChangeCommitted += new System.EventHandler(this.searchCombo_SelectionChangeCommitted);
            // 
            // qtyTb
            // 
            this.qtyTb.ForeColor = System.Drawing.Color.Olive;
            this.qtyTb.Location = new System.Drawing.Point(487, 317);
            this.qtyTb.Name = "qtyTb";
            this.qtyTb.Size = new System.Drawing.Size(100, 20);
            this.qtyTb.TabIndex = 30;
            this.qtyTb.Text = "oderid";
            this.qtyTb.TextChanged += new System.EventHandler(this.qtyTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(582, 315);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add to order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // orderGv
            // 
            this.orderGv.AllowUserToOrderColumns = true;
            this.orderGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.product1,
            this.quantity,
            this.unitprice,
            this.totalprice});
            this.orderGv.Location = new System.Drawing.Point(428, 361);
            this.orderGv.Name = "orderGv";
            this.orderGv.Size = new System.Drawing.Size(344, 131);
            this.orderGv.TabIndex = 33;
            this.orderGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGv_CellContentClick);
            // 
            // number
            // 
            this.number.HeaderText = "number";
            this.number.Name = "number";
            // 
            // product1
            // 
            this.product1.HeaderText = "product";
            this.product1.Name = "product1";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            // 
            // unitprice
            // 
            this.unitprice.HeaderText = "unitprice";
            this.unitprice.Name = "unitprice";
            // 
            // totalprice
            // 
            this.totalprice.HeaderText = "totprice";
            this.totalprice.Name = "totalprice";
            // 
            // manageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 493);
            this.Controls.Add(this.orderGv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qtyTb);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.productgv);
            this.Controls.Add(this.customerGv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manageOrders";
            this.Text = "manageOrders";
            this.Load += new System.EventHandler(this.manageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblexite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView customerGv;
        private System.Windows.Forms.DataGridView productgv;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.TextBox qtyTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView orderGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn product1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalprice;
    }
}