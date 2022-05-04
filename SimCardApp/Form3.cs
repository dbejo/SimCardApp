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
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var list = new List<Object>();
            list.AddRange(form1.SimCards);
            list.Add(new UpgradedSim().AddSim(textBoxFullName.Text, textBoxEmail.Text));
            form1.SimCards = list;

            form1.dataGridView1.DataSource = form1.SimCards;
            form1.dataGridView1.Update();
            form1.dataGridView1.Refresh();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
