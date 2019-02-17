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
    public partial class Sexo : Form
    {
        public Sexo()
        {
            InitializeComponent();
        }

        private void sexoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sexoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco01DataSet);

        }

        private void Sexo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco01DataSet.sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.banco01DataSet.sexo);

        }
    }
}
