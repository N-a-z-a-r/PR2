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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0, m = 0;
                n = Convert.ToInt32(textBox1.Text);
                m = Convert.ToInt32(textBox2.Text);
                Array2D twoDimArray = new Array2D(n, m);
                DataGridViewTextBoxColumn dvage;
                //Створюємо необхідну кількість колонок заданої ширини
                for (int i = 0; i < m; i++)
                {
                    dvage = new DataGridViewTextBoxColumn();
                    dvage.Width = 40;
                    dataGridView1.Columns.Add(dvage);
                }
                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = twoDimArray.X_length;
                dataGridView1.ColumnCount = twoDimArray.Y_length;


                for (int i = 0; i < twoDimArray.X_length; i++)
                    for (int j = 0; j < twoDimArray.Y_length; j++)
                        dataGridView1.Rows[i].Cells[j].Value = twoDimArray[i, j].ToString();

                var rezult = twoDimArray.DobutokElementiv;
                label4.Text = rezult.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
