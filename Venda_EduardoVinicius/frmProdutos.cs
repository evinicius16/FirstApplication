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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql;
        int codigo = 0;


        public void limpar()
        {
            txtdescricao.Clear();
            txtpesquisar.Clear();
            txtQuantidade.Clear();
            txtvalor.Clear();

            cbxEmpresa.SelectedIndex = -1;
        }


        public void CarregarEmpresas()
        {

            sql = string.Format("select codigo, nome from empresa");
            cbxEmpresa.DataSource = bd.ConsultarDados(sql);
            cbxEmpresa.DisplayMember = "nome";
            cbxEmpresa.ValueMember = "codigo";
            cbxEmpresa.SelectedIndex = -1;

        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CarregarEmpresas();
        }

        private void btnSalavar_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into produto values(null,'{0}','{1}','{2}','{3}')"
                , txtdescricao.Text, txtQuantidade.Text, txtvalor.Text.Replace(",", "."), cbxEmpresa.SelectedValue);

            if (bd.AlterarTabelas(sql) > 0)
            {
                MessageBox.Show("Produto Cadastrado com sucesso.", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select produto.codigo, produto.descricao, produto.quantidade, produto.valor, empresa.nome as empresa from produto join empresa on produto.empresa = empresa.codigo");

            if (rbddescrição.Checked)
            {
                sql = string.Format("select produto.codigo, produto.descricao, produto.quantidade, produto.valor, empresa.nome  as empresa  from produto join empresa on produto.empresa = empresa.codigo where produto.descricao like '%{0}%'", txtpesquisar.Text);
            }


            dtglistar.DataSource = bd.ConsultarDados(sql);

        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdescricao.Text = dtglistar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQuantidade.Text = dtglistar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtvalor.Text = double.Parse(dtglistar.Rows[e.RowIndex].Cells[3].Value.ToString()).ToString("0.00");

            codigo = int.Parse(dtglistar.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update produto set descricao = '{0}', quantidade = '{1}', valor = '{2}', empresa = '{3}' where codigo = '{4}'"
               , txtdescricao.Text, txtQuantidade.Text, txtvalor.Text.Replace(",", "."), cbxEmpresa.SelectedValue, codigo);


            if (bd.AlterarTabelas(sql) > 0)
            {
                MessageBox.Show("Produto Alterado com sucesso.", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from produto where codigo = '{0}'", codigo);
            if (bd.AlterarTabelas(sql) > 0)
            {
                MessageBox.Show("Produto Excluido com sucesso.", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
