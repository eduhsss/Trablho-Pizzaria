namespace Atividade04_06
{
    partial class Funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label primeiroNomeLabel;
            System.Windows.Forms.Label segundoNomeLabel;
            System.Windows.Forms.Label ultimoNomeLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label codigoCidadeLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label codigoDepartamentoLabel;
            System.Windows.Forms.Label codigoFuncaoLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label codigoSexoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.label1 = new System.Windows.Forms.Label();
            this.banco01DataSet = new Atividade04_06.banco01DataSet();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionariosTableAdapter = new Atividade04_06.banco01DataSetTableAdapters.funcionariosTableAdapter();
            this.tableAdapterManager = new Atividade04_06.banco01DataSetTableAdapters.TableAdapterManager();
            this.funcionariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.funcionariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.primeiroNomeTextBox = new System.Windows.Forms.TextBox();
            this.segundoNomeTextBox = new System.Windows.Forms.TextBox();
            this.ultimoNomeTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.rgTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.codigoCidadeTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.codigoDepartamentoTextBox = new System.Windows.Forms.TextBox();
            this.codigoFuncaoTextBox = new System.Windows.Forms.TextBox();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.codigoSexoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            codigoLabel = new System.Windows.Forms.Label();
            primeiroNomeLabel = new System.Windows.Forms.Label();
            segundoNomeLabel = new System.Windows.Forms.Label();
            ultimoNomeLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            codigoCidadeLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            codigoDepartamentoLabel = new System.Windows.Forms.Label();
            codigoFuncaoLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            codigoSexoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingNavigator)).BeginInit();
            this.funcionariosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(122, 119);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(42, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "codigo:";
            // 
            // primeiroNomeLabel
            // 
            primeiroNomeLabel.AutoSize = true;
            primeiroNomeLabel.Location = new System.Drawing.Point(122, 145);
            primeiroNomeLabel.Name = "primeiroNomeLabel";
            primeiroNomeLabel.Size = new System.Drawing.Size(77, 13);
            primeiroNomeLabel.TabIndex = 4;
            primeiroNomeLabel.Text = "primeiro Nome:";
            // 
            // segundoNomeLabel
            // 
            segundoNomeLabel.AutoSize = true;
            segundoNomeLabel.Location = new System.Drawing.Point(122, 171);
            segundoNomeLabel.Name = "segundoNomeLabel";
            segundoNomeLabel.Size = new System.Drawing.Size(82, 13);
            segundoNomeLabel.TabIndex = 6;
            segundoNomeLabel.Text = "segundo Nome:";
            // 
            // ultimoNomeLabel
            // 
            ultimoNomeLabel.AutoSize = true;
            ultimoNomeLabel.Location = new System.Drawing.Point(122, 197);
            ultimoNomeLabel.Name = "ultimoNomeLabel";
            ultimoNomeLabel.Size = new System.Drawing.Size(68, 13);
            ultimoNomeLabel.TabIndex = 8;
            ultimoNomeLabel.Text = "ultimo Nome:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(122, 224);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(90, 13);
            dataNascimentoLabel.TabIndex = 10;
            dataNascimentoLabel.Text = "data Nascimento:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(122, 249);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(25, 13);
            cpfLabel.TabIndex = 12;
            cpfLabel.Text = "cpf:";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(122, 275);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(19, 13);
            rgLabel.TabIndex = 14;
            rgLabel.Text = "rg:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(122, 301);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 16;
            cepLabel.Text = "cep:";
            // 
            // codigoCidadeLabel
            // 
            codigoCidadeLabel.AutoSize = true;
            codigoCidadeLabel.Location = new System.Drawing.Point(122, 327);
            codigoCidadeLabel.Name = "codigoCidadeLabel";
            codigoCidadeLabel.Size = new System.Drawing.Size(78, 13);
            codigoCidadeLabel.TabIndex = 18;
            codigoCidadeLabel.Text = "codigo Cidade:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(122, 353);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(31, 13);
            foneLabel.TabIndex = 20;
            foneLabel.Text = "fone:";
            // 
            // codigoDepartamentoLabel
            // 
            codigoDepartamentoLabel.AutoSize = true;
            codigoDepartamentoLabel.Location = new System.Drawing.Point(122, 379);
            codigoDepartamentoLabel.Name = "codigoDepartamentoLabel";
            codigoDepartamentoLabel.Size = new System.Drawing.Size(112, 13);
            codigoDepartamentoLabel.TabIndex = 22;
            codigoDepartamentoLabel.Text = "codigo Departamento:";
            // 
            // codigoFuncaoLabel
            // 
            codigoFuncaoLabel.AutoSize = true;
            codigoFuncaoLabel.Location = new System.Drawing.Point(122, 405);
            codigoFuncaoLabel.Name = "codigoFuncaoLabel";
            codigoFuncaoLabel.Size = new System.Drawing.Size(81, 13);
            codigoFuncaoLabel.TabIndex = 24;
            codigoFuncaoLabel.Text = "codigo Funcao:";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(122, 431);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(40, 13);
            salarioLabel.TabIndex = 26;
            salarioLabel.Text = "salario:";
            // 
            // codigoSexoLabel
            // 
            codigoSexoLabel.AutoSize = true;
            codigoSexoLabel.Location = new System.Drawing.Point(122, 457);
            codigoSexoLabel.Name = "codigoSexoLabel";
            codigoSexoLabel.Size = new System.Drawing.Size(69, 13);
            codigoSexoLabel.TabIndex = 28;
            codigoSexoLabel.Text = "codigo Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionario";
            // 
            // banco01DataSet
            // 
            this.banco01DataSet.DataSetName = "banco01DataSet";
            this.banco01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.banco01DataSet;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.departamentosTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.funcaoTableAdapter = null;
            this.tableAdapterManager.funcionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.paisTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Atividade04_06.banco01DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // funcionariosBindingNavigator
            // 
            this.funcionariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionariosBindingNavigator.BindingSource = this.funcionariosBindingSource;
            this.funcionariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.funcionariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.funcionariosBindingNavigatorSaveItem});
            this.funcionariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funcionariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funcionariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funcionariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funcionariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funcionariosBindingNavigator.Name = "funcionariosBindingNavigator";
            this.funcionariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionariosBindingNavigator.Size = new System.Drawing.Size(929, 25);
            this.funcionariosBindingNavigator.TabIndex = 1;
            this.funcionariosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // funcionariosBindingNavigatorSaveItem
            // 
            this.funcionariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionariosBindingNavigatorSaveItem.Image")));
            this.funcionariosBindingNavigatorSaveItem.Name = "funcionariosBindingNavigatorSaveItem";
            this.funcionariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.funcionariosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.funcionariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionariosBindingNavigatorSaveItem_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(240, 116);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoTextBox.TabIndex = 3;
            // 
            // primeiroNomeTextBox
            // 
            this.primeiroNomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "primeiroNome", true));
            this.primeiroNomeTextBox.Location = new System.Drawing.Point(240, 142);
            this.primeiroNomeTextBox.Name = "primeiroNomeTextBox";
            this.primeiroNomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.primeiroNomeTextBox.TabIndex = 5;
            // 
            // segundoNomeTextBox
            // 
            this.segundoNomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "segundoNome", true));
            this.segundoNomeTextBox.Location = new System.Drawing.Point(240, 168);
            this.segundoNomeTextBox.Name = "segundoNomeTextBox";
            this.segundoNomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.segundoNomeTextBox.TabIndex = 7;
            // 
            // ultimoNomeTextBox
            // 
            this.ultimoNomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "ultimoNome", true));
            this.ultimoNomeTextBox.Location = new System.Drawing.Point(240, 194);
            this.ultimoNomeTextBox.Name = "ultimoNomeTextBox";
            this.ultimoNomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.ultimoNomeTextBox.TabIndex = 9;
            // 
            // dataNascimentoDateTimePicker
            // 
            this.dataNascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.funcionariosBindingSource, "dataNascimento", true));
            this.dataNascimentoDateTimePicker.Location = new System.Drawing.Point(240, 220);
            this.dataNascimentoDateTimePicker.Name = "dataNascimentoDateTimePicker";
            this.dataNascimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataNascimentoDateTimePicker.TabIndex = 11;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "cpf", true));
            this.cpfTextBox.Location = new System.Drawing.Point(240, 246);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(200, 20);
            this.cpfTextBox.TabIndex = 13;
            // 
            // rgTextBox
            // 
            this.rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "rg", true));
            this.rgTextBox.Location = new System.Drawing.Point(240, 272);
            this.rgTextBox.Name = "rgTextBox";
            this.rgTextBox.Size = new System.Drawing.Size(200, 20);
            this.rgTextBox.TabIndex = 15;
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "cep", true));
            this.cepTextBox.Location = new System.Drawing.Point(240, 298);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(200, 20);
            this.cepTextBox.TabIndex = 17;
            // 
            // codigoCidadeTextBox
            // 
            this.codigoCidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "codigoCidade", true));
            this.codigoCidadeTextBox.Location = new System.Drawing.Point(240, 324);
            this.codigoCidadeTextBox.Name = "codigoCidadeTextBox";
            this.codigoCidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoCidadeTextBox.TabIndex = 19;
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(240, 350);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(200, 20);
            this.foneTextBox.TabIndex = 21;
            // 
            // codigoDepartamentoTextBox
            // 
            this.codigoDepartamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "codigoDepartamento", true));
            this.codigoDepartamentoTextBox.Location = new System.Drawing.Point(240, 376);
            this.codigoDepartamentoTextBox.Name = "codigoDepartamentoTextBox";
            this.codigoDepartamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoDepartamentoTextBox.TabIndex = 23;
            // 
            // codigoFuncaoTextBox
            // 
            this.codigoFuncaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "codigoFuncao", true));
            this.codigoFuncaoTextBox.Location = new System.Drawing.Point(240, 402);
            this.codigoFuncaoTextBox.Name = "codigoFuncaoTextBox";
            this.codigoFuncaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoFuncaoTextBox.TabIndex = 25;
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "salario", true));
            this.salarioTextBox.Location = new System.Drawing.Point(240, 428);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.salarioTextBox.TabIndex = 27;
            // 
            // codigoSexoTextBox
            // 
            this.codigoSexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "codigoSexo", true));
            this.codigoSexoTextBox.Location = new System.Drawing.Point(240, 454);
            this.codigoSexoTextBox.Name = "codigoSexoTextBox";
            this.codigoSexoTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoSexoTextBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(724, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 41);
            this.button1.TabIndex = 30;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "testrel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(929, 494);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(primeiroNomeLabel);
            this.Controls.Add(this.primeiroNomeTextBox);
            this.Controls.Add(segundoNomeLabel);
            this.Controls.Add(this.segundoNomeTextBox);
            this.Controls.Add(ultimoNomeLabel);
            this.Controls.Add(this.ultimoNomeTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoDateTimePicker);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(rgLabel);
            this.Controls.Add(this.rgTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(codigoCidadeLabel);
            this.Controls.Add(this.codigoCidadeTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(codigoDepartamentoLabel);
            this.Controls.Add(this.codigoDepartamentoTextBox);
            this.Controls.Add(codigoFuncaoLabel);
            this.Controls.Add(this.codigoFuncaoTextBox);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(codigoSexoLabel);
            this.Controls.Add(this.codigoSexoTextBox);
            this.Controls.Add(this.funcionariosBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Funcionario";
            this.Text = "l";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingNavigator)).EndInit();
            this.funcionariosBindingNavigator.ResumeLayout(false);
            this.funcionariosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private banco01DataSet banco01DataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private banco01DataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private banco01DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionariosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton funcionariosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox primeiroNomeTextBox;
        private System.Windows.Forms.TextBox segundoNomeTextBox;
        private System.Windows.Forms.TextBox ultimoNomeTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimentoDateTimePicker;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox rgTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.TextBox codigoCidadeTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox codigoDepartamentoTextBox;
        private System.Windows.Forms.TextBox codigoFuncaoTextBox;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.TextBox codigoSexoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}