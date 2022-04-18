using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poklad
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label12.Visible = true;
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
            }
            else if (textBox3.Text == "")
            {
                string a = textBox1.Text; //Назначаем переменную А в textBox1
                string b = textBox2.Text; //Назначаем переменную В в textBox2

                double a_1 = Convert.ToDouble(a); //Преобразовываем переменную A в число
                double b_1 = Convert.ToDouble(b); //Преобразовываем переменную B в число
                double fuel_cons = a_1 / b_1 * 100; //Выполняем вычисления
                double fuel_cost = 0 * a_1; //Выполняем вычисления

                textBox4.Text = fuel_cons.ToString("0.00");
                textBox5.Text = fuel_cost.ToString("0.00");
            }
            else
            {
                string a = textBox1.Text; //Назначаем переменную А в textBox1
                string b = textBox2.Text; //Назначаем переменную В в textBox2
                string c = textBox3.Text; //Назначаем переменную C в textBox3

                double a_1 = Convert.ToDouble(a); //Преобразовываем переменную A в число
                double b_1 = Convert.ToDouble(b); //Преобразовываем переменную B в число
                double c_1 = Convert.ToDouble(c); //Преобразовываем переменную C в число
                double fuel_cons = a_1 / b_1 * 100; //Выполняем вычисления
                double fuel_cost = c_1 * a_1; //Выполняем вычисления


                textBox4.Text = fuel_cons.ToString("0.00");
                textBox5.Text = fuel_cost.ToString("0.00");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            label12.Visible = false;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label12.Visible = false;
            label1.ForeColor = Color.Black;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label12.Visible = false;
            label2.ForeColor = Color.Black;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
