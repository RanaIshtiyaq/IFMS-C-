namespace IFMS
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pbVid = new System.Windows.Forms.PictureBox();
            this.dtDate_Time = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDeduction = new System.Windows.Forms.TextBox();
            this.tbtotalWeight = new System.Windows.Forms.TextBox();
            this.tbVehicle_Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPurchase = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvvid = new System.Windows.Forms.DataGridView();
            this.dgvProduct_Name = new System.Windows.Forms.DataGridView();
            this.pbProduct_Name = new System.Windows.Forms.PictureBox();
            this.tbProduct_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNet_Weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct_Name)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(612, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase";
            // 
            // pbVid
            // 
            this.pbVid.Image = global::IFMS.Properties.Resources.cmdPic;
            this.pbVid.Location = new System.Drawing.Point(315, 90);
            this.pbVid.Name = "pbVid";
            this.pbVid.Size = new System.Drawing.Size(20, 25);
            this.pbVid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVid.TabIndex = 86;
            this.pbVid.TabStop = false;
            this.pbVid.Click += new System.EventHandler(this.pbVid_Click);
            // 
            // dtDate_Time
            // 
            this.dtDate_Time.Location = new System.Drawing.Point(521, 184);
            this.dtDate_Time.Name = "dtDate_Time";
            this.dtDate_Time.Size = new System.Drawing.Size(195, 27);
            this.dtDate_Time.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Location = new System.Drawing.Point(1221, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Location = new System.Drawing.Point(1221, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 34);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Location = new System.Drawing.Point(1087, 159);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Location = new System.Drawing.Point(1087, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(853, 89);
            this.tbPrice.MaxLength = 20;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(195, 27);
            this.tbPrice.TabIndex = 7;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbDeduction
            // 
            this.tbDeduction.Location = new System.Drawing.Point(521, 89);
            this.tbDeduction.MaxLength = 15;
            this.tbDeduction.Name = "tbDeduction";
            this.tbDeduction.Size = new System.Drawing.Size(195, 27);
            this.tbDeduction.TabIndex = 4;
            this.tbDeduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeduction_KeyPress);
            // 
            // tbtotalWeight
            // 
            this.tbtotalWeight.Location = new System.Drawing.Point(141, 186);
            this.tbtotalWeight.MaxLength = 15;
            this.tbtotalWeight.Name = "tbtotalWeight";
            this.tbtotalWeight.Size = new System.Drawing.Size(195, 27);
            this.tbtotalWeight.TabIndex = 3;
            this.tbtotalWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtotalWeight_KeyPress);
            // 
            // tbVehicle_Id
            // 
            this.tbVehicle_Id.Location = new System.Drawing.Point(141, 89);
            this.tbVehicle_Id.MaxLength = 5;
            this.tbVehicle_Id.Name = "tbVehicle_Id";
            this.tbVehicle_Id.Size = new System.Drawing.Size(195, 27);
            this.tbVehicle_Id.TabIndex = 1;
            this.tbVehicle_Id.TextChanged += new System.EventHandler(this.tbVehicle_Id_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(774, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 75;
            this.label9.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Date/Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Deduction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Total Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Vehicle Id";
            // 
            // dgvPurchase
            // 
            this.dgvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchase.Location = new System.Drawing.Point(30, 246);
            this.dgvPurchase.Name = "dgvPurchase";
            this.dgvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchase.Size = new System.Drawing.Size(1295, 400);
            this.dgvPurchase.TabIndex = 12;
            this.dgvPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellClick);
            this.dgvPurchase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchase_CellDoubleClick);
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
            this.panel1.TabIndex = 68;
            // 
            // dgvvid
            // 
            this.dgvvid.AllowUserToAddRows = false;
            this.dgvvid.AllowUserToDeleteRows = false;
            this.dgvvid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvvid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvvid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvvid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvvid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvvid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvvid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvid.ColumnHeadersVisible = false;
            this.dgvvid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvvid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvvid.GridColor = System.Drawing.Color.White;
            this.dgvvid.Location = new System.Drawing.Point(141, 117);
            this.dgvvid.Margin = new System.Windows.Forms.Padding(4);
            this.dgvvid.Name = "dgvvid";
            this.dgvvid.RowHeadersVisible = false;
            this.dgvvid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvid.ShowCellToolTips = false;
            this.dgvvid.Size = new System.Drawing.Size(195, 214);
            this.dgvvid.TabIndex = 87;
            this.dgvvid.Visible = false;
            this.dgvvid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvid_CellClick);
            // 
            // dgvProduct_Name
            // 
            this.dgvProduct_Name.AllowUserToAddRows = false;
            this.dgvProduct_Name.AllowUserToDeleteRows = false;
            this.dgvProduct_Name.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct_Name.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduct_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct_Name.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct_Name.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct_Name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct_Name.ColumnHeadersVisible = false;
            this.dgvProduct_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct_Name.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct_Name.GridColor = System.Drawing.Color.White;
            this.dgvProduct_Name.Location = new System.Drawing.Point(141, 165);
            this.dgvProduct_Name.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProduct_Name.Name = "dgvProduct_Name";
            this.dgvProduct_Name.RowHeadersVisible = false;
            this.dgvProduct_Name.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct_Name.ShowCellToolTips = false;
            this.dgvProduct_Name.Size = new System.Drawing.Size(195, 214);
            this.dgvProduct_Name.TabIndex = 91;
            this.dgvProduct_Name.Visible = false;
            this.dgvProduct_Name.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_Name_CellClick);
            // 
            // pbProduct_Name
            // 
            this.pbProduct_Name.Image = global::IFMS.Properties.Resources.cmdPic;
            this.pbProduct_Name.Location = new System.Drawing.Point(314, 138);
            this.pbProduct_Name.Name = "pbProduct_Name";
            this.pbProduct_Name.Size = new System.Drawing.Size(20, 25);
            this.pbProduct_Name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduct_Name.TabIndex = 90;
            this.pbProduct_Name.TabStop = false;
            this.pbProduct_Name.Click += new System.EventHandler(this.pbProduct_Name_Click);
            // 
            // tbProduct_Name
            // 
            this.tbProduct_Name.Location = new System.Drawing.Point(140, 137);
            this.tbProduct_Name.MaxLength = 32;
            this.tbProduct_Name.Name = "tbProduct_Name";
            this.tbProduct_Name.Size = new System.Drawing.Size(195, 27);
            this.tbProduct_Name.TabIndex = 2;
            this.tbProduct_Name.TextChanged += new System.EventHandler(this.tbProduct_Name_TextChanged);
            this.tbProduct_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProduct_Name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Product Name";
            // 
            // tbNet_Weight
            // 
            this.tbNet_Weight.Location = new System.Drawing.Point(521, 137);
            this.tbNet_Weight.MaxLength = 12;
            this.tbNet_Weight.Name = "tbNet_Weight";
            this.tbNet_Weight.Size = new System.Drawing.Size(195, 27);
            this.tbNet_Weight.TabIndex = 5;
            this.tbNet_Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNet_Weight_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 92;
            this.label6.Text = "Net Weight";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 657);
            this.Controls.Add(this.dgvvid);
            this.Controls.Add(this.dgvProduct_Name);
            this.Controls.Add(this.tbNet_Weight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbProduct_Name);
            this.Controls.Add(this.tbProduct_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbVid);
            this.Controls.Add(this.dtDate_Time);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbDeduction);
            this.Controls.Add(this.tbtotalWeight);
            this.Controls.Add(this.tbVehicle_Id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPurchase);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchase)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct_Name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbVid;
        private System.Windows.Forms.DateTimePicker dtDate_Time;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbDeduction;
        private System.Windows.Forms.TextBox tbtotalWeight;
        private System.Windows.Forms.TextBox tbVehicle_Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPurchase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvvid;
        private System.Windows.Forms.DataGridView dgvProduct_Name;
        private System.Windows.Forms.PictureBox pbProduct_Name;
        private System.Windows.Forms.TextBox tbProduct_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNet_Weight;
        private System.Windows.Forms.Label label6;

    }
}