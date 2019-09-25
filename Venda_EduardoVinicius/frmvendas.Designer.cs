namespace Venda_EduardoVinicius
{
    partial class frmvendas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlitens = new System.Windows.Forms.Panel();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btninserir = new System.Windows.Forms.Button();
            this.txtval_tot = new System.Windows.Forms.TextBox();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.txtval_unit = new System.Windows.Forms.TextBox();
            this.cbxproduto = new System.Windows.Forms.ComboBox();
            this.lblvaltot = new System.Windows.Forms.Label();
            this.lblqtd = new System.Windows.Forms.Label();
            this.lblvalunit = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.pnlvenda = new System.Windows.Forms.Panel();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtTotVenda = new System.Windows.Forms.TextBox();
            this.cbxfuncionario = new System.Windows.Forms.ComboBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblfuncionario = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.cbxcliente = new System.Windows.Forms.ComboBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgvendas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.rdbdata = new System.Windows.Forms.RadioButton();
            this.rdbfuncionario = new System.Windows.Forms.RadioButton();
            this.rdbcliente = new System.Windows.Forms.RadioButton();
            this.rdbvenda = new System.Windows.Forms.RadioButton();
            this.rdbtodos = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlitens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            this.pnlvenda.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvendas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 448);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlitens);
            this.tabPage1.Controls.Add(this.pnlvenda);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlitens
            // 
            this.pnlitens.BackColor = System.Drawing.Color.Turquoise;
            this.pnlitens.Controls.Add(this.btnexcluir);
            this.pnlitens.Controls.Add(this.btninserir);
            this.pnlitens.Controls.Add(this.txtval_tot);
            this.pnlitens.Controls.Add(this.txtqtd);
            this.pnlitens.Controls.Add(this.txtval_unit);
            this.pnlitens.Controls.Add(this.cbxproduto);
            this.pnlitens.Controls.Add(this.lblvaltot);
            this.pnlitens.Controls.Add(this.lblqtd);
            this.pnlitens.Controls.Add(this.lblvalunit);
            this.pnlitens.Controls.Add(this.lblProduto);
            this.pnlitens.Controls.Add(this.dtglistar);
            this.pnlitens.Enabled = false;
            this.pnlitens.Location = new System.Drawing.Point(6, 179);
            this.pnlitens.Name = "pnlitens";
            this.pnlitens.Size = new System.Drawing.Size(749, 234);
            this.pnlitens.TabIndex = 1;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(623, 195);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(106, 23);
            this.btnexcluir.TabIndex = 10;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(484, 195);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(106, 23);
            this.btninserir.TabIndex = 9;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            // 
            // txtval_tot
            // 
            this.txtval_tot.Location = new System.Drawing.Point(531, 154);
            this.txtval_tot.Name = "txtval_tot";
            this.txtval_tot.Size = new System.Drawing.Size(198, 20);
            this.txtval_tot.TabIndex = 8;
            // 
            // txtqtd
            // 
            this.txtqtd.Location = new System.Drawing.Point(531, 107);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(198, 20);
            this.txtqtd.TabIndex = 7;
            // 
            // txtval_unit
            // 
            this.txtval_unit.Location = new System.Drawing.Point(531, 60);
            this.txtval_unit.Name = "txtval_unit";
            this.txtval_unit.Size = new System.Drawing.Size(198, 20);
            this.txtval_unit.TabIndex = 6;
            // 
            // cbxproduto
            // 
            this.cbxproduto.FormattingEnabled = true;
            this.cbxproduto.Location = new System.Drawing.Point(531, 12);
            this.cbxproduto.Name = "cbxproduto";
            this.cbxproduto.Size = new System.Drawing.Size(198, 21);
            this.cbxproduto.TabIndex = 5;
            // 
            // lblvaltot
            // 
            this.lblvaltot.AutoSize = true;
            this.lblvaltot.Location = new System.Drawing.Point(494, 159);
            this.lblvaltot.Name = "lblvaltot";
            this.lblvaltot.Size = new System.Drawing.Size(31, 13);
            this.lblvaltot.TabIndex = 4;
            this.lblvaltot.Text = "Total";
            // 
            // lblqtd
            // 
            this.lblqtd.AutoSize = true;
            this.lblqtd.Location = new System.Drawing.Point(463, 110);
            this.lblqtd.Name = "lblqtd";
            this.lblqtd.Size = new System.Drawing.Size(62, 13);
            this.lblqtd.TabIndex = 3;
            this.lblqtd.Text = "Quantidade";
            // 
            // lblvalunit
            // 
            this.lblvalunit.AutoSize = true;
            this.lblvalunit.Location = new System.Drawing.Point(455, 61);
            this.lblvalunit.Name = "lblvalunit";
            this.lblvalunit.Size = new System.Drawing.Size(70, 13);
            this.lblvalunit.TabIndex = 2;
            this.lblvalunit.Text = "Valor Unitário";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(481, 12);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(5, 3);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(421, 228);
            this.dtglistar.TabIndex = 0;
            // 
            // pnlvenda
            // 
            this.pnlvenda.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlvenda.Controls.Add(this.btnsalvar);
            this.pnlvenda.Controls.Add(this.txtcod);
            this.pnlvenda.Controls.Add(this.txtTotVenda);
            this.pnlvenda.Controls.Add(this.cbxfuncionario);
            this.pnlvenda.Controls.Add(this.txtdata);
            this.pnlvenda.Controls.Add(this.lbltotal);
            this.pnlvenda.Controls.Add(this.lbldata);
            this.pnlvenda.Controls.Add(this.lblfuncionario);
            this.pnlvenda.Controls.Add(this.txtObs);
            this.pnlvenda.Controls.Add(this.txtdesc);
            this.pnlvenda.Controls.Add(this.cbxcliente);
            this.pnlvenda.Controls.Add(this.lblObservacao);
            this.pnlvenda.Controls.Add(this.lblDescricao);
            this.pnlvenda.Controls.Add(this.lblCliente);
            this.pnlvenda.Location = new System.Drawing.Point(6, 6);
            this.pnlvenda.Name = "pnlvenda";
            this.pnlvenda.Size = new System.Drawing.Size(749, 167);
            this.pnlvenda.TabIndex = 0;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(629, 96);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(100, 23);
            this.btnsalvar.TabIndex = 13;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtcod
            // 
            this.txtcod.Enabled = false;
            this.txtcod.Location = new System.Drawing.Point(629, 18);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 12;
            // 
            // txtTotVenda
            // 
            this.txtTotVenda.Enabled = false;
            this.txtTotVenda.Location = new System.Drawing.Point(432, 96);
            this.txtTotVenda.Name = "txtTotVenda";
            this.txtTotVenda.Size = new System.Drawing.Size(158, 20);
            this.txtTotVenda.TabIndex = 11;
            this.txtTotVenda.Text = "0";
            this.txtTotVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxfuncionario
            // 
            this.cbxfuncionario.FormattingEnabled = true;
            this.cbxfuncionario.Location = new System.Drawing.Point(432, 18);
            this.cbxfuncionario.Name = "cbxfuncionario";
            this.cbxfuncionario.Size = new System.Drawing.Size(158, 21);
            this.cbxfuncionario.TabIndex = 10;
            // 
            // txtdata
            // 
            this.txtdata.Enabled = false;
            this.txtdata.Location = new System.Drawing.Point(432, 57);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(158, 20);
            this.txtdata.TabIndex = 9;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(395, 96);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "Total";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(396, 57);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(30, 13);
            this.lbldata.TabIndex = 7;
            this.lbldata.Text = "Data";
            // 
            // lblfuncionario
            // 
            this.lblfuncionario.AutoSize = true;
            this.lblfuncionario.Location = new System.Drawing.Point(364, 18);
            this.lblfuncionario.Name = "lblfuncionario";
            this.lblfuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblfuncionario.TabIndex = 6;
            this.lblfuncionario.Text = "Funcionario";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(84, 96);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(252, 56);
            this.txtObs.TabIndex = 5;
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(84, 57);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(252, 20);
            this.txtdesc.TabIndex = 4;
            // 
            // cbxcliente
            // 
            this.cbxcliente.FormattingEnabled = true;
            this.cbxcliente.Location = new System.Drawing.Point(84, 18);
            this.cbxcliente.Name = "cbxcliente";
            this.cbxcliente.Size = new System.Drawing.Size(252, 21);
            this.cbxcliente.TabIndex = 3;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(13, 96);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 2;
            this.lblObservacao.Text = "Observação";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(23, 57);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(39, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgvendas);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgvendas
            // 
            this.dtgvendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvendas.Location = new System.Drawing.Point(6, 86);
            this.dtgvendas.Name = "dtgvendas";
            this.dtgvendas.Size = new System.Drawing.Size(749, 330);
            this.dtgvendas.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.txtpesquisar);
            this.panel1.Controls.Add(this.rdbdata);
            this.panel1.Controls.Add(this.rdbfuncionario);
            this.panel1.Controls.Add(this.rdbcliente);
            this.panel1.Controls.Add(this.rdbvenda);
            this.panel1.Controls.Add(this.rdbtodos);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(622, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(370, 22);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(223, 20);
            this.txtpesquisar.TabIndex = 5;
            // 
            // rdbdata
            // 
            this.rdbdata.AutoSize = true;
            this.rdbdata.Location = new System.Drawing.Point(305, 22);
            this.rdbdata.Name = "rdbdata";
            this.rdbdata.Size = new System.Drawing.Size(48, 17);
            this.rdbdata.TabIndex = 4;
            this.rdbdata.Text = "Data";
            this.rdbdata.UseVisualStyleBackColor = true;
            // 
            // rdbfuncionario
            // 
            this.rdbfuncionario.AutoSize = true;
            this.rdbfuncionario.Location = new System.Drawing.Point(214, 22);
            this.rdbfuncionario.Name = "rdbfuncionario";
            this.rdbfuncionario.Size = new System.Drawing.Size(80, 17);
            this.rdbfuncionario.TabIndex = 3;
            this.rdbfuncionario.Text = "Funcionario";
            this.rdbfuncionario.UseVisualStyleBackColor = true;
            // 
            // rdbcliente
            // 
            this.rdbcliente.AutoSize = true;
            this.rdbcliente.Location = new System.Drawing.Point(146, 22);
            this.rdbcliente.Name = "rdbcliente";
            this.rdbcliente.Size = new System.Drawing.Size(57, 17);
            this.rdbcliente.TabIndex = 2;
            this.rdbcliente.Text = "Cliente";
            this.rdbcliente.UseVisualStyleBackColor = true;
            // 
            // rdbvenda
            // 
            this.rdbvenda.AutoSize = true;
            this.rdbvenda.Location = new System.Drawing.Point(79, 22);
            this.rdbvenda.Name = "rdbvenda";
            this.rdbvenda.Size = new System.Drawing.Size(56, 17);
            this.rdbvenda.TabIndex = 1;
            this.rdbvenda.Text = "Venda";
            this.rdbvenda.UseVisualStyleBackColor = true;
            // 
            // rdbtodos
            // 
            this.rdbtodos.AutoSize = true;
            this.rdbtodos.Checked = true;
            this.rdbtodos.Location = new System.Drawing.Point(13, 22);
            this.rdbtodos.Name = "rdbtodos";
            this.rdbtodos.Size = new System.Drawing.Size(55, 17);
            this.rdbtodos.TabIndex = 0;
            this.rdbtodos.TabStop = true;
            this.rdbtodos.Text = "Todos";
            this.rdbtodos.UseVisualStyleBackColor = true;
            // 
            // frmvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmvendas";
            this.Text = "frmvendas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlitens.ResumeLayout(false);
            this.pnlitens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            this.pnlvenda.ResumeLayout(false);
            this.pnlvenda.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvendas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlitens;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.TextBox txtval_tot;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.TextBox txtval_unit;
        private System.Windows.Forms.ComboBox cbxproduto;
        private System.Windows.Forms.Label lblvaltot;
        private System.Windows.Forms.Label lblqtd;
        private System.Windows.Forms.Label lblvalunit;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.Panel pnlvenda;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtTotVenda;
        private System.Windows.Forms.ComboBox cbxfuncionario;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblfuncionario;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.ComboBox cbxcliente;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvendas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.RadioButton rdbdata;
        private System.Windows.Forms.RadioButton rdbfuncionario;
        private System.Windows.Forms.RadioButton rdbcliente;
        private System.Windows.Forms.RadioButton rdbvenda;
        private System.Windows.Forms.RadioButton rdbtodos;
    }
}