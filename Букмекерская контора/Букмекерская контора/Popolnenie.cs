using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Букмекерская_контора
{
    public partial class Popolnenie : Form
    {
        public Popolnenie()
        {
            InitializeComponent();
        }
        double balans;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 16 && textBox2.Text.Length == 4 &&
                textBox3.Text.Length == 3 )
            {
                if (textBox4.Text != "" && Convert.ToDouble(textBox4.Text) > 0.1)
                {
                    balans = Convert.ToDouble(textBox4.Text);
                    Balans.Sym = Balans.Sym + balans;
                    label3.Text = "Ваш баланс: " + Balans.Sym.ToString();
                    Balans.STR = Balans.STR +"Вы пополнили счет на сумму " + textBox4.Text+"\n";
                }
                else
                {
                    MessageBox.Show(
                    "Укажите корректную сумму",
                    "Сообщение");
                }
            }
            else
            {
                MessageBox.Show(
                "Укажите данные карты",
                "Сообщение");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) |
                e.KeyChar == '\b' | e.KeyChar == '-') return;
            else
                e.Handled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) |
                e.KeyChar == '\b' | e.KeyChar == '-') return;
            else
                e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) |
                e.KeyChar == '\b' | e.KeyChar == '-') return;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) |
                 e.KeyChar == '\b' | e.KeyChar == '-') return;
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 16 && textBox2.Text.Length == 4 &&
                textBox3.Text.Length == 3)
            {
                if (textBox4.Text != "" && Convert.ToDouble(textBox4.Text) > 0.1)
                {
                    balans = Convert.ToDouble(textBox4.Text);
                    Balans.Sym = Balans.Sym - balans;
                    if (Balans.Sym < 0)
                    {
                        MessageBox.Show(
                        "Невозможность снять такую сумму",
                        "Сообщение");
                        Balans.Sym = Balans.Sym + balans;
                    }
                    else
                    {
                        label3.Text = "Ваш баланс: " + Balans.Sym.ToString();
                        Balans.STR = Balans.STR + "Вы сняли сумму " + textBox4.Text + "\n";
                    } 
                }
                else
                {
                    MessageBox.Show(
                    "Укажите корректную сумму",
                    "Сообщение");
                }
            }
            else
            {
                MessageBox.Show(
                "Укажите данные карты",
                "Сообщение");
            }
        }
    }
}
