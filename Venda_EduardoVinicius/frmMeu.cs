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
    public partial class frmMeu : Form
    {
        public frmMeu()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmvendas cad = new frmvendas();
            cad.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmProdutos cad = new frmProdutos();
            cad.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmCliente cad = new frmCliente();
            cad.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmfuncionarios cad = new frmfuncionarios();
            cad.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frnEmpresa cad = new frnEmpresa();
            cad.ShowDialog();
        }
    }
}
