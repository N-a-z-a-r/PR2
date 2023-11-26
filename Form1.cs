using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void одновимыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
        private void двовимірніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //створення обʼєкту класу табулювання
            Tabul tabul = new Tabul();
            //Оголошення зміних
            double xn, xk, h, a;
            //Зчитування даних з форми
            xn = Convert.ToDouble(this.textBox1.Text);
            xk = Convert.ToDouble(this.textBox2.Text);
            h = Convert.ToDouble(this.textBox3.Text);
            a = Convert.ToDouble(this.textBox4.Text);


            //Очищуємо грід та графік
            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul.tab(xn, xk, h, a);
            //У циклі заносимо дані у грид та на графік
            for (int i = 0; i < tabul.n; i++)
            {//Округлюємо дані до 2-х знаків після коми
                dataGridView1.Rows.Add(Math.Round(tabul.xy[i, 0], 2).ToString(),
                    Math.Round(tabul.xy[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
            }//створення обʼєкту класу табулювання
        }
    }
}
