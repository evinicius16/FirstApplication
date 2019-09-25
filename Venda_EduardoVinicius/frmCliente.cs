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
    public partial class frmCliente : Form
    {

        ConexaoBD conexao = new ConexaoBD();
        string sql;
        int codigo = 0;

        public frmCliente()
        {
            InitializeComponent();
        }

        public void limpar()
        {
            txtnome.Clear();
            txtendereco.Clear();
            txtcidade.Clear();
            cbxestado.SelectedIndex = -1;
            msktelefone.Clear();
            txtnome.Focus();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into clientes values(null,'{0}','{1}','{2}','{3}','{4}')"
                , txtnome.Text, txtendereco.Text, txtcidade.Text, cbxestado.Text, msktelefone.Text);

            if (conexao.AlterarTabelas(sql) > 0)
            {
                MessageBox.Show("Cliente Cadastrado com sucesso.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (codigo != 0)
            {
                sql = string.Format("delete from clientes where codigo = '{0}'", codigo);

                if (conexao.AlterarTabelas(sql) > 0)
                {
                    MessageBox.Show("Cliente Excluido com sucesso.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    codigo = 0;
                    limpar();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Cliente para excluir.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnome.Text = dtglistar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtendereco.Text = dtglistar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcidade.Text = dtglistar.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxestado.Text = dtglistar.Rows[e.RowIndex].Cells[4].Value.ToString();
            msktelefone.Text = dtglistar.Rows[e.RowIndex].Cells[5].Value.ToString();
            codigo = int.Parse(dtglistar.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select * from clientes");

            if (rbtnnome.Checked)
            {
                sql = string.Format("select * from clientes where nome = '{0}'", txtpesquisa.Text);
            }
            else if (rbtnendereco.Checked)
            {
                sql = string.Format("select * from clientes where endereco = '{0}'", txtpesquisa.Text);
            }
            else if (rbtncidade.Checked)
            {
                sql = string.Format("select * from clientes where cidade = '{0}'", txtpesquisa.Text);
            }

            dtglistar.DataSource = conexao.ConsultarDados(sql);
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (codigo != 0)
            {
                sql = string.Format("update clientes set nome = '{0}', endereco = '{1}', cidade = '{2}', estado = '{3}', telefone = '{4}' where codigo = '{5}'"
              , txtnome.Text, txtendereco.Text, txtcidade.Text, cbxestado.Text, msktelefone.Text, codigo);

                if (conexao.AlterarTabelas(sql) > 0)
                {
                    MessageBox.Show("Cliente Alterado com sucesso.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    codigo = 0;
                    limpar();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Cliente para Alterar.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
