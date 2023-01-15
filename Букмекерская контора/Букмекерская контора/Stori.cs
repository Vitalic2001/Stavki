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
    public partial class Stori : Form
    {
        public Stori()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void Stori_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Balans.STR;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
