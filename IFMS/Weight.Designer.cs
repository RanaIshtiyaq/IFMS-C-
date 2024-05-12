namespace IFMS
{
    partial class Weight
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
            this.dtDate_Time = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbNet_Weight = new System.Windows.Forms.TextBox();
            this.tbDeduction = new System.Windows.Forms.TextBox();
            this.tbTare = new System.Windows.Forms.TextBox();
            this.tbVehicle_Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvWeight = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvvid = new System.Windows.Forms.DataGridView();
            this.pbVid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeight)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDate_Time
            // 
            this.dtDate_Time.Location = new System.Drawing.Point(547, 125);
            this.dtDate_Time.Name = "dtDate_Time";
            this.dtDate_Time.Size = new System.Drawing.Size(195, 27);
            this.dtDate_Time.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.Location = new System.Drawing.Point(1221, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 34);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.Location = new System.Drawing.Point(1221, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 34);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Location = new System.Drawing.Point(1087, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Location = new System.Drawing.Point(1087, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(547, 176);
            this.tbPrice.MaxLength = 15;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(195, 27);
            this.tbPrice.TabIndex = 6;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // tbNet_Weight
            // 
            this.tbNet_Weight.Location = new System.Drawing.Point(141, 127);
            this.tbNet_Weight.MaxLength = 15;
            this.tbNet_Weight.Name = "tbNet_Weight";
            this.tbNet_Weight.Size = new System.Drawing.Size(195, 27);
            this.tbNet_Weight.TabIndex = 2;
            this.tbNet_Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNet_Weight_KeyPress);
            // 
            // tbDeduction
            // 
            this.tbDeduction.Location = new System.Drawing.Point(547, 79);
            this.tbDeduction.MaxLength = 9;
            this.tbDeduction.Name = "tbDeduction";
            this.tbDeduction.Size = new System.Drawing.Size(195, 27);
            this.tbDeduction.TabIndex = 4;
            this.tbDeduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeduction_KeyPress);
            // 
            // tbTare
            // 
            this.tbTare.Location = new System.Drawing.Point(141, 176);
            this.tbTare.MaxLength = 9;
            this.tbTare.Name = "tbTare";
            this.tbTare.Size = new System.Drawing.Size(195, 27);
            this.tbTare.TabIndex = 3;
            this.tbTare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTare_KeyPress);
            // 
            // tbVehicle_Id
            // 
            this.tbVehicle_Id.Location = new System.Drawing.Point(141, 79);
            this.tbVehicle_Id.MaxLength = 5;
            this.tbVehicle_Id.Name = "tbVehicle_Id";
            this.tbVehicle_Id.Size = new System.Drawing.Size(195, 27);
            this.tbVehicle_Id.TabIndex = 1;
            this.tbVehicle_Id.TextChanged += new System.EventHandler(this.tbVehicle_Id_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Price/40kg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Date/Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Net Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Deduction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Vehicle Id";
            // 
            // dgvWeight
            // 
            this.dgvWeight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeight.Location = new System.Drawing.Point(30, 236);
            this.dgvWeight.Name = "dgvWeight";
            this.dgvWeight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWeight.Size = new System.Drawing.Size(1295, 400);
            this.dgvWeight.TabIndex = 11;
            this.dgvWeight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWeight_CellClick);
            this.dgvWeight.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWeight_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(612, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
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
            this.panel1.TabIndex = 46;
            // 
            // dgvvid
            // 
            this.dgvvid.AllowUserToAddRows = false;
            this.dgvvid.AllowUserToDeleteRows = false;
            this.dgvvid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dgvvid.Location = new System.Drawing.Point(141, 107);
            this.dgvvid.Margin = new System.Windows.Forms.Padding(4);
            this.dgvvid.Name = "dgvvid";
            this.dgvvid.RowHeadersVisible = false;
            this.dgvvid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvvid.ShowCellToolTips = false;
            this.dgvvid.Size = new System.Drawing.Size(195, 214);
            this.dgvvid.TabIndex = 67;
            this.dgvvid.Visible = false;
            this.dgvvid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvvid_CellClick);
            // 
            // pbVid
            // 
            this.pbVid.Image = global::IFMS.Properties.Resources.cmdPic;
            this.pbVid.Location = new System.Drawing.Point(315, 80);
            this.pbVid.Name = "pbVid";
            this.pbVid.Size = new System.Drawing.Size(20, 25);
            this.pbVid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVid.TabIndex = 66;
            this.pbVid.TabStop = false;
            this.pbVid.Click += new System.EventHandler(this.pbVid_Click);
            // 
            // Weight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 660);
            this.Controls.Add(this.pbVid);
            this.Controls.Add(this.dtDate_Time);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbNet_Weight);
            this.Controls.Add(this.tbDeduction);
            this.Controls.Add(this.tbTare);
            this.Controls.Add(this.tbVehicle_Id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvWeight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvvid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Weight";
            this.Text = "Weight";
            this.Load += new System.EventHandler(this.Weight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDate_Time;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbNet_Weight;
        private System.Windows.Forms.TextBox tbDeduction;
        private System.Windows.Forms.TextBox tbTare;
        private System.Windows.Forms.TextBox tbVehicle_Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvvid;
        private System.Windows.Forms.PictureBox pbVid;
    }
}