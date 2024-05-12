using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFMS
{
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from Vehicle");
                dgvVehicle.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void pbCname_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvcName.Visible == true) dgvcName.Visible = false;
                else
                {
                    dgvcName.Visible = true; tbCompany_Name.Focus();
                    queryClass.selectds("Select Company_Name from CompanyPurchase");
                    dgvcName.DataSource = queryClass.ds.Tables[0];
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void pbProduct_Name_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduct_Name.Visible == true) dgvProduct_Name.Visible = false;
                else
                {
                    dgvProduct_Name.Visible = true; tbProduct_Name.Focus();
                    queryClass.selectds("Select Product_Name from Product");
                    dgvProduct_Name.DataSource = queryClass.ds.Tables[0];
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format("Insert into Vehicle(Vihicle_Name,Registration_No,Date_Time,Vehicle_Status,Company_Name,Product_Name)values('" + tbVihicle_Name.Text + "','" + tbRegistrationNo.Text + "','" + dtDate_Time.Value + "','" + tbVehicleStatus.Text + "','" + tbCompany_Name.Text + "','" + tbProduct_Name.Text + "')");
                queryClass.insert(qry);
                show();
                queryClass.clrearC(this);
                MessageBox.Show("One record added", "Record Added", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Inser Query Problem or May Empty Field", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvcName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbCompany_Name.Text = dgvcName.Rows[e.RowIndex].Cells[0].Value.ToString();
                dgvcName.Visible = false;
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        
        }

        private void dgvProduct_Name_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbProduct_Name.Text = dgvProduct_Name.Rows[e.RowIndex].Cells[0].Value.ToString();
                dgvProduct_Name.Visible = false;
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        
        }

        private void dgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvVehicle.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Do not select header");
            }
        }

        private void dgvVehicle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                tbVihicle_Name.Text = dgvVehicle.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbRegistrationNo.Text = dgvVehicle.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtDate_Time.Text = dgvVehicle.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbVehicleStatus.Text = dgvVehicle.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbCompany_Name.Text = dgvVehicle.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbProduct_Name.Text = dgvVehicle.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (queryClass.id == 0) { MessageBox.Show("Double click on record for update"); }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to UPDATE record", "Want Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        btnSave.Enabled = true;
                        string qry = string.Format("update Vehicle set Vihicle_Name='" + tbVihicle_Name.Text + "',Registration_No='" + tbRegistrationNo.Text + "',Date_Time='" + dtDate_Time.Value + "',Vehicle_Status='" + tbVehicleStatus.Text + "',Company_Name='" + tbCompany_Name.Text + "',Product_Name='" + tbProduct_Name.Text + "' where ID=@i");
                        queryClass.update(qry);
                        show();
                        queryClass.clrearC(this);
                    }
                }
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (queryClass.id == 0) { MessageBox.Show("Click on record for delete"); }
                else
                {
                    DialogResult iExit = MessageBox.Show("Are you sure, You want to DELETE record", "Want Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (iExit == DialogResult.Yes)
                    {
                        string qry = string.Format("delete from Vehicle where ID=@i");
                        queryClass.Delete(qry);
                        show();
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            queryClass.clrearC(this);
            btnSave.Enabled = true;
        }

        private void tbProduct_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select Product_Name from Product where Product_Name LIKE '%" + tbProduct_Name.Text + "%'");
                dgvProduct_Name.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbCompany_Name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select Company_Name from CompanyPurchase where Company_Name LIKE '%" + tbCompany_Name.Text + "%'");
                dgvcName.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbVihicle_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbCompany_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr( e);
        }

        private void tbRegistrationNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valRegNo(e);
        }

        private void tbVehicleStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbProduct_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

    }
}
