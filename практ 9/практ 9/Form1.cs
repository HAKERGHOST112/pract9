using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практ_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string FIO = f.textBox1.Text;
                int Age = Convert.ToInt32(f.textBox2.Text);
                int Probeg = Convert.ToInt32(f.textBox3.Text);
                people p = new people(FIO, Age, Probeg);
                listBox1.Items.Add(p);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите объект для редактирования");
            }
            else
            {
                Form2 f = new Form2();
                people p = listBox1.Items[listBox1.SelectedIndex] as people;
                f.textBox1.Text = p.FIO;
                f.textBox2.Text = p.Age.ToString();
                f.textBox3.Text = p.Probeg.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string myFio = f.textBox1.Text;
                    int myAge = Convert.ToInt32(f.textBox2.Text);
                    int myProbeg = Convert.ToInt32(f.textBox3.Text);
                    p.FIO = myFio;
                    p.Age = myAge;
                    p.Probeg = myProbeg;
                    listBox1.Items[listBox1.SelectedIndex] = p;
                }
            }

        }
    

        

        private void button4_Click(object sender, EventArgs e)
        {
            double c = 0;
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                people p = listBox1.Items[i] as people;
                double a = p.Age;
                c = c + a;
            }
            c=c/listBox1.Items.Count;
            label2.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("ОБЬЕКТ НЕ ВЫБРАН");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
