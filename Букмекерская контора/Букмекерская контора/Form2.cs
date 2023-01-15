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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Popolnenie Popolnenie = new Popolnenie();
            Popolnenie.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Ваш баланс: " + Balans.Sym.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stavka Stavka = new Stavka();
            Stavka.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stori Stori = new Stori();
            Stori.Show();
        }
    }
}
