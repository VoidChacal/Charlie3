using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void aaaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 fu = new Form2();
            fu.ShowDialog();
        }

        private void aaaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            

        }

        private void loading_Click(object sender, EventArgs e)
        {
            progressbar.Value = 50;
            info2.Visible = true;
            info1.Visible = false;
            loading.Visible = false;
            loading2.Visible = true;
            voltar1.Visible = true;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loading2_Click(object sender, EventArgs e)
        {
            progressbar.Value = 100;
            loading2.Visible = false;
            voltar1.Visible = false;
            voltar2.Visible = true;
            info2.Visible = false;
            info3.Visible = true;
        }

        private void voltar1_Click(object sender, EventArgs e)
        {
            progressbar.Value = 0;
            info1.Visible = true;
            loading.Visible = true;
            info2.Visible = false;
            voltar1.Visible = false;
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            progressbar.Value = 50;
            info3.Visible = false;
            info2.Visible = true;
            loading2.Visible = true;
            voltar1.Visible = true;
            voltar2.Visible = false;
        }
    }
}
