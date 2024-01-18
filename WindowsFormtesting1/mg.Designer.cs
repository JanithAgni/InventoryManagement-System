
namespace WindowsFormtesting1
{
    partial class mg
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
            this.txtcusphone = new System.Windows.Forms.TextBox();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.txtcusname = new System.Windows.Forms.TextBox();
            this.gvCustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblexite = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcusphone
            // 
            this.txtcusphone.ForeColor = System.Drawing.Color.Olive;
            this.txtcusphone.Location = new System.Drawing.Point(31, 256);
            this.txtcusphone.Name = "txtcusphone";
            this.txtcusphone.Size = new System.Drawing.Size(100, 20);
            this.txtcusphone.TabIndex = 8;
            this.txtcusphone.Text = "Mobilenumber";
            // 
            // txtcusid
            // 
            this.txtcusid.ForeColor = System.Drawing.Color.Olive;
            this.txtcusid.Location = new System.Drawing.Point(31, 168);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(100, 20);
            this.txtcusid.TabIndex = 7;
            this.txtcusid.Text = "CustomerId";
            this.txtcusid.TextChanged += new System.EventHandler(this.txtfullname_TextChanged);
            // 
            // txtcusname
            // 
            this.txtcusname.ForeColor = System.Drawing.Color.Olive;
            this.txtcusname.Location = new System.Drawing.Point(31, 212);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.Size = new System.Drawing.Size(100, 20);
            this.txtcusname.TabIndex = 5;
            this.txtcusname.Text = "customername";
            this.txtcusname.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // gvCustomer
            // 
            this.gvCustomer.AllowUserToOrderColumns = true;
            this.gvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomer.Location = new System.Drawing.Point(236, 168);
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.Size = new System.Drawing.Size(483, 218);
            this.gvCustomer.TabIndex = 9;
            this.gvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCustomer_CellClick);
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
            this.panel1.TabIndex = 10;
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
            this.label3.Location = new System.Drawing.Point(100, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 62);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage customers ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(371, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer List";
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.GreenYellow;
            this.btnhome.Location = new System.Drawing.Point(334, 405);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 23);
            this.btnhome.TabIndex = 14;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.GreenYellow;
            this.btndelete.Location = new System.Drawing.Point(226, 405);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnedit.Location = new System.Drawing.Point(130, 405);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 12;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.GreenYellow;
            this.btnadd.Location = new System.Drawing.Point(33, 405);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // mg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvCustomer);
            this.Controls.Add(this.txtcusphone);
            this.Controls.Add(this.txtcusid);
            this.Controls.Add(this.txtcusname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mg";
            this.Load += new System.EventHandler(this.mg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcusphone;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.TextBox txtcusname;
        private System.Windows.Forms.DataGridView gvCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblexite;
    }
}