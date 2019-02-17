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
    public partial class Cidade : Form
    {
        public Cidade()
        {
            InitializeComponent();
        }

        private void Cidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco01DataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.banco01DataSet.cidade);

        }

        private void cidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco01DataSet);

        }
    }
}
