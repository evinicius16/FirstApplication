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
    public partial class frmvendas : Form
    {
        public frmvendas()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        string sql;
        DataTable dt;
        int item;
        double total;


        public void listar_itens()
        {
            sql = string.Format("select iv.codigo, p.descricao, iv.quantidade, iv.valor_unit, iv.total from itens_vendas iv, produto p where iv.produtos = p.codigo and iv.vendas = '{0}'", txtcod.Text);
            dtglistar.DataSource = bd.ConsultarDados(sql);

        }


        public void limpar()
        {

            txtcod.Clear();
            txtdesc.Clear();
            txtdata.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtObs.Clear();
            txtTotVenda.Text = "0";
            txtval_tot.Clear();
            txtval_tot.Clear();
            cbxcliente.SelectedIndex = -1;
            cbxfuncionario.SelectedIndex = -1;
            cbxproduto.SelectedIndex = -1;
            dtglistar.DataSource = null;
            pnlitens.Enabled = false;

        }



        public void Carregarclientes()
        {

            sql = string.Format("select codigo, nome from clientes");
            cbxcliente.DataSource = bd.ConsultarDados(sql);
            cbxcliente.DisplayMember = "nome";
            cbxcliente.ValueMember = "codigo";
            cbxcliente.SelectedIndex = -1;

        }

        public void Carregarfuncionarios()
        {

            sql = string.Format("select cpf, nome from funcionarios");
            cbxfuncionario.DataSource = bd.ConsultarDados(sql);
            cbxfuncionario.DisplayMember = "nome";
            cbxfuncionario.ValueMember = "cpf";
            cbxfuncionario.SelectedIndex = -1;

        }


        public void CarregarProdutos()
        {

            sql = string.Format("select codigo, descricao from produto");
            cbxproduto.DataSource = bd.ConsultarDados(sql);
            cbxproduto.DisplayMember = "descricao";
            cbxproduto.ValueMember = "codigo";
            cbxproduto.SelectedIndex = -1;

        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            Carregarclientes();
            Carregarfuncionarios();
            txtdata.Text = DateTime.Now.ToString("dd/MM/yyyy");
            CarregarProdutos();
            txtval_unit.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into vendas values(null,'{0}','{1}','{2}','{3}','{4}','{5}')"
                , txtdesc.Text, DateTime.Now.ToString("yyyy-MM-dd"), txtTotVenda.Text.Replace(",", "."), txtObs.Text, cbxcliente.SelectedValue, cbxfuncionario.SelectedValue);

            if (bd.AlterarTabelas(sql) > 0)
            {
                sql = string.Format("select max(codigo) as codigo from vendas");
                dt = bd.ConsultarDados(sql);

                if (dt.Rows.Count > 0)
                {
                    txtcod.Text = dt.Rows[0]["codigo"].ToString();
                    pnlitens.Enabled = true;
                }


            }
        }

        private void cbxproduto_SelectedIndexChanged(object sender, EventArgs e)
        {

            sql = string.Format("select valor from produto where descricao = '{0}'", cbxproduto.Text);

            dt = bd.ConsultarDados(sql);

            if (dt.Rows.Count > 0)
            {
                txtval_unit.Text = dt.Rows[0]["valor"].ToString();
            }


        }

        private void btninserir_Click(object sender, EventArgs e)
        {

            double total = 0;

            total = double.Parse(txtval_unit.Text) * int.Parse(txtqtd.Text);
            txtval_tot.Text = total.ToString();

            txtTotVenda.Text = (double.Parse(txtTotVenda.Text) + total).ToString();


            sql = string.Format("insert into itens_vendas values(null, '{0}','{1}','{2}','{3}','{4}')"
                , txtval_unit.Text.Replace(",", "."), txtqtd.Text, txtval_tot.Text.Replace(",", "."), txtcod.Text, cbxproduto.SelectedValue);

            if (bd.AlterarTabelas(sql) > 0)
            {
                listar_itens();
                sql = string.Format("update vendas set total = '{0}' where codigo = '{1}'"
                    , txtTotVenda.Text.Replace(",", "."), txtcod.Text);
                bd.AlterarTabelas(sql);
            }


        }

        private void dtglistar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = 0;
            total = 0;

            item = int.Parse(dtglistar.Rows[e.RowIndex].Cells[0].Value.ToString());
            total = double.Parse(dtglistar.Rows[e.RowIndex].Cells[4].Value.ToString());

            MessageBox.Show("Codigo do item selecionado " + item);

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from itens_vendas where codigo = '{0}'", item);
            if (bd.AlterarTabelas(sql) > 0)
            {
                listar_itens();
                txtTotVenda.Text = (double.Parse(txtTotVenda.Text) - total).ToString();
                sql = string.Format("update vendas set total = '{0}' where codigo = '{1}'"
                   , txtTotVenda.Text.Replace(",", "."), txtcod.Text);
                bd.AlterarTabelas(sql);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sql = string.Format("delete from itens_vendas where venda = '{0}'", txtcod.Text);
            bd.AlterarTabelas(sql);

            sql = string.Format("delete from vendas where codigo = '{0}'", txtcod.Text);
            bd.AlterarTabelas(sql);


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update vendas set descricao = '{0}', observacao = '{1}' where codigo = '{2}'"
                , txtdesc.Text, txtObs.Text, txtcod.Text);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select v.codigo, v.descricao, v.data_venda, v.total, v.observacao, c.nome, v.funcionario from vendas v, clientes c where v.cliente = c.codigo");

            if (rdbvenda.Checked)
            {
                sql = string.Format("select v.codigo, v.descricao, v.data_venda, v.total, v.observacao, c.nome, v.funcionario from vendas v, clientes c where v.cliente = c.codigo and c.codigo = '{0}'"
                    , txtpesquisar.Text);
            }
            else if (rdbfuncionario.Checked)
            {
                sql = string.Format("select v.codigo, v.descricao, v.data_venda, v.total, v.observacao, c.nome, v.funcionario from vendas v, clientes c where v.cliente = c.codigo and c.funcionario = '{0}'"
                    , txtpesquisar.Text);
            }
            else if (rdbcliente.Checked)
            {
                sql = string.Format("select v.codigo, v.descricao, v.data_venda, v.total, v.observacao, c.nome, v.funcionario from vendas v, clientes c where v.cliente = c.codigo and c.nome like '%{0}%'"
                    , txtpesquisar.Text);
            }
            else if (rdbdata.Checked)
            {
                sql = string.Format("select v.codigo, v.descricao, v.data_venda, v.total, v.observacao, c.nome, v.funcionario from vendas v, clientes c where v.cliente = c.codigo and c.data = '{0}'"
                    , txtpesquisar.Text);
            }



            dtgvendas.DataSource = bd.ConsultarDados(sql);


        }
    }
}
