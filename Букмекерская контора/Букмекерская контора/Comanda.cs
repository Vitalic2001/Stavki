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
    public partial class Comanda : Form
    {
        public Comanda()
        {
            InitializeComponent();
        }
        double rands;
        int rands1;
        double kof2;
        double ver;
        double ver2;
        int res;
        int tt1;
        int tt2;
        double mhoj;
        private void Comanda_Load(object sender, EventArgs e)
        {
            label2.Text = "Ваш баланс: " + Balans.Sym.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox1.Text != comboBox2.Text)
            {
                Random rand = new Random();
                rands = rand.NextDouble();
                rands1 = rand.Next(1, 8);
                rands = Math.Round(rands, 3);
                rands = rands + rands1;
                ver= (9 - Math.Round(rands, 2))*10;
                label5.Text = "Коэффициент победы команда А: " + (9 - rands).ToString();
                kof2 = rands;
                label6.Text = "Коэффициент победы команда Б: " + rands.ToString();
                ver2= Math.Round(kof2, 2)*10;
                tt1 = (int) Math.Round(rands, 0)*10;
                tt2 = (int) Math.Round(kof2, 0)*10;
                if (radioButton1.Checked == true)
                {
                    label9.Text = "Вероятность выигрыша " + ver2.ToString() + " %";
                }
                if (radioButton2.Checked == true)
                {
                    label9.Text = "Вероятность выигрыша " + ver.ToString() + " %";
                }
                if (radioButton3.Checked == true)
                {
                    label9.Text = "Вероятность выигрыша 10 %" + tt1.ToString() + tt2.ToString();
                }
            }    
            else
            {
                label5.Text = "Коэффициент победы команда А: ";
                label6.Text = "Коэффициент победы команда Б: ";
                label1.Text = "Коэффициент Ничьи: 9";
                label9.Text = "Вероятность выигрыша ";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label9.Text = "Вероятность выйгрыша " + ver2.ToString() +" %";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label9.Text = "Вероятность выигрыша " + ver.ToString() + " %";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label9.Text = "Вероятность выигрыша 10 %";
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox1.Text != comboBox2.Text)
            {
                Random rand = new Random();
                rands = rand.NextDouble();
                rands1 = rand.Next(1, 8);
                rands = Math.Round(rands, 3);
                rands = rands + rands1;
                ver = (9 - Math.Round(rands, 2)) * 10;
                label5.Text = "Коэффициент победы команда А: " + (9 - rands).ToString();
                kof2 = rands;
                label6.Text = "Коэффициент победы команда Б: " + rands.ToString();
                label1.Text = "Коэффициент Ничьи: 9";
                ver2 =  Math.Round(kof2, 2) * 10;
                tt1 = (int)Math.Round(rands, 0) * 10;
                tt2 = (int)Math.Round(kof2, 0) * 10;
                if (radioButton1.Checked == true)
                {
                    label9.Text = "Вероятность вийгрыша " + ver2.ToString() + " %";
                }
                if (radioButton2.Checked == true)
                {
                    label9.Text = "Вероятность вийгрыша " + ver.ToString() + " %";
                }
                if (radioButton3.Checked == true)
                {
                    label9.Text = "Вероятность выйгрыша 10 %";
                }
            }
            else
            {
                label5.Text = "Коэффициент победы команда А: ";
                label6.Text = "Коэффициент победы команда Б: ";
                label1.Text = "Коэффициент Ничьи: 9";
                label9.Text = "Вероятность выигрыша ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sla=0;
            if (textBox1.Text != "")
            {
                sla = Convert.ToDouble(textBox1.Text);
            }
            if (Balans.Sym >= sla && textBox1.Text != "")
            {
                bool mas = true;
                if (radioButton2.Checked == true)
                {
                    tt1 = 90 - tt2;
                    mhoj = rands;
                }
                if (radioButton3.Checked == true)
                {
                    tt1 = 10;
                    mhoj = 9;
                }
                if (radioButton1.Checked == true)
                {
                    tt1 = tt2;
                    mhoj = 9 - rands;
                }
                Random rand = new Random();
                res = rand.Next(1, 100);
                int[] nums = new int[tt1];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == 0)
                    {
                        nums[i] = rand.Next(1, 100);
                    }
                    else
                    {
                        nums[i] = rand.Next(1, 100);
                        for (int j = 0; j < i; j++)
                        {
                            if (nums[i] == nums[j] || nums[i] == nums[0])
                            {
                                nums[i] = rand.Next(1, 100);
                                j = 0;
                            }
                        }
                    }
                    if (nums[i] == res)
                    {
                        MessageBox.Show(
                        "Поздравляю, ваша ставка зашла",
                        "Сообщение");
                        i = tt1;
                        mas = false;
                        Balans.Sym = Balans.Sym + sla * mhoj*0.97;
                        label2.Text = "Ваш баланс: " + Balans.Sym.ToString();
                        Balans.STR = Balans.STR + "Игрок " + Balans.Name + ". " + "Игра: " + Balans.NamKom +
                            "| Команды: " + comboBox1.Text + " Против" +
                            comboBox2.Text + ". " + "Ставка зашла." + " КОЭФ. " +
                            mhoj + "\n";
                    }
                    if (mas = true && i == tt1 - 1)
                    {
                        MessageBox.Show(
                        "Увы, вы ставка не зашла",
                        "Сообщение");
                        Balans.Sym = Balans.Sym - sla;
                        label2.Text = "Ваш баланс: " + Balans.Sym.ToString();
                        Balans.STR = Balans.STR + "Игрок " + Balans.Name + ". " + "Игра: " + Balans.NamKom +
                            "| Команды: " + comboBox1.Text + " Против " +
                            comboBox2.Text + ". " + "Ставка не зашла." + " КОЭФ. " +
                            mhoj + "\n";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
