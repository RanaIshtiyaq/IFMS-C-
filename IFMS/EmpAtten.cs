using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFMS
{
    public partial class EmpAtten : Form
    {
        public EmpAtten()
        {
            InitializeComponent();
        }
        private DataSet4 GetDataonload()
        {

            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Emp_Attendance ", queryClass.con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet4 ds = new DataSet4();
            da.Fill(ds, "DataTable1");
            return ds;
        }
        private DataSet4 GetData()
        {
            queryClass.con.Close();
            queryClass.con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Emp_Attendance where ID LIKE '%" + tbSearch.Text + "%'", queryClass.con);

            cmd.Parameters.AddWithValue("@i", tbSearch.Text);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet4 ds = new DataSet4();
            da.Fill(ds, "DataTable1");
            return ds;
        }

        private void EmpAtten_Load(object sender, EventArgs e)
        {
            DataSet4 ds = GetDataonload(); queryClass.con.Close();
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);

            this.reportViewer1.RefreshReport();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet4 ds = GetData(); queryClass.con.Close();
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(datasource);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
        }
    }
}
