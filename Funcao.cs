﻿using System;
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
    public partial class Funcao : Form
    {
        public Funcao()
        {
            InitializeComponent();
        }

        private void funcaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco01DataSet);

        }

        private void Funcao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco01DataSet.funcao'. Você pode movê-la ou removê-la conforme necessário.
            this.funcaoTableAdapter.Fill(this.banco01DataSet.funcao);

        }
    }
}
