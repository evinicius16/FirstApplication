using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Venda_EduardoVinicius
{
    public partial class frmfuncionarios : Form
    {
        public frmfuncionarios()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql;
        int codigo = 0;


        public void limpar()
        {
            txtcidade.Clear();
            txtcpf.Clear();
            txtemail.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtPesquisa.Clear();
            txttelefone.Clear();
            dtpNascimento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbxEstado.SelectedIndex = -1;
            txtsenha.Clear();
            txtconfsenha.Clear();
            txtlogin.Clear();

        }

        private void btnSalavar_Click(object sender, EventArgs e)
        {
            if (txtcpf.Text != "" && txtsenha.Text != "" && txtsenha.Text == txtconfsenha.Text && txtsenha.TextLength == 6)
            {
                DateTime dt = DateTime.Parse(dtpNascimento.Text);

                sql = string.Format("insert into funcionarios values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                    txtcpf.Text, txtNome.Text, txtEndereco.Text, txtcidade.Text, cbxEstado.Text, txttelefone.Text, dt.ToString("yyyy-MM-dd"), txtemail.Text, txtlogin.Text, txtsenha.Text);
                if (bd.AlterarTabelas(sql) > 0)
                {
                    MessageBox.Show("Funcionario Cadastrado com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Dados para cadastro incorreto. Verifique", "Error Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }



        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtcpf.Text != "" && txtsenha.Text != "" && txtsenha.Text == txtconfsenha.Text && txtsenha.TextLength == 6)
            {
                DateTime dt = DateTime.Parse(dtpNascimento.Text);

                sql = string.Format("update funcionarios set nome =  '{1}', endereco = '{2}',cidade = '{3}', estado = '{4}', telefone = '{5}', email = '{7}',datanascimento = '{6}', login = '{8}', senha = '{9}' where cpf = '{0}'",
                    txtcpf.Text, txtNome.Text, txtEndereco.Text, txtcidade.Text, cbxEstado.Text, txttelefone.Text, dt.ToString("yyyy-MM-dd"), txtemail.Text, txtlogin.Text, txtsenha.Text);
                if (bd.AlterarTabelas(sql) > 0)
                {
                    MessageBox.Show("Funcionario Alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {

                MessageBox.Show("Dados para alterar incorreto. Verifique", "Error Alterado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcpf.Text = dtglistar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtglistar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEndereco.Text = dtglistar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcidade.Text = dtglistar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttelefone.Text = dtglistar.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtemail.Text = dtglistar.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtlogin.Text = dtglistar.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from funcionarios where cpf = '{0}'", txtcpf.Text);
            if (bd.AlterarTabelas(sql) > 0)
            {
                MessageBox.Show("Funcionario Excluido com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select cpf, nome, endereco, cidade, estado, telefone, datanascimento, email, login from funcionarios");

            if (rdbcpf.Checked)
            {
                sql = string.Format("select cpf, nome, endereco, cidade, estado, telefone, datanascimento, email, login from funcionarios where cpf = '{0}'", txtPesquisa.Text);
            }
            else if (rdbNome.Checked)
            {
                sql = string.Format("select cpf, nome, endereco, cidade, estado, telefone, datanascimento, email, login from funcionarios where nome = '{0}'", txtPesquisa.Text);
            }
            else if (rdbusuario.Checked)
            {
                sql = string.Format("select cpf, nome, endereco, cidade, estado, telefone, datanascimento, email, login from funcionarios where login = '{0}'", txtPesquisa.Text);
            }

            dtglistar.DataSource = bd.ConsultarDados(sql);
        }
    }
}
