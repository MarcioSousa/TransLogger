namespace TranspLogger
{
    partial class frm_Imprevisto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImprevisto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPesquisarImprevisto = new System.Windows.Forms.Button();
            this.dgvImprevisto = new System.Windows.Forms.DataGridView();
            this.impCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPesquisarImprevisto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImprevisto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(385, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(87, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 63;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(168, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 62;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(304, 12);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 61;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtImprevisto);
            this.groupBox1.Location = new System.Drawing.Point(6, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 128);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(123, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(14, 13);
            this.lblCodigo.TabIndex = 73;
            this.lblCodigo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Imprevistos";
            // 
            // txtImprevisto
            // 
            this.txtImprevisto.Enabled = false;
            this.txtImprevisto.Location = new System.Drawing.Point(9, 32);
            this.txtImprevisto.MaxLength = 200;
            this.txtImprevisto.Multiline = true;
            this.txtImprevisto.Name = "txtImprevisto";
            this.txtImprevisto.Size = new System.Drawing.Size(445, 90);
            this.txtImprevisto.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(-6, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 11);
            this.panel1.TabIndex = 70;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 60;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Nesse campo, poderá cadastrar um imprevisto por vez!";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPesquisarImprevisto);
            this.groupBox5.Controls.Add(this.dgvImprevisto);
            this.groupBox5.Controls.Add(this.txtPesquisarImprevisto);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 218);
            this.groupBox5.TabIndex = 72;
            this.groupBox5.TabStop = false;
            // 
            // btnPesquisarImprevisto
            // 
            this.btnPesquisarImprevisto.Location = new System.Drawing.Point(291, 18);
            this.btnPesquisarImprevisto.Name = "btnPesquisarImprevisto";
            this.btnPesquisarImprevisto.Size = new System.Drawing.Size(23, 23);
            this.btnPesquisarImprevisto.TabIndex = 60;
            this.btnPesquisarImprevisto.Text = "P";
            this.btnPesquisarImprevisto.UseVisualStyleBackColor = true;
            this.btnPesquisarImprevisto.Click += new System.EventHandler(this.btnPesquisarImprevisto_Click);
            // 
            // dgvImprevisto
            // 
            this.dgvImprevisto.AllowUserToAddRows = false;
            this.dgvImprevisto.AllowUserToDeleteRows = false;
            this.dgvImprevisto.AllowUserToOrderColumns = true;
            this.dgvImprevisto.AllowUserToResizeColumns = false;
            this.dgvImprevisto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvImprevisto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImprevisto.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvImprevisto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvImprevisto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImprevisto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.impCodigo,
            this.impNome});
            this.dgvImprevisto.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvImprevisto.Location = new System.Drawing.Point(6, 47);
            this.dgvImprevisto.MultiSelect = false;
            this.dgvImprevisto.Name = "dgvImprevisto";
            this.dgvImprevisto.ReadOnly = true;
            this.dgvImprevisto.RowHeadersVisible = false;
            this.dgvImprevisto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImprevisto.Size = new System.Drawing.Size(313, 165);
            this.dgvImprevisto.TabIndex = 60;
            this.dgvImprevisto.SelectionChanged += new System.EventHandler(this.dgvImprevisto_SelectionChanged);
            // 
            // impCodigo
            // 
            this.impCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.PeachPuff;
            this.impCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.impCodigo.HeaderText = "Código";
            this.impCodigo.Name = "impCodigo";
            this.impCodigo.ReadOnly = true;
            this.impCodigo.Width = 50;
            // 
            // impNome
            // 
            this.impNome.DataPropertyName = "Nome";
            this.impNome.HeaderText = "Imprevisto";
            this.impNome.Name = "impNome";
            this.impNome.ReadOnly = true;
            this.impNome.Width = 244;
            // 
            // txtPesquisarImprevisto
            // 
            this.txtPesquisarImprevisto.Location = new System.Drawing.Point(49, 19);
            this.txtPesquisarImprevisto.Name = "txtPesquisarImprevisto";
            this.txtPesquisarImprevisto.Size = new System.Drawing.Size(236, 20);
            this.txtPesquisarImprevisto.TabIndex = 61;
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
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnConfirmar);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Location = new System.Drawing.Point(336, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 218);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            // 
            // frm_Imprevisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 242);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Imprevisto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Imprevistos";
            this.Load += new System.EventHandler(this.frm_Imprevisto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImprevisto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImprevisto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPesquisarImprevisto;
        private System.Windows.Forms.DataGridView dgvImprevisto;
        private System.Windows.Forms.TextBox txtPesquisarImprevisto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn impCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn impNome;
    }
}