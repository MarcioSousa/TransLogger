namespace TranspLogger
{
    partial class frm_Rota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPedCadastrar = new System.Windows.Forms.DataGridView();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.cbxOrigem = new System.Windows.Forms.ComboBox();
            this.btnCalcularDistancia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.dgvPedagio = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedagio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvRota = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedagio)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kilometragem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Origem";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPedCadastrar);
            this.groupBox1.Controls.Add(this.cbxDestino);
            this.groupBox1.Controls.Add(this.cbxOrigem);
            this.groupBox1.Controls.Add(this.btnCalcularDistancia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDuracao);
            this.groupBox1.Controls.Add(this.txtDistancia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(330, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 367);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dgvPedCadastrar
            // 
            this.dgvPedCadastrar.AllowUserToAddRows = false;
            this.dgvPedCadastrar.AllowUserToDeleteRows = false;
            this.dgvPedCadastrar.AllowUserToResizeColumns = false;
            this.dgvPedCadastrar.AllowUserToResizeRows = false;
            this.dgvPedCadastrar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPedCadastrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedCadastrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedCadastrar.Enabled = false;
            this.dgvPedCadastrar.Location = new System.Drawing.Point(6, 92);
            this.dgvPedCadastrar.Name = "dgvPedCadastrar";
            this.dgvPedCadastrar.ReadOnly = true;
            this.dgvPedCadastrar.RowHeadersVisible = false;
            this.dgvPedCadastrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedCadastrar.Size = new System.Drawing.Size(301, 269);
            this.dgvPedCadastrar.TabIndex = 67;
            this.toolTip1.SetToolTip(this.dgvPedCadastrar, "Selecione um ou mais Pedágios");
            this.dgvPedCadastrar.SelectionChanged += new System.EventHandler(this.dgvPedCadastrar_SelectionChanged);
            // 
            // cbxDestino
            // 
            this.cbxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDestino.Enabled = false;
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(55, 40);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(160, 21);
            this.cbxDestino.TabIndex = 12;
            // 
            // cbxOrigem
            // 
            this.cbxOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrigem.Enabled = false;
            this.cbxOrigem.FormattingEnabled = true;
            this.cbxOrigem.Location = new System.Drawing.Point(55, 13);
            this.cbxOrigem.Name = "cbxOrigem";
            this.cbxOrigem.Size = new System.Drawing.Size(160, 21);
            this.cbxOrigem.TabIndex = 11;
            this.cbxOrigem.SelectedIndexChanged += new System.EventHandler(this.cbxOrigem_SelectedIndexChanged);
            // 
            // btnCalcularDistancia
            // 
            this.btnCalcularDistancia.Enabled = false;
            this.btnCalcularDistancia.Location = new System.Drawing.Point(221, 13);
            this.btnCalcularDistancia.Name = "btnCalcularDistancia";
            this.btnCalcularDistancia.Size = new System.Drawing.Size(67, 48);
            this.btnCalcularDistancia.TabIndex = 10;
            this.btnCalcularDistancia.Text = "Calcular Distância";
            this.btnCalcularDistancia.UseVisualStyleBackColor = true;
            this.btnCalcularDistancia.Click += new System.EventHandler(this.btnCalcularDistancia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Destino";
            // 
            // txtDuracao
            // 
            this.txtDuracao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuracao.Enabled = false;
            this.txtDuracao.Location = new System.Drawing.Point(211, 73);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(77, 13);
            this.txtDuracao.TabIndex = 6;
            // 
            // txtDistancia
            // 
            this.txtDistancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistancia.Enabled = false;
            this.txtDistancia.Location = new System.Drawing.Point(80, 73);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(79, 13);
            this.txtDistancia.TabIndex = 5;
            // 
            // dgvPedagio
            // 
            this.dgvPedagio.AllowUserToAddRows = false;
            this.dgvPedagio.AllowUserToDeleteRows = false;
            this.dgvPedagio.AllowUserToResizeColumns = false;
            this.dgvPedagio.AllowUserToResizeRows = false;
            this.dgvPedagio.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPedagio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedagio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedagio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.Pedagio,
            this.Preço});
            this.dgvPedagio.Enabled = false;
            this.dgvPedagio.Location = new System.Drawing.Point(6, 241);
            this.dgvPedagio.MultiSelect = false;
            this.dgvPedagio.Name = "dgvPedagio";
            this.dgvPedagio.RowHeadersVisible = false;
            this.dgvPedagio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedagio.Size = new System.Drawing.Size(318, 145);
            this.dgvPedagio.TabIndex = 13;
            this.toolTip1.SetToolTip(this.dgvPedagio, "Selecione um ou mais Pedágios");
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "Codigo";
            this.CODIGO.HeaderText = "Codigo";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 45;
            // 
            // Pedagio
            // 
            this.Pedagio.DataPropertyName = "Nome";
            this.Pedagio.HeaderText = "Pedágio";
            this.Pedagio.Name = "Pedagio";
            this.Pedagio.ReadOnly = true;
            this.Pedagio.Width = 170;
            // 
            // Preço
            // 
            this.Preço.DataPropertyName = "Preco";
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            this.Preço.Width = 80;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(88, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Cadastrar";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(250, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(169, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(385, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(466, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvPedagio);
            this.groupBox5.Controls.Add(this.dgvRota);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Location = new System.Drawing.Point(12, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(649, 392);
            this.groupBox5.TabIndex = 68;
            this.groupBox5.TabStop = false;
            // 
            // dgvRota
            // 
            this.dgvRota.AllowUserToAddRows = false;
            this.dgvRota.AllowUserToDeleteRows = false;
            this.dgvRota.AllowUserToResizeColumns = false;
            this.dgvRota.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRota.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRota.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRota.Location = new System.Drawing.Point(9, 19);
            this.dgvRota.MultiSelect = false;
            this.dgvRota.Name = "dgvRota";
            this.dgvRota.ReadOnly = true;
            this.dgvRota.RowHeadersVisible = false;
            this.dgvRota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRota.Size = new System.Drawing.Size(315, 216);
            this.dgvRota.TabIndex = 66;
            this.dgvRota.SelectionChanged += new System.EventHandler(this.dgvRota_SelectionChanged);
            // 
            // frm_Rota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 445);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Rota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário da Rota";
            this.Load += new System.EventHandler(this.frm_Rota_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedagio)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.ComboBox cbxOrigem;
        private System.Windows.Forms.Button btnCalcularDistancia;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvRota;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvPedagio;
        private System.Windows.Forms.DataGridView dgvPedCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedagio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
    }
}