using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void examineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            this.Hide();
            f.ShowDialog(); 
            this.Show();
        }

        private void deliveryNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void receivedNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void returnSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
