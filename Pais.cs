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
    public partial class Pais : Form
    {
        public Pais()
        {
            InitializeComponent();
        }

        private void paisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco01DataSet);

        }

        private void Pais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco01DataSet.pais'. Você pode movê-la ou removê-la conforme necessário.
            this.paisTableAdapter.Fill(this.banco01DataSet.pais);

        }
    }
}
