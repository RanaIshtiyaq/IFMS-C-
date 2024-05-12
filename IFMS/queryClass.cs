﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFMS
{
    class queryClass
    {
        public static int id = 0;
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\IFMS.accdb");
        
        
        //Validations
        //For Latter
        public static void valLatr( KeyPressEventArgs kp )
        {
            char ch = kp.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch!=Convert.ToChar(" "))
            {
                kp.Handled = true;
            }
        }
        //for Number
        public static void valNum( KeyPressEventArgs kp)
        {
            char ch = kp.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                kp.Handled = true;
            }
        }
        //for Number Decimal
        public static void valNumDec(KeyPressEventArgs kp)
        {
            char ch = kp.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != Convert.ToChar("."))
            {
                kp.Handled = true;
            }
        }
        //For Reg and Vehicle no
        public static void valRegNo( KeyPressEventArgs kp)
        {
            char ch = kp.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != Convert.ToChar("-") && !char.IsLetter(ch))
            {
                kp.Handled = true;
            }
        }
        //For address
        public static void valadr(KeyPressEventArgs kp)
        {
            char ch = kp.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != Convert.ToChar(".") && !char.IsLetter(ch) && ch != Convert.ToChar(" ") && ch != Convert.ToChar(","))
            {
                kp.Handled = true;
            }
        }
        //For CNIC hyphon
        public static void valCNICh(TextBox t)
        {
            if (t.Text.Length == 5 || t.Text.Length == 13)
            {
                t.Text = t.Text + "-";
                t.SelectionStart = t.Text.Length;
            }
        }
        //For Cell no hyphon
        public static void valCellh(TextBox t)
        {
            if (t.Text.Length == 4)
            {
                t.Text = t.Text + "-";
                t.SelectionStart = t.Text.Length;
            }
        }



        //Clear Controls 
        public static void clrearC(Form f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBox) { c.Text = ""; }
            }

        }

        //All Query
        public static void insert(string qry)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(qry, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public static void Delete(string qry)
        {
            try
            {

                OleDbCommand cmd = new OleDbCommand(qry, con);
                cmd.Parameters.AddWithValue("@i", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public static void update(string qry)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(qry, con);
                cmd.Parameters.AddWithValue("@i", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static DataSet ds;
        public static DataSet selectds(string qry)
        {

            try
            {
                DataSet dss = new DataSet();
                con.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(qry, con);
                adp.Fill(dss);
                ds = dss;
                con.Close();
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return ds;
        }
      
    }
}
