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
    
    public partial class Form3 : Form
    {
        
        
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-NOGO7HR4;Initial Catalog = Hi; Integrated Security = True");
        private void ketnoicsdl()
        {
            sqlCon.Open();
            string sql = "select * from NV";  
            SqlCommand cmd = new SqlCommand(sql, sqlCon); 
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd); 
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlCon.Close();
            dataGridView2.DataSource = dt;
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            
        }
    }
}
