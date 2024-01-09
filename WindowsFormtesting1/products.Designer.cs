
namespace WindowsFormtesting1
{
    partial class products
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
            this.gvProduct = new System.Windows.Forms.DataGridView();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtquentity = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.catcombo = new System.Windows.Forms.ComboBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.searchCombo = new System.Windows.Forms.ComboBox();
            this.prodSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 118);
            this.panel1.TabIndex = 12;
            // 
            // lblexite
            // 
            this.lblexite.AutoSize = true;
            this.lblexite.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexite.ForeColor = System.Drawing.Color.Red;
            this.lblexite.Location = new System.Drawing.Point(764, 0);
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
            this.label2.Size = new System.Drawing.Size(275, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(376, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gvProduct
            // 
            this.gvProduct.AllowUserToOrderColumns = true;
            this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduct.Location = new System.Drawing.Point(217, 191);
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.Size = new System.Drawing.Size(483, 218);
            this.gvProduct.TabIndex = 17;
            this.gvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCategory_CellContentClick);
            // 
            // txtProductId
            // 
            this.txtProductId.ForeColor = System.Drawing.Color.Olive;
            this.txtProductId.Location = new System.Drawing.Point(24, 149);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(100, 20);
            this.txtProductId.TabIndex = 19;
            this.txtProductId.Text = "productId";
            this.txtProductId.TextChanged += new System.EventHandler(this.txtProductId_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.ForeColor = System.Drawing.Color.Olive;
            this.txtProductName.Location = new System.Drawing.Point(24, 193);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 18;
            this.txtProductName.Text = "productName";
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtquentity
            // 
            this.txtquentity.ForeColor = System.Drawing.Color.Olive;
            this.txtquentity.Location = new System.Drawing.Point(24, 236);
            this.txtquentity.Name = "txtquentity";
            this.txtquentity.Size = new System.Drawing.Size(100, 20);
            this.txtquentity.TabIndex = 21;
            this.txtquentity.Text = "Productquntity";
            this.txtquentity.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.ForeColor = System.Drawing.Color.Olive;
            this.txtprice.Location = new System.Drawing.Point(24, 280);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 20;
            this.txtprice.Text = "ProductPrice";
            this.txtprice.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdescription
            // 
            this.txtdescription.ForeColor = System.Drawing.Color.Olive;
            this.txtdescription.Location = new System.Drawing.Point(24, 318);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(100, 20);
            this.txtdescription.TabIndex = 22;
            this.txtdescription.Text = "Description";
            this.txtdescription.TextChanged += new System.EventHandler(this.txtdescription_TextChanged);
            // 
            // catcombo
            // 
            this.catcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catcombo.ForeColor = System.Drawing.Color.DarkGreen;
            this.catcombo.FormattingEnabled = true;
            this.catcombo.Location = new System.Drawing.Point(24, 353);
            this.catcombo.Name = "catcombo";
            this.catcombo.Size = new System.Drawing.Size(121, 21);
            this.catcombo.TabIndex = 23;
            this.catcombo.Text = "Product Category";
            this.catcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.GreenYellow;
            this.btnhome.Location = new System.Drawing.Point(328, 415);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 23);
            this.btnhome.TabIndex = 27;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.GreenYellow;
            this.btndelete.Location = new System.Drawing.Point(220, 415);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnedit.Location = new System.Drawing.Point(124, 415);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 25;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.GreenYellow;
            this.btnadd.Location = new System.Drawing.Point(27, 415);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 24;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // searchCombo
            // 
            this.searchCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCombo.ForeColor = System.Drawing.Color.DarkGreen;
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.Location = new System.Drawing.Point(396, 164);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(121, 21);
            this.searchCombo.TabIndex = 28;
            this.searchCombo.Text = "select category";
            this.searchCombo.SelectedIndexChanged += new System.EventHandler(this.searchCombo_SelectedIndexChanged);
            // 
            // prodSearch
            // 
            this.prodSearch.BackColor = System.Drawing.Color.GreenYellow;
            this.prodSearch.Location = new System.Drawing.Point(517, 163);
            this.prodSearch.Name = "prodSearch";
            this.prodSearch.Size = new System.Drawing.Size(75, 23);
            this.prodSearch.TabIndex = 29;
            this.prodSearch.Text = "search";
            this.prodSearch.UseVisualStyleBackColor = false;
            this.prodSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(587, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prodSearch);
            this.Controls.Add(this.searchCombo);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.catcombo);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtquentity);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.gvProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblexite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvProduct;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtquentity;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.ComboBox catcombo;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox searchCombo;
        private System.Windows.Forms.Button prodSearch;
        private System.Windows.Forms.Button button1;
    }
}