using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pretvarac_jedinica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //cm3 to dm3
            if (checkBox1.Checked)
            {
                float a = Convert.ToSingle(textBox1.Text);
                float b = Convert.ToSingle(textBox1.Text);
                a = a / 1000;
                listBox1.Items.Add(b + " cm3 " + "= " + a + " dm3");
                listBox1.Items.Add(" ");
                checkBox1.Checked = false;
            }

            //cm3 to m3
            if (checkBox2.Checked)
            {
                float a = Convert.ToSingle(textBox1.Text);
                float b = Convert.ToSingle(textBox1.Text);
                a = a / 1000000;
                listBox1.Items.Add(b + " cm3 " + "= " + a + " m3");
                listBox1.Items.Add(" ");
                checkBox2.Checked = false;
            }

            //m3 to cm3
            if (checkBox3.Checked)
            {
                float a = Convert.ToSingle(textBox1.Text);
                float b = Convert.ToSingle(textBox1.Text);
                a = a * 1000000;
                listBox1.Items.Add(b + " m3 " + "= " + a + " cm3");
                listBox1.Items.Add(" ");
                checkBox3.Checked = false;
            }

            //m3 to dm3
            if (checkBox4.Checked)
            {
                float a = Convert.ToSingle(textBox1.Text);
                float b = Convert.ToSingle(textBox1.Text);
                a = a * 1000;
                listBox1.Items.Add(b + " m3 " + "= " + a + " dm3");
                listBox1.Items.Add(" ");
                checkBox4.Checked = false;
            }

            //dm3 to cm3
            if (checkBox5.Checked)
            {
                float a = Convert.ToSingle(textBox1.Text);
                float b = Convert.ToSingle(textBox1.Text);
                a = a * 1000;
                listBox1.Items.Add(b + " dm3 " + "= " + a + " cm3");
                listBox1.Items.Add(" ");
                checkBox5.Checked = false;
            }

            //dm3 to m3
            if (checkBox6.Checked)
            {
                float a = Convert.ToSingle(textBox1.Text);
                float b = Convert.ToSingle(textBox1.Text);
                a = a / 1000;
                listBox1.Items.Add(b + " dm3 " + "= " + a + " m3");
                listBox1.Items.Add(" ");
                checkBox6.Checked = false;
            }

            //brzina vala
            if (checkBox7.Checked)
            {
                float a = Convert.ToSingle(textBox2.Text);
                float b = Convert.ToSingle(textBox3.Text);
                float c;
                c = a * b;
                listBox2.Items.Add(a + " m" + " * " + b + " Hz" + " = " + c + " m/s");
                listBox2.Items.Add(" ");
                checkBox7.Checked = false;
            }

            //gravitacija
            if (checkBox8.Checked)
            {
                label4.Show();
                float a = Convert.ToSingle(textBox2.Text);
                float b = Convert.ToSingle(textBox3.Text);
                float c;
                double d = 6.67428E-11;
                c = (float)(d * (a/(b*b)));
                listBox2.Items.Add(c + " N");
                listBox2.Items.Add(" ");
                checkBox8.Checked = false;
            }

            //akceleracija
            if (checkBox9.Checked)
            {
                float a = Convert.ToSingle(textBox2.Text);
                float b = Convert.ToSingle(textBox3.Text);
                float c;
                c = a / b;
                listBox2.Items.Add(a + " m/s" + " / " + b + " s" + " = " + c + " m/s2");
                listBox2.Items.Add(" ");
                checkBox9.Checked = false;
            }

            //brzina
            if (checkBox10.Checked)
            {
                float a = Convert.ToSingle(textBox2.Text);
                float b = Convert.ToSingle(textBox3.Text);
                float c;
                c = a / b;
                listBox2.Items.Add(a + " m" + " / " + b + " s" + " = " + c + "m/s");
                listBox2.Items.Add(" ");
                checkBox10.Checked = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //clearing listbox of items
            listBox1.Items.Clear();
            textBox1.Text = String.Empty;
            listBox2.Items.Clear();
            textBox1.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cm3 to dm3
            if (checkBox1.Checked)
            {
                Form form = new frmcm3todm3();
                form.Show();
                checkBox1.Checked = false;
            }

            //cm3 to m3
            if (checkBox2.Checked)
            {
                Form form = new frmcm3tom3();
                form.Show();
                checkBox2.Checked = false;
            }

            //m3 to cm3
            if (checkBox3.Checked)
            {
                Form form = new frmm3tocm3();
                form.Show();
                checkBox3.Checked = false;
            }

            //m3 to dm3
            if (checkBox4.Checked)
            {
                Form form = new frmm3todm3();
                form.Show();
                checkBox4.Checked = false;
            }

            //dm3 to cm3
            if (checkBox5.Checked)
            {
                Form form = new frmdm3tocm3();
                form.Show();
                checkBox5.Checked = false;
            }

            //dm3 to m3
            if (checkBox6.Checked)
            {
                Form form = new frmdm3tom3();
                form.Show();
                checkBox6.Checked = false;
            }

            //brzinavala
            if (checkBox7.Checked)
            {
                Form form = new frmbrzinavala();
                form.Show();
                checkBox7.Checked = false;
            }

            //Gravitacija
            if (checkBox8.Checked)
            {
                Form form = new frmgravitacija();
                form.Show();
                checkBox8.Checked = false;
                label4.Hide();
            }

            //akceleracija
            if (checkBox9.Checked)
            {
                Form form = new frmakceleracija();
                form.Show();
                checkBox9.Checked = false;
            }

            //brzina
            if (checkBox10.Checked)
            {
                Form form = new frmbrzina();
                form.Show();
                checkBox10.Checked = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //not needed
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
        }
    }
}
