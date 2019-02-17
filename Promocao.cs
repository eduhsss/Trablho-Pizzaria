using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade04_06
{
    public partial class Promocao : Form
    {
        public Promocao()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 abrir = new Form1();
            abrir.Show();
        }

        private void historiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historia abrir = new Historia();
            abrir.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void promoçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promocao abrir = new Promocao();
            abrir.Show();

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair realmente sair?", "Pizza Italia",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
   == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
