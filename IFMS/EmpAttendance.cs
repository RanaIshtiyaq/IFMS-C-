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
    public partial class EmpAttendance : Form
    {
        public EmpAttendance()
        {
            InitializeComponent();
        }
        public void show()
        {
            try
            {
                queryClass.selectds("Select * from Emp_Attendance");
                dgvEmployeeAtt.DataSource = queryClass.ds.Tables[0];
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
                if (dgvEmp.Visible == true) dgvEmp.Visible = false;
                else
                {
                    dgvEmp.Visible = true; tbEmpName.Focus();
                    queryClass.selectds("Select ID,Employee_Name from Employee");
                    dgvEmp.DataSource = queryClass.ds.Tables[0];
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbEmpId.Text = dgvEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbEmpName.Text = dgvEmp.Rows[e.RowIndex].Cells[1].Value.ToString();
                dgvEmp.Visible = false;
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        
        }

        private void EmpAttendance_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = string.Format("Insert into Emp_Attendance(Employee_Name,Employee_Id,Date_Time,Attendance)values('" + tbEmpName.Text + "','" + tbEmpId.Text + "','" + dtDate_Time.Value + "','" + tbAttendance.Text + "')");
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
                        string qry = string.Format("update Emp_Attendance set Employee_Name='" + tbEmpName.Text + "',Employee_Id='" + tbEmpId.Text + "',Date_Time='" + dtDate_Time.Value + "',Attendance='" + tbAttendance.Text + "' where ID=@i");
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
                        string qry = string.Format("delete from Emp_Attendance where ID=@i");
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
            queryClass.clrearC(this); btnSave.Enabled = true;
        }

        private void dgvEmployeeAtt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                queryClass.id = Convert.ToInt32(dgvEmployeeAtt.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Do not select header");
            }
        }

        private void dgvEmployeeAtt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                tbEmpName.Text = dgvEmployeeAtt.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbEmpId.Text = dgvEmployeeAtt.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtDate_Time.Text = dgvEmployeeAtt.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbAttendance.Text = dgvEmployeeAtt.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbEmpName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                queryClass.selectds("Select DISTINCT Employee_Id, Employee_Name from Emp_Attendance where Employee_Name LIKE '%" + tbEmpName.Text + "%'");
                dgvEmp.DataSource = queryClass.ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbEmpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbAttendance_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valLatr(e);
        }

        private void tbEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            queryClass.valNum(e);
        }
    }
}
