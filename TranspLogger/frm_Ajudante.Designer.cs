namespace TranspLogger
{
    partial class frm_Ajudante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxEndereco = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisaCep = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cbxUf = new System.Windows.Forms.ComboBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxContato = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mtbCelularDois = new System.Windows.Forms.MaskedTextBox();
            this.mtbFixo = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelularUm = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvAjudante = new System.Windows.Forms.DataGridView();
            this.ajuCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajuNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajuCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPesquisaAjudante = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPesquisaAjudante = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbxEndereco.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjudante)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCusto
            // 
            this.txtCusto.Enabled = false;
            this.txtCusto.Location = new System.Drawing.Point(365, 85);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(99, 20);
            this.txtCusto.TabIndex = 56;
            this.txtCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCusto.Leave += new System.EventHandler(this.txtCusto_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 11);
            this.panel1.TabIndex = 55;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(51, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 20);
            this.txtNome.TabIndex = 54;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(390, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(95, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(178, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 51;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(307, 19);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 50;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Custo  R$";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 49;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Nome";
            // 
            // gbxEndereco
            // 
            this.gbxEndereco.Controls.Add(this.groupBox2);
            this.gbxEndereco.Controls.Add(this.mtbCep);
            this.gbxEndereco.Controls.Add(this.label7);
            this.gbxEndereco.Controls.Add(this.label3);
            this.gbxEndereco.Controls.Add(this.btnPesquisaCep);
            this.gbxEndereco.Controls.Add(this.txtNumero);
            this.gbxEndereco.Controls.Add(this.cbxUf);
            this.gbxEndereco.Controls.Add(this.txtBairro);
            this.gbxEndereco.Controls.Add(this.txtCidade);
            this.gbxEndereco.Controls.Add(this.label2);
            this.gbxEndereco.Controls.Add(this.txtLogradouro);
            this.gbxEndereco.Controls.Add(this.label4);
            this.gbxEndereco.Controls.Add(this.label5);
            this.gbxEndereco.Controls.Add(this.label8);
            this.gbxEndereco.Location = new System.Drawing.Point(10, 111);
            this.gbxEndereco.Name = "gbxEndereco";
            this.gbxEndereco.Size = new System.Drawing.Size(464, 149);
            this.gbxEndereco.TabIndex = 58;
            this.gbxEndereco.TabStop = false;
            this.gbxEndereco.Text = "Endereço";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(18, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 37);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(308, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Obs: A informação Cep gera preenchimento dos outros campos!";
            // 
            // mtbCep
            // 
            this.mtbCep.Enabled = false;
            this.mtbCep.Location = new System.Drawing.Point(346, 70);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(67, 20);
            this.mtbCep.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cep";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Bairro";
            // 
            // btnPesquisaCep
            // 
            this.btnPesquisaCep.Enabled = false;
            this.btnPesquisaCep.Location = new System.Drawing.Point(419, 70);
            this.btnPesquisaCep.Name = "btnPesquisaCep";
            this.btnPesquisaCep.Size = new System.Drawing.Size(30, 23);
            this.btnPesquisaCep.TabIndex = 19;
            this.btnPesquisaCep.UseVisualStyleBackColor = true;
            this.btnPesquisaCep.Click += new System.EventHandler(this.btnPesquisaCep_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(368, 18);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(81, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // cbxUf
            // 
            this.cbxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUf.Enabled = false;
            this.cbxUf.FormattingEnabled = true;
            this.cbxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUf.Location = new System.Drawing.Point(268, 70);
            this.cbxUf.Name = "cbxUf";
            this.cbxUf.Size = new System.Drawing.Size(40, 21);
            this.cbxUf.TabIndex = 13;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(82, 44);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(367, 20);
            this.txtBairro.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(82, 70);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(153, 20);
            this.txtCidade.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nº";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Enabled = false;
            this.txtLogradouro.Location = new System.Drawing.Point(82, 18);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(255, 20);
            this.txtLogradouro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Logradouro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "UF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cidade";
            // 
            // gbxContato
            // 
            this.gbxContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbxContato.Controls.Add(this.label12);
            this.gbxContato.Controls.Add(this.mtbCelularDois);
            this.gbxContato.Controls.Add(this.mtbFixo);
            this.gbxContato.Controls.Add(this.mtbCelularUm);
            this.gbxContato.Controls.Add(this.label11);
            this.gbxContato.Controls.Add(this.label10);
            this.gbxContato.Location = new System.Drawing.Point(10, 266);
            this.gbxContato.Name = "gbxContato";
            this.gbxContato.Size = new System.Drawing.Size(464, 54);
            this.gbxContato.TabIndex = 59;
            this.gbxContato.TabStop = false;
            this.gbxContato.Text = "Contatos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(337, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Fixo";
            // 
            // mtbCelularDois
            // 
            this.mtbCelularDois.Enabled = false;
            this.mtbCelularDois.Location = new System.Drawing.Point(225, 20);
            this.mtbCelularDois.Mask = "(99)0 0000-0000";
            this.mtbCelularDois.Name = "mtbCelularDois";
            this.mtbCelularDois.Size = new System.Drawing.Size(91, 20);
            this.mtbCelularDois.TabIndex = 22;
            // 
            // mtbFixo
            // 
            this.mtbFixo.Enabled = false;
            this.mtbFixo.Location = new System.Drawing.Point(369, 19);
            this.mtbFixo.Mask = "(99) 0000-0000";
            this.mtbFixo.Name = "mtbFixo";
            this.mtbFixo.Size = new System.Drawing.Size(79, 20);
            this.mtbFixo.TabIndex = 24;
            // 
            // mtbCelularUm
            // 
            this.mtbCelularUm.Enabled = false;
            this.mtbCelularUm.Location = new System.Drawing.Point(65, 19);
            this.mtbCelularUm.Mask = "(99)0 0000-0000";
            this.mtbCelularUm.Name = "mtbCelularUm";
            this.mtbCelularUm.Size = new System.Drawing.Size(91, 20);
            this.mtbCelularUm.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Celular2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Celular1";
            // 
            // dgvAjudante
            // 
            this.dgvAjudante.AllowUserToAddRows = false;
            this.dgvAjudante.AllowUserToDeleteRows = false;
            this.dgvAjudante.AllowUserToOrderColumns = true;
            this.dgvAjudante.AllowUserToResizeColumns = false;
            this.dgvAjudante.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAjudante.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAjudante.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAjudante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAjudante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAjudante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ajuCodigo,
            this.ajuNome,
            this.ajuCusto});
            this.dgvAjudante.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAjudante.Location = new System.Drawing.Point(6, 47);
            this.dgvAjudante.MultiSelect = false;
            this.dgvAjudante.Name = "dgvAjudante";
            this.dgvAjudante.ReadOnly = true;
            this.dgvAjudante.RowHeadersVisible = false;
            this.dgvAjudante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAjudante.Size = new System.Drawing.Size(313, 281);
            this.dgvAjudante.TabIndex = 60;
            this.dgvAjudante.SelectionChanged += new System.EventHandler(this.dgvAjudante_SelectionChanged);
            // 
            // ajuCodigo
            // 
            this.ajuCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PeachPuff;
            this.ajuCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.ajuCodigo.HeaderText = "Código";
            this.ajuCodigo.Name = "ajuCodigo";
            this.ajuCodigo.ReadOnly = true;
            this.ajuCodigo.Width = 50;
            // 
            // ajuNome
            // 
            this.ajuNome.DataPropertyName = "Nome";
            this.ajuNome.HeaderText = "Ajudante";
            this.ajuNome.Name = "ajuNome";
            this.ajuNome.ReadOnly = true;
            this.ajuNome.Width = 150;
            // 
            // ajuCusto
            // 
            this.ajuCusto.DataPropertyName = "Custo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "R$ #,##0.00";
            this.ajuCusto.DefaultCellStyle = dataGridViewCellStyle3;
            this.ajuCusto.HeaderText = "Custo";
            this.ajuCusto.Name = "ajuCusto";
            this.ajuCusto.ReadOnly = true;
            this.ajuCusto.Width = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Nome";
            // 
            // txtPesquisaAjudante
            // 
            this.txtPesquisaAjudante.Location = new System.Drawing.Point(49, 19);
            this.txtPesquisaAjudante.Name = "txtPesquisaAjudante";
            this.txtPesquisaAjudante.Size = new System.Drawing.Size(236, 20);
            this.txtPesquisaAjudante.TabIndex = 61;
            this.toolTip1.SetToolTip(this.txtPesquisaAjudante, "Digite o nome do Ajudante para pesquisar");
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPesquisaAjudante);
            this.groupBox5.Controls.Add(this.dgvAjudante);
            this.groupBox5.Controls.Add(this.txtPesquisaAjudante);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(12, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 339);
            this.groupBox5.TabIndex = 63;
            this.groupBox5.TabStop = false;
            // 
            // btnPesquisaAjudante
            // 
            this.btnPesquisaAjudante.Location = new System.Drawing.Point(291, 18);
            this.btnPesquisaAjudante.Name = "btnPesquisaAjudante";
            this.btnPesquisaAjudante.Size = new System.Drawing.Size(23, 23);
            this.btnPesquisaAjudante.TabIndex = 60;
            this.btnPesquisaAjudante.Text = "P";
            this.btnPesquisaAjudante.UseVisualStyleBackColor = true;
            this.btnPesquisaAjudante.Click += new System.EventHandler(this.btnPesquisaAjudante_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.btnNovo);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnConfirmar);
            this.groupBox4.Controls.Add(this.gbxContato);
            this.groupBox4.Controls.Add(this.btnExcluir);
            this.groupBox4.Controls.Add(this.gbxEndereco);
            this.groupBox4.Controls.Add(this.btnEditar);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Controls.Add(this.txtCusto);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.lblCodigo);
            this.groupBox4.Controls.Add(this.txtNome);
            this.groupBox4.Location = new System.Drawing.Point(336, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 339);
            this.groupBox4.TabIndex = 64;
            this.groupBox4.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(129, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Código";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(175, 69);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(14, 13);
            this.lblCodigo.TabIndex = 60;
            this.lblCodigo.Text = "0";
            // 
            // frm_Ajudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 364);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Ajudante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Ajudante";
            this.Load += new System.EventHandler(this.frm_Ajudante_Load);
            this.gbxEndereco.ResumeLayout(false);
            this.gbxEndereco.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxContato.ResumeLayout(false);
            this.gbxContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAjudante)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxEndereco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisaCep;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cbxUf;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbxContato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbCelularDois;
        private System.Windows.Forms.MaskedTextBox mtbFixo;
        private System.Windows.Forms.MaskedTextBox mtbCelularUm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAjudante;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPesquisaAjudante;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPesquisaAjudante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajuCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajuNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajuCusto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label14;
    }
}