using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp3
{ 

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close this screen???", "Notifications", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string Username = "";
            SqlConnection sqlCon = new SqlConnection (@"Data Source=LAPTOP-NOGO7HR4;Initial Catalog = Hi; Integrated Security = True");
            string tk = txtTK.Text;
            string mk = txtMK.Text;
            
            try 
            {
                string sql = "Select * from Quyen where Username = '" + tk + "' and password = '" + mk + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, sqlCon);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    tk = txtTK.Text;
                    mk = txtMK.Text;
                    MessageBox.Show("Login successful");
                    if (txtTK.Text == "Manager") 
                    {
                        Form2 form = new Form2();
                        this.Hide();
                        form.ShowDialog();
                        this.Show();

                    }
                    if (txtTK.Text == "Sale")
                    {
                        Form6 form = new Form6();
                        this.Hide();
                        form.ShowDialog();
                        this.Show();

                    }
                    if (txtTK.Text == "Warehouse")
                    {
                        Form7 form = new Form7();
                        this.Hide();
                        form.ShowDialog();
                        this.Show();

                    }
                }    
                else
                {
                    MessageBox.Show("invalid login details", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTK.Clear();
                    txtMK.Clear();

                    txtTK.Focus();
                }
                
            }
            catch 
            {
                MessageBox.Show("eror");
            }
            finally 
            { 
                sqlCon.Close(); 
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
