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
    public partial class Estado : Form
    {
        public Estado()
        {
            InitializeComponent();
        }

        private void estadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco01DataSet);

        }

        private void Estado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco01DataSet.estado'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoTableAdapter.Fill(this.banco01DataSet.estado);

        }
    }
}
