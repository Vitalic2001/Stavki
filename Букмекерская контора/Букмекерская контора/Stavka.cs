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
    public partial class Stavka : Form
    {
        public Stavka()
        {
            InitializeComponent();
        }

        private void Stavka_Load(object sender, EventArgs e)
        {
            label2.Text = "Ваш баланс: " + Balans.Sym.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comanda Comanda = new Comanda();
            Comanda.Show();
            Balans.NamKom = button1.Text;
    }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comanda Comanda = new Comanda();
            Comanda.Show();
            Balans.NamKom = button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comanda Comanda = new Comanda();
            Comanda.Show();
            Balans.NamKom = button1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comanda Comanda = new Comanda();
            Comanda.Show();
            Balans.NamKom = button1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.Show();
        }
    }
}
