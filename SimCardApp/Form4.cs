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
    public partial class Form4 : Form
    {
        Form1 form1;
        int index;
        string name;
        int missCounter = 0;
        public Form4(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            maskedTextBox2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            index = form1.dataGridView1.CurrentRow.Index;

            name = form1.dataGridView1.Rows[index].Cells[2].Value.ToString();
            string isActivated = " ";
            if(form1.dataGridView1.Rows[index].Cells[4].Value.Equals(true))
            {
                isActivated = "activated.";
            } else if (form1.dataGridView1.Rows[index].Cells[4].Value.Equals(false))
            {
                isActivated = "not activated.";
            }

            label1.Text = name + " SIM card is " + isActivated;
        }

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text != null)
            {
                if(maskedTextBox1.Text == form1.dataGridView1.Rows[index].Cells[5].Value.ToString())
                {
                    label1.Text = name + " SIM card is activated";
                    MessageBox.Show("You entered the correct pin code", "Activated", MessageBoxButtons.OK);
                } else
                {
                    missCounter++;
                }

                if (missCounter == 3)
                {
                    if (form1.dataGridView1.Rows[index].Cells[6].Value.Equals(0))
                    {
                        label1.Text = name + " SIM is deactivated!";
                        form1.dataGridView1.Rows[index].Cells[4].Value = false;

                        form1.dataGridView1.DataSource = form1.SimCards;
                        form1.dataGridView1.Update();
                        form1.dataGridView1.Refresh();
                        MessageBox.Show("You entered the wrong pin code 3 times","Error", MessageBoxButtons.OK);
                        this.Close();
                    } else if (form1.dataGridView1.Rows[index].Cells[6].Value.Equals(1))
                    {
                        label1.Text = name + " SIM is deactivated!";
                        form1.dataGridView1.Rows[index].Cells[4].Value = false;

                        form1.dataGridView1.DataSource = form1.SimCards;
                        form1.dataGridView1.Update();
                        form1.dataGridView1.Refresh();

                        maskedTextBox2.Visible = true;
                        label3.Visible = true;
                        button1.Visible = true;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text == "1234")
            {
                label1.Text = name + " SIM is reactivated!";
                form1.dataGridView1.Rows[index].Cells[4].Value = true;

                form1.dataGridView1.DataSource = form1.SimCards;
                form1.dataGridView1.Update();
                form1.dataGridView1.Refresh();
            } else
            {
                MessageBox.Show("You entered the wrong pin code 3 times", "Error", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}
