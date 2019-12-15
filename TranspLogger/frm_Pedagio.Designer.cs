namespace TranspLogger
{
    partial class frm_Pedagio
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtPesquisaPedagio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPesquisaPedagio = new System.Windows.Forms.Button();
            this.dgvPedagio = new System.Windows.Forms.DataGridView();
            this.ajuCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajuNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajuCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedagio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Importante";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(51, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(273, 20);
            this.txtNome.TabIndex = 61;
            this.toolTip1.SetToolTip(this.txtNome, "Digite o Nome do pedágio:");
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(76, 62);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(105, 20);
            this.txtPreco.TabIndex = 63;
            this.toolTip1.SetToolTip(this.txtPreco, "Digite o Nome do pedágio:");
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // txtPesquisaPedagio
            // 
            this.txtPesquisaPedagio.Location = new System.Drawing.Point(49, 19);
            this.txtPesquisaPedagio.Name = "txtPesquisaPedagio";
            this.txtPesquisaPedagio.Size = new System.Drawing.Size(236, 20);
            this.txtPesquisaPedagio.TabIndex = 61;
            this.toolTip1.SetToolTip(this.txtPesquisaPedagio, "Digite o nome do Ajudante para pesquisar");
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(261, 48);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(6, 48);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(130, 48);
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
            this.btnConfirmar.Location = new System.Drawing.Point(261, 19);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 50;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(-6, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 11);
            this.panel1.TabIndex = 59;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(7, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 110);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(108, 14);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(14, 13);
            this.lblCodigo.TabIndex = 65;
            this.lblCodigo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Valor    R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nome ";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 49;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPesquisaPedagio);
            this.groupBox5.Controls.Add(this.dgvPedagio);
            this.groupBox5.Controls.Add(this.txtPesquisaPedagio);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 219);
            this.groupBox5.TabIndex = 64;
            this.groupBox5.TabStop = false;
            // 
            // btnPesquisaPedagio
            // 
            this.btnPesquisaPedagio.Location = new System.Drawing.Point(291, 18);
            this.btnPesquisaPedagio.Name = "btnPesquisaPedagio";
            this.btnPesquisaPedagio.Size = new System.Drawing.Size(23, 23);
            this.btnPesquisaPedagio.TabIndex = 60;
            this.btnPesquisaPedagio.Text = "P";
            this.btnPesquisaPedagio.UseVisualStyleBackColor = true;
            this.btnPesquisaPedagio.Click += new System.EventHandler(this.btnPesquisaPedagio_Click);
            // 
            // dgvPedagio
            // 
            this.dgvPedagio.AllowUserToAddRows = false;
            this.dgvPedagio.AllowUserToDeleteRows = false;
            this.dgvPedagio.AllowUserToOrderColumns = true;
            this.dgvPedagio.AllowUserToResizeColumns = false;
            this.dgvPedagio.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPedagio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedagio.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPedagio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedagio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedagio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ajuCodigo,
            this.ajuNome,
            this.ajuCusto});
            this.dgvPedagio.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPedagio.Location = new System.Drawing.Point(6, 47);
            this.dgvPedagio.MultiSelect = false;
            this.dgvPedagio.Name = "dgvPedagio";
            this.dgvPedagio.ReadOnly = true;
            this.dgvPedagio.RowHeadersVisible = false;
            this.dgvPedagio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedagio.Size = new System.Drawing.Size(313, 166);
            this.dgvPedagio.TabIndex = 60;
            this.dgvPedagio.SelectionChanged += new System.EventHandler(this.dgvPedagio_SelectionChanged);
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
            this.ajuNome.HeaderText = "Pedagio";
            this.ajuNome.Name = "ajuNome";
            this.ajuNome.ReadOnly = true;
            this.ajuNome.Width = 160;
            // 
            // ajuCusto
            // 
            this.ajuCusto.DataPropertyName = "Preco";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnConfirmar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 219);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            // 
            // frm_Pedagio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 244);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Pedagio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Pedágios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedagio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPesquisaPedagio;
        private System.Windows.Forms.DataGridView dgvPedagio;
        private System.Windows.Forms.TextBox txtPesquisaPedagio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajuCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajuNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ajuCusto;
    }
}