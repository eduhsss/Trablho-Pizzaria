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
    public partial class Historia : Form
    {
        public Historia()
        {
            InitializeComponent();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void históriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historia abrir = new Historia();
            abrir.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 abrir = new Form1();
            abrir.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair realmente sair?", "Pizza Italia",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question)
      == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu abrir = new Menu();
            abrir.Show();
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

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conf abrir = new Conf();
            abrir.Show();
        }
    }
    
}
