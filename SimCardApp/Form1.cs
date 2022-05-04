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
    public partial class Form1 : Form
    {
        public List<Object> SimCards { get; set; }
        public Form1()
        {
            SimCards = addBasicSimCards();
            InitializeComponent();
        }

        private List<Object> addBasicSimCards() {
            var list = new List<Object>();
            list.Add(new UpgradedSim().AddSim("Proba Bela", "proba@bela.com"));
            list.Add(new SimpleSim().AddSim("Proba Janos", "proba@janos.com"));
            list.Add(new SimpleSim().AddSim("Kukor Ica", "kukor@ica.com"));
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var simCards = this.SimCards;
            dataGridView1.DataSource = simCards;
            dataGridView1.Columns["puk"].Visible = false;
        }

        private void simpleSIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void upgradedSIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = new List<Object>();
            list.AddRange(SimCards);

            int index = dataGridView1.CurrentRow.Index;

            if(index != null)
            {
                list.RemoveAt(index);
            }
            SimCards = list;
            dataGridView1.DataSource = SimCards;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void validateSIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.ShowDialog();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.ShowDialog();
        }
    }
}
