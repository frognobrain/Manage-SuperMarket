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

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        string connectstring = "Data Source=LAPTOP-SFRUP6PA\\TIENDUNG;Initial Catalog=KhachHang;Integrated Security=True";
        SqlConnection con;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 R = new Form3();
            this.Hide();
            R.ShowDialog();
            this.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 R = new Form5();
            this.Hide();
            R.ShowDialog();
            this.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            Form4 R = new Form4();
            this.Hide();
            R.ShowDialog();
            this.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnSalereport_Click(object sender, EventArgs e)
        {

        }
    }
}
