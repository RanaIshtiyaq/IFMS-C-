namespace IFMS
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbProduct_Type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvProdct = new System.Windows.Forms.DataGridView();
            this.tbDesicription = new System.Windows.Forms.TextBox();
            this.tbProduct_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPrname = new System.Windows.Forms.DataGridView();
            this.pbPrNam = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrNam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 56);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(612, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Location = new System.Drawing.Point(329, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Location = new System.Drawing.Point(329, 385);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 34);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Location = new System.Drawing.Point(195, 441);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Location = new System.Drawing.Point(195, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbProduct_Type
            // 
            this.tbProduct_Type.Location = new System.Drawing.Point(277, 113);
            this.tbProduct_Type.MaxLength = 32;
            this.tbProduct_Type.Name = "tbProduct_Type";
            this.tbProduct_Type.Size = new System.Drawing.Size(195, 27);
            this.tbProduct_Type.TabIndex = 1;
            this.tbProduct_Type.TextChanged += new System.EventHandler(this.tbProduct_Type_TextChanged);
            this.tbProduct_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProduct_Type_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Product Type";
            // 
            // dgvProdct
            // 
            this.dgvProdct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdct.Location = new System.Drawing.Point(569, 93);
            this.dgvProdct.Name = "dgvProdct";
            this.dgvProdct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdct.Size = new System.Drawing.Size(618, 556);
            this.dgvProdct.TabIndex = 8;
            this.dgvProdct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdct_CellClick);
            this.dgvProdct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdct_CellDoubleClick);
            // 
            // tbDesicription
            // 
            this.tbDesicription.Location = new System.Drawing.Point(277, 223);
            this.tbDesicription.MaxLength = 327;
            this.tbDesicription.Multiline = true;
            this.tbDesicription.Name = "tbDesicription";
            this.tbDesicription.Size = new System.Drawing.Size(195, 79);
            this.tbDesicription.TabIndex = 3;
            this.tbDesicription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDesicription_KeyPress);
            // 
            // tbProduct_Name
            // 
            this.tbProduct_Name.Location = new System.Drawing.Point(277, 165);
            this.tbProduct_Name.MaxLength = 32;
            this.tbProduct_Name.Name = "tbProduct_Name";
            this.tbProduct_Name.Size = new System.Drawing.Size(195, 27);
            this.tbProduct_Name.TabIndex = 2;
            this.tbProduct_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProduct_Name_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Product Name";
            // 
            // dgvPrname
            // 
            this.dgvPrname.AllowUserToAddRows = false;
            this.dgvPrname.AllowUserToDeleteRows = false;
            this.dgvPrname.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrname.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPrname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrname.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrname.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPrname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrname.ColumnHeadersVisible = false;
            this.dgvPrname.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrname.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPrname.GridColor = System.Drawing.Color.White;
            this.dgvPrname.Location = new System.Drawing.Point(277, 139);
            this.dgvPrname.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrname.Name = "dgvPrname";
            this.dgvPrname.RowHeadersVisible = false;
            this.dgvPrname.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrname.ShowCellToolTips = false;
            this.dgvPrname.Size = new System.Drawing.Size(195, 239);
            this.dgvPrname.TabIndex = 47;
            this.dgvPrname.Visible = false;
            this.dgvPrname.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrname_CellClick);
            // 
            // pbPrNam
            // 
            this.pbPrNam.Image = global::IFMS.Properties.Resources.cmdPic;
            this.pbPrNam.Location = new System.Drawing.Point(451, 114);
            this.pbPrNam.Name = "pbPrNam";
            this.pbPrNam.Size = new System.Drawing.Size(20, 25);
            this.pbPrNam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrNam.TabIndex = 46;
            this.pbPrNam.TabStop = false;
            this.pbPrNam.Click += new System.EventHandler(this.pbPrNam_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 660);
            this.Controls.Add(this.dgvPrname);
            this.Controls.Add(this.pbPrNam);
            this.Controls.Add(this.tbDesicription);
            this.Controls.Add(this.tbProduct_Name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbProduct_Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvProdct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbProduct_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvProdct;
        private System.Windows.Forms.TextBox tbDesicription;
        private System.Windows.Forms.TextBox tbProduct_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPrname;
        private System.Windows.Forms.PictureBox pbPrNam;

    }
}