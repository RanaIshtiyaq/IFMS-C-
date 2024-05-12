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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from Purchase");
                dgvPurchase.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void pbVid_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvvid.Visible == true) dgvvid.Visible = false;
                else
                {
                    dgvvid.Visible = true; tbVehicle_Id.Focus();
                    queryClass.selectds("Select ID,Vihicle_Name from Vehicle");
                    dgvvid.DataSource = queryClass.ds.Tables[0];
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

        private void Purchase_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format("insert into Purchase(Vehicle_Id,Product_Name,Total_Weight,Deduction,Net_Weight,Date_Time,Price) values('"+tbVehicle_Id.Text+"','"+tbProduct_Name.Text+"','"+tbtotalWeight.Text+"','"+tbDeduction.Text+"','"+tbNet_Weight.Text+"','"+dtDate_Time.Value+"','"+tbPrice.Text+"')");
                queryClass.insert(qry);
                show();
                queryClass.clrearC(this);
                MessageBox.Show("One record added", "Record Added", MessageBoxButtons.OK);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dgvvid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbVehicle_Id.Text = dgvvid.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                dgvvid.Visible = false;
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

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvPurchase.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Do not select header");
            }
        }

        private void dgvPurchase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbVehicle_Id.Text = dgvPurchase.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbProduct_Name.Text = dgvPurchase.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbtotalWeight.Text = dgvPurchase.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbDeduction.Text = dgvPurchase.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbNet_Weight.Text = dgvPurchase.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtDate_Time.Text = dgvPurchase.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbPrice.Text = dgvPurchase.Rows[e.RowIndex].Cells[7].Value.ToString();
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
                        string qry = string.Format("update Purchase set Vehicle_Id='" + tbVehicle_Id.Text + "',Product_Name='" + tbProduct_Name.Text + "',Total_Weight='" + tbtotalWeight.Text + "',Deduction='" + tbDeduction.Text + "',Net_Weight='" + tbNet_Weight.Text + "',Date_Time='"+dtDate_Time.Value+"',Price='"+tbPrice.Text+"' where ID=@i  ");
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
                        string qry = string.Format("delete from Purchase where ID=@i");
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

        private void tbVehicle_Id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select ID,Vihicle_Name from Vehicle where Vihicle_Name LIKE '%" + tbVehicle_Id.Text + "%'");
                dgvvid.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void tbDeduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNumDec(e);
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum( e);
        }


        private void tbtotalWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNumDec(e);
        }

        private void tbNet_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNumDec( e);
        }

        private void tbProduct_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr( e);
        }
    }
}
