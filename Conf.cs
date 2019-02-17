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
    public partial class Conf : Form
    {
        public Conf()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario abrir = new Funcionario();
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcao abrir = new Funcao();
            abrir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cidade abrir = new Cidade();
            abrir.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Estado abrir = new Estado();
            abrir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Departamento abrir = new Departamento();
            abrir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sexo abrir = new Sexo();
            abrir.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pais abrir = new Pais();
            abrir.Show();
        }
    }
}
