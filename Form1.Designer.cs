namespace ProjetoAppEscola
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblResultadoID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.grpUnidade = new System.Windows.Forms.GroupBox();
            this.rbBarroca = new System.Windows.Forms.RadioButton();
            this.rbFloresta = new System.Windows.Forms.RadioButton();
            this.grpSerie = new System.Windows.Forms.GroupBox();
            this.rbPrimeiro = new System.Windows.Forms.RadioButton();
            this.rbSegundo = new System.Windows.Forms.RadioButton();
            this.rbTerceiro = new System.Windows.Forms.RadioButton();
            this.lblTurma = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpUnidade.SuspendLayout();
            this.grpSerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblResultadoID
            // 
            this.lblResultadoID.AutoSize = true;
            this.lblResultadoID.Location = new System.Drawing.Point(39, 9);
            this.lblResultadoID.Name = "lblResultadoID";
            this.lblResultadoID.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoID.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(343, 46);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 5;
            this.lblIdade.Text = "Idade:";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(346, 62);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(131, 20);
            this.txtIdade.TabIndex = 6;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // grpUnidade
            // 
            this.grpUnidade.Controls.Add(this.rbFloresta);
            this.grpUnidade.Controls.Add(this.rbBarroca);
            this.grpUnidade.Location = new System.Drawing.Point(15, 100);
            this.grpUnidade.Name = "grpUnidade";
            this.grpUnidade.Size = new System.Drawing.Size(139, 38);
            this.grpUnidade.TabIndex = 7;
            this.grpUnidade.TabStop = false;
            this.grpUnidade.Text = "Unidade";
            // 
            // rbBarroca
            // 
            this.rbBarroca.AutoSize = true;
            this.rbBarroca.Location = new System.Drawing.Point(6, 15);
            this.rbBarroca.Name = "rbBarroca";
            this.rbBarroca.Size = new System.Drawing.Size(62, 17);
            this.rbBarroca.TabIndex = 0;
            this.rbBarroca.TabStop = true;
            this.rbBarroca.Text = "Barroca";
            this.rbBarroca.UseVisualStyleBackColor = true;
            // 
            // rbFloresta
            // 
            this.rbFloresta.AutoSize = true;
            this.rbFloresta.Location = new System.Drawing.Point(74, 15);
            this.rbFloresta.Name = "rbFloresta";
            this.rbFloresta.Size = new System.Drawing.Size(62, 17);
            this.rbFloresta.TabIndex = 1;
            this.rbFloresta.TabStop = true;
            this.rbFloresta.Text = "Floresta";
            this.rbFloresta.UseVisualStyleBackColor = true;
            // 
            // grpSerie
            // 
            this.grpSerie.Controls.Add(this.rbTerceiro);
            this.grpSerie.Controls.Add(this.rbSegundo);
            this.grpSerie.Controls.Add(this.rbPrimeiro);
            this.grpSerie.Location = new System.Drawing.Point(160, 100);
            this.grpSerie.Name = "grpSerie";
            this.grpSerie.Size = new System.Drawing.Size(173, 38);
            this.grpSerie.TabIndex = 8;
            this.grpSerie.TabStop = false;
            this.grpSerie.Text = "Série";
            // 
            // rbPrimeiro
            // 
            this.rbPrimeiro.AutoSize = true;
            this.rbPrimeiro.Location = new System.Drawing.Point(29, 15);
            this.rbPrimeiro.Name = "rbPrimeiro";
            this.rbPrimeiro.Size = new System.Drawing.Size(35, 17);
            this.rbPrimeiro.TabIndex = 1;
            this.rbPrimeiro.TabStop = true;
            this.rbPrimeiro.Text = "1º";
            this.rbPrimeiro.UseVisualStyleBackColor = true;
            // 
            // rbSegundo
            // 
            this.rbSegundo.AutoSize = true;
            this.rbSegundo.Location = new System.Drawing.Point(70, 15);
            this.rbSegundo.Name = "rbSegundo";
            this.rbSegundo.Size = new System.Drawing.Size(35, 17);
            this.rbSegundo.TabIndex = 2;
            this.rbSegundo.TabStop = true;
            this.rbSegundo.Text = "2º";
            this.rbSegundo.UseVisualStyleBackColor = true;
            // 
            // rbTerceiro
            // 
            this.rbTerceiro.AutoSize = true;
            this.rbTerceiro.Location = new System.Drawing.Point(111, 15);
            this.rbTerceiro.Name = "rbTerceiro";
            this.rbTerceiro.Size = new System.Drawing.Size(35, 17);
            this.rbTerceiro.TabIndex = 3;
            this.rbTerceiro.TabStop = true;
            this.rbTerceiro.Text = "3º";
            this.rbTerceiro.UseVisualStyleBackColor = true;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Location = new System.Drawing.Point(343, 100);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(37, 13);
            this.lblTurma.TabIndex = 9;
            this.lblTurma.Text = "Turma";
            this.lblTurma.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbTurma
            // 
            this.cmbTurma.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Items.AddRange(new object[] {
            "1A1,",
            "1B1,",
            "1C1,",
            "2A1,",
            "2B1,",
            "2C1,",
            "3A1,",
            "3B1,",
            "3C1,",
            "1D1,",
            "1E1,",
            "2D1,",
            "2E1,",
            "3D1,",
            "3E1"});
            this.cmbTurma.Location = new System.Drawing.Point(346, 117);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(131, 21);
            this.cmbTurma.TabIndex = 10;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colIdade,
            this.colUnidade,
            this.colSerie,
            this.colTurma});
            this.dgvAlunos.Location = new System.Drawing.Point(15, 155);
            this.dgvAlunos.MultiSelect = false;
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersVisible = false;
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(462, 187);
            this.dgvAlunos.TabIndex = 11;
            this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colIdade
            // 
            this.colIdade.HeaderText = "Idade";
            this.colIdade.Name = "colIdade";
            this.colIdade.ReadOnly = true;
            // 
            // colUnidade
            // 
            this.colUnidade.HeaderText = "Unidade";
            this.colUnidade.Name = "colUnidade";
            this.colUnidade.ReadOnly = true;
            // 
            // colSerie
            // 
            this.colSerie.HeaderText = "Série";
            this.colSerie.Name = "colSerie";
            this.colSerie.ReadOnly = true;
            // 
            // colTurma
            // 
            this.colTurma.HeaderText = "Turma";
            this.colTurma.Name = "colTurma";
            this.colTurma.ReadOnly = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCadastrar.Location = new System.Drawing.Point(15, 357);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(77, 38);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Maroon;
            this.btnSair.Location = new System.Drawing.Point(400, 357);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 38);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAlterar.Location = new System.Drawing.Point(112, 357);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(77, 38);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Yellow;
            this.btnExcluir.Location = new System.Drawing.Point(208, 357);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(77, 38);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnPesquisar.Location = new System.Drawing.Point(303, 357);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 38);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 418);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.grpSerie);
            this.Controls.Add(this.grpUnidade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblResultadoID);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpUnidade.ResumeLayout(false);
            this.grpUnidade.PerformLayout();
            this.grpSerie.ResumeLayout(false);
            this.grpSerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblResultadoID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.GroupBox grpUnidade;
        private System.Windows.Forms.RadioButton rbFloresta;
        private System.Windows.Forms.RadioButton rbBarroca;
        private System.Windows.Forms.GroupBox grpSerie;
        private System.Windows.Forms.RadioButton rbPrimeiro;
        private System.Windows.Forms.RadioButton rbTerceiro;
        private System.Windows.Forms.RadioButton rbSegundo;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTurma;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

