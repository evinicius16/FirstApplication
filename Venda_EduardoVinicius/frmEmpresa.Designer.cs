namespace Venda_EduardoVinicius
{
    partial class frnEmpresa
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
            this.tbcCadastro = new System.Windows.Forms.TabControl();
            this.Cadastro = new System.Windows.Forms.TabPage();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.gbpinformacoes = new System.Windows.Forms.GroupBox();
            this.txtsite = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cbxuf = new System.Windows.Forms.ComboBox();
            this.lbluf = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblsite = new System.Windows.Forms.Label();
            this.msktelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.Consulta = new System.Windows.Forms.TabPage();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.gpbpesquisa = new System.Windows.Forms.GroupBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.rdbcidade = new System.Windows.Forms.RadioButton();
            this.rdbendereco = new System.Windows.Forms.RadioButton();
            this.rdbnome = new System.Windows.Forms.RadioButton();
            this.pnlbotoes = new System.Windows.Forms.Panel();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.tbcCadastro.SuspendLayout();
            this.Cadastro.SuspendLayout();
            this.gbpinformacoes.SuspendLayout();
            this.Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            this.gpbpesquisa.SuspendLayout();
            this.pnlbotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCadastro
            // 
            this.tbcCadastro.Controls.Add(this.Cadastro);
            this.tbcCadastro.Controls.Add(this.Consulta);
            this.tbcCadastro.Location = new System.Drawing.Point(13, 13);
            this.tbcCadastro.Name = "tbcCadastro";
            this.tbcCadastro.SelectedIndex = 0;
            this.tbcCadastro.Size = new System.Drawing.Size(624, 240);
            this.tbcCadastro.TabIndex = 0;
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.btncancelar);
            this.Cadastro.Controls.Add(this.btnsalvar);
            this.Cadastro.Controls.Add(this.gbpinformacoes);
            this.Cadastro.Location = new System.Drawing.Point(4, 22);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastro.Size = new System.Drawing.Size(616, 214);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(324, 161);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(191, 35);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(71, 161);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(191, 35);
            this.btnsalvar.TabIndex = 9;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // gbpinformacoes
            // 
            this.gbpinformacoes.Controls.Add(this.txtsite);
            this.gbpinformacoes.Controls.Add(this.txtemail);
            this.gbpinformacoes.Controls.Add(this.cbxuf);
            this.gbpinformacoes.Controls.Add(this.lbluf);
            this.gbpinformacoes.Controls.Add(this.txtcidade);
            this.gbpinformacoes.Controls.Add(this.txtendereco);
            this.gbpinformacoes.Controls.Add(this.txtnome);
            this.gbpinformacoes.Controls.Add(this.lblsite);
            this.gbpinformacoes.Controls.Add(this.msktelefone);
            this.gbpinformacoes.Controls.Add(this.lblemail);
            this.gbpinformacoes.Controls.Add(this.lbltelefone);
            this.gbpinformacoes.Controls.Add(this.lblcidade);
            this.gbpinformacoes.Controls.Add(this.lblnome);
            this.gbpinformacoes.Controls.Add(this.lblendereco);
            this.gbpinformacoes.Location = new System.Drawing.Point(3, 6);
            this.gbpinformacoes.Name = "gbpinformacoes";
            this.gbpinformacoes.Size = new System.Drawing.Size(607, 137);
            this.gbpinformacoes.TabIndex = 8;
            this.gbpinformacoes.TabStop = false;
            this.gbpinformacoes.Text = "Informações";
            // 
            // txtsite
            // 
            this.txtsite.Location = new System.Drawing.Point(353, 102);
            this.txtsite.Name = "txtsite";
            this.txtsite.Size = new System.Drawing.Size(248, 20);
            this.txtsite.TabIndex = 13;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(50, 102);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(262, 20);
            this.txtemail.TabIndex = 12;
            // 
            // cbxuf
            // 
            this.cbxuf.FormattingEnabled = true;
            this.cbxuf.Location = new System.Drawing.Point(480, 56);
            this.cbxuf.Name = "cbxuf";
            this.cbxuf.Size = new System.Drawing.Size(121, 21);
            this.cbxuf.TabIndex = 11;
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(450, 59);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(24, 13);
            this.lbluf.TabIndex = 10;
            this.lbluf.Text = "UF:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(340, 56);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(104, 20);
            this.txtcidade.TabIndex = 9;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(68, 56);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(225, 20);
            this.txtendereco.TabIndex = 8;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(50, 19);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(359, 20);
            this.txtnome.TabIndex = 6;
            // 
            // lblsite
            // 
            this.lblsite.AutoSize = true;
            this.lblsite.Location = new System.Drawing.Point(318, 105);
            this.lblsite.Name = "lblsite";
            this.lblsite.Size = new System.Drawing.Size(28, 13);
            this.lblsite.TabIndex = 5;
            this.lblsite.Text = "Site:";
            // 
            // msktelefone
            // 
            this.msktelefone.Location = new System.Drawing.Point(473, 19);
            this.msktelefone.Mask = "(00) 0000-0000";
            this.msktelefone.Name = "msktelefone";
            this.msktelefone.Size = new System.Drawing.Size(93, 20);
            this.msktelefone.TabIndex = 7;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(11, 105);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(38, 13);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "E-mail:";
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Location = new System.Drawing.Point(415, 24);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(52, 13);
            this.lbltelefone.TabIndex = 3;
            this.lbltelefone.Text = "Telefone:";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(299, 59);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(43, 13);
            this.lblcidade.TabIndex = 2;
            this.lblcidade.Text = "Cidade:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(6, 24);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(6, 59);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(56, 13);
            this.lblendereco.TabIndex = 1;
            this.lblendereco.Text = "Endereço:";
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.dtglistar);
            this.Consulta.Controls.Add(this.gpbpesquisa);
            this.Consulta.Location = new System.Drawing.Point(4, 22);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta.Size = new System.Drawing.Size(616, 214);
            this.Consulta.TabIndex = 1;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(7, 60);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(603, 150);
            this.dtglistar.TabIndex = 1;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsultaE_CellContentClick);
            // 
            // gpbpesquisa
            // 
            this.gpbpesquisa.Controls.Add(this.btnpesquisar);
            this.gpbpesquisa.Controls.Add(this.txtPesquisar);
            this.gpbpesquisa.Controls.Add(this.rdbcidade);
            this.gpbpesquisa.Controls.Add(this.rdbendereco);
            this.gpbpesquisa.Controls.Add(this.rdbnome);
            this.gpbpesquisa.Location = new System.Drawing.Point(7, 7);
            this.gpbpesquisa.Name = "gpbpesquisa";
            this.gpbpesquisa.Size = new System.Drawing.Size(603, 46);
            this.gpbpesquisa.TabIndex = 0;
            this.gpbpesquisa.TabStop = false;
            this.gpbpesquisa.Text = "Consultar Por";
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(509, 15);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisar.TabIndex = 4;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(207, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(296, 20);
            this.txtPesquisar.TabIndex = 3;
            // 
            // rdbcidade
            // 
            this.rdbcidade.AutoSize = true;
            this.rdbcidade.Location = new System.Drawing.Point(143, 20);
            this.rdbcidade.Name = "rdbcidade";
            this.rdbcidade.Size = new System.Drawing.Size(58, 17);
            this.rdbcidade.TabIndex = 2;
            this.rdbcidade.TabStop = true;
            this.rdbcidade.Text = "Cidade";
            this.rdbcidade.UseVisualStyleBackColor = true;
            // 
            // rdbendereco
            // 
            this.rdbendereco.AutoSize = true;
            this.rdbendereco.Location = new System.Drawing.Point(66, 19);
            this.rdbendereco.Name = "rdbendereco";
            this.rdbendereco.Size = new System.Drawing.Size(71, 17);
            this.rdbendereco.TabIndex = 1;
            this.rdbendereco.TabStop = true;
            this.rdbendereco.Text = "Endereço";
            this.rdbendereco.UseVisualStyleBackColor = true;
            // 
            // rdbnome
            // 
            this.rdbnome.AutoSize = true;
            this.rdbnome.Location = new System.Drawing.Point(7, 20);
            this.rdbnome.Name = "rdbnome";
            this.rdbnome.Size = new System.Drawing.Size(53, 17);
            this.rdbnome.TabIndex = 0;
            this.rdbnome.TabStop = true;
            this.rdbnome.Text = "Nome";
            this.rdbnome.UseVisualStyleBackColor = true;
            // 
            // pnlbotoes
            // 
            this.pnlbotoes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlbotoes.Controls.Add(this.btnfechar);
            this.pnlbotoes.Controls.Add(this.btnexcluir);
            this.pnlbotoes.Controls.Add(this.btnalterar);
            this.pnlbotoes.Controls.Add(this.btnnovo);
            this.pnlbotoes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlbotoes.Location = new System.Drawing.Point(17, 255);
            this.pnlbotoes.Name = "pnlbotoes";
            this.pnlbotoes.Size = new System.Drawing.Size(616, 43);
            this.pnlbotoes.TabIndex = 1;
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(478, 10);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(79, 23);
            this.btnfechar.TabIndex = 3;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(318, 10);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(79, 23);
            this.btnexcluir.TabIndex = 2;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(170, 9);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(79, 23);
            this.btnalterar.TabIndex = 1;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(17, 9);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(79, 23);
            this.btnnovo.TabIndex = 0;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // frnEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 307);
            this.Controls.Add(this.pnlbotoes);
            this.Controls.Add(this.tbcCadastro);
            this.Name = "frnEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de empresa";
            this.tbcCadastro.ResumeLayout(false);
            this.Cadastro.ResumeLayout(false);
            this.gbpinformacoes.ResumeLayout(false);
            this.gbpinformacoes.PerformLayout();
            this.Consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            this.gpbpesquisa.ResumeLayout(false);
            this.gpbpesquisa.PerformLayout();
            this.pnlbotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCadastro;
        private System.Windows.Forms.TabPage Cadastro;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.GroupBox gpbpesquisa;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.RadioButton rdbcidade;
        private System.Windows.Forms.RadioButton rdbendereco;
        private System.Windows.Forms.RadioButton rdbnome;
        private System.Windows.Forms.Panel pnlbotoes;
        private System.Windows.Forms.MaskedTextBox msktelefone;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblsite;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.GroupBox gbpinformacoes;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cbxuf;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtsite;
    }
}

