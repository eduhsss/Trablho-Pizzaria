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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void históriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historia abrir = new Historia();
            abrir.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu abrir = new Menu();
            abrir.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair realmente sair?", "Pizza Italia",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
  == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conf abrir = new Conf();
            abrir.Show();
        }
    }
    }

