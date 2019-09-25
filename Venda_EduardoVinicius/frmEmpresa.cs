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
    public partial class frnEmpresa : Form
    {
        public frnEmpresa()
        {
            InitializeComponent();
        }


        ConexaoBD bd = new ConexaoBD();
        string sql = "";
        int codigo = 0;

        public void limpar()
        {
            txtnome.Focus();
            txtcidade.Clear();
            txtemail.Clear();
            txtendereco.Clear();
            txtnome.Clear();
            txtPesquisar.Clear();
            txtsite.Clear();
            msktelefone.Clear();
            dtglistar.DataSource = null;
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into empresa values(null,'{0}','{1}','{2}','{3}','{4}','{5}')",
                txtnome.Text, txtendereco.Text, txtcidade.Text, txtemail.Text, msktelefone.Text, txtsite.Text);

            if (bd.AlterarTabelas(sql) > 0)
            {
                MessageBox.Show("Empresa Cadastrada com sucesso.", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select * from empresa");

            if (rdbnome.Checked)
            {
                sql = string.Format("select * from empresa where nome = '{0}'", txtPesquisar.Text);
            }
            else if (rdbendereco.Checked)
            {
                sql = string.Format("select * from empresa where endereco = '{0}'", txtPesquisar.Text);
            }
            else if (rdbcidade.Checked)
            {
                sql = string.Format("select * from empresa where cidade = '{0}'", txtPesquisar.Text);
            }

            dtglistar.DataSource = bd.ConsultarDados(sql);
        }

        private void dtgConsultaE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnome.Text = dtglistar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtendereco.Text = dtglistar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtcidade.Text = dtglistar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dtglistar.Rows[e.RowIndex].Cells[4].Value.ToString();
            msktelefone.Text = dtglistar.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtsite.Text = dtglistar.Rows[e.RowIndex].Cells[6].Value.ToString();

            codigo = int.Parse(dtglistar.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update empresa set nome = '{0}', endereco =  '{1}', cidade = '{2}', email = '{3}', telefone = '{4}', site = '{5}' where codigo = '{6}'",
               txtnome.Text, txtendereco.Text, txtcidade.Text, txtemail.Text, msktelefone.Text, txtsite.Text, codigo);

            if (bd.AlterarTabelas(sql) > 0)
            {
                MessageBox.Show("Empresa Alterada com sucesso.", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from empresa where codigo = '{0}'", codigo);

            if (bd.AlterarTabelas(sql) > 0)
            {
                MessageBox.Show("Empresa Excluida com sucesso.", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
