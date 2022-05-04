using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimCardApp
{
    public partial class Form5 : Form
    {
        Form1 form1;
        int index;
        public Form5(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void buttonSetBalance_Click(object sender, EventArgs e)
        {
            form1.dataGridView1.Rows[index].Cells[7].Value = maskedTextBox1.Text;

            form1.dataGridView1.DataSource = form1.SimCards;
            form1.dataGridView1.Update();
            form1.dataGridView1.Refresh();

            label1.Text = "Balance: " + form1.dataGridView1.Rows[index].Cells[7].Value;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "Balance: " + form1.dataGridView1.Rows[index].Cells[7].Value;
            index = form1.dataGridView1.CurrentRow.Index;
        }
    }
}
