using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAppEscola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConexaoAluno bd = new ConexaoAluno();
        string tabela = "tblalunos";
        string inserir;
        string unidade;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string inserir;
            string unidade = rbBarroca.Checked ? "Barroca" : "Floresta";
            int serie = rbPrimeiro.Checked ? 1 : rbSegundo.Checked ? 2 : 3;
            string turma = cmbTurma.Text;
            int idade;

            if (txtNome.Text != "" && int.TryParse(txtIdade.Text, out idade))
            {
                inserir = String.Format($"INSERT INTO {tabela} VALUES (NULL, '{txtNome.Text}', '{txtIdade.Text}', '{unidade}', '{serie}', '{turma}')");
                bd.executarComandos(inserir);
                ExibirDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Informação Inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string excluir;
            if (txtNome.Text != "")
            {
                excluir = String.Format($"DELETE FROM {tabela} WHERE id = '{lblId.Text}'");
                int resultado = bd.executarComandos(excluir);
                ExibirDados();
                if (resultado == 1)
                {
                    MessageBox.Show("Registro deletado com sucesso", "Confirmação", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Informação Inválida!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimparCampos();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int idade;
            string alterar;
            if (int.TryParse(txtIdade.Text, out idade))
            {
                string unidade = rbBarroca.Checked ? "Barroca" : "Floresta";
                int serie = rbPrimeiro.Checked ? 1 : rbSegundo.Checked ? 2 : 3;
                string turma = cmbTurma.Text;
                alterar = string.Format($"UPDATE {tabela} SET nome = '{txtNome.Text}', idade = '{txtIdade.Text}', unidade = '{unidade}', serie = '{serie}', turma = '{turma}' WHERE id = '{lblId.Text}'");
                int resultado = bd.executarComandos(alterar);
                ExibirDados();
                if (resultado == 1)
                {
                    MessageBox.Show("Atualização feita com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Informações Inválidas!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                LimparCampos();
            
        }
        private void ExibirDados()
        {
            string dados = $"SELECT * FROM {tabela} ORDER BY nome";
            DataTable dt = bd.executarConsultas(dados);
            dgvAlunos.DataSource = dt.AsDataView();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtIdade.Clear();
            rbBarroca.Checked = false;
            rbFloresta.Checked = false;
            rbPrimeiro.Checked = false;
            rbSegundo.Checked = false;
            rbTerceiro.Checked = false;
            cmbTurma.Text = "";
            txtNome.Focus();
        }

        private void dgvAluno_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Clique em uma célula para preencher os campos do formulário. ";
        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvAlunos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvAlunos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIdade.Text = dgvAlunos.Rows[e.RowIndex].Cells[2].Value.ToString();
            string unidade = dgvAlunos.Rows[e.RowIndex].Cells[3].Value.ToString();
            string serie = dgvAlunos.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbTurma.Text = dgvAlunos.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (unidade == "Barroca")
            {
                rbBarroca.Checked = true;
            }
            else
            {
                rbFloresta.Checked = true;
            }

            if (serie == "1")
            {
                rbPrimeiro.Checked = true;
            }
            else if (serie == "2")
            {
                rbSegundo.Checked = true;
            }
            else
            {
                rbTerceiro.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
