namespace Venda_EduardoVinicius
{
    partial class frmfuncionarios
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
            this.tbcFuncionario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtconfsenha = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblnascimento = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalavar = new System.Windows.Forms.Button();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.gpbConsultar = new System.Windows.Forms.GroupBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.rdbusuario = new System.Windows.Forms.RadioButton();
            this.rdbcpf = new System.Windows.Forms.RadioButton();
            this.rdbNome = new System.Windows.Forms.RadioButton();
            this.pnlbotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tbcFuncionario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            this.gpbConsultar.SuspendLayout();
            this.pnlbotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcFuncionario
            // 
            this.tbcFuncionario.Controls.Add(this.tabPage1);
            this.tbcFuncionario.Controls.Add(this.tabPage2);
            this.tbcFuncionario.Location = new System.Drawing.Point(12, 12);
            this.tbcFuncionario.Name = "tbcFuncionario";
            this.tbcFuncionario.SelectedIndex = 0;
            this.tbcFuncionario.Size = new System.Drawing.Size(531, 315);
            this.tbcFuncionario.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtsenha);
            this.tabPage1.Controls.Add(this.txtconfsenha);
            this.tabPage1.Controls.Add(this.txtlogin);
            this.tabPage1.Controls.Add(this.lblConfirmarSenha);
            this.tabPage1.Controls.Add(this.lblSenha);
            this.tabPage1.Controls.Add(this.lblUsuario);
            this.tabPage1.Controls.Add(this.dtpNascimento);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.lblemail);
            this.tabPage1.Controls.Add(this.lblnascimento);
            this.tabPage1.Controls.Add(this.txtcpf);
            this.tabPage1.Controls.Add(this.lblcpf);
            this.tabPage1.Controls.Add(this.cbxEstado);
            this.tabPage1.Controls.Add(this.lblEstado);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnSalavar);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.lblEndereco);
            this.tabPage1.Controls.Add(this.lblCidade);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(287, 215);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '•';
            this.txtsenha.Size = new System.Drawing.Size(65, 20);
            this.txtsenha.TabIndex = 9;
            // 
            // txtconfsenha
            // 
            this.txtconfsenha.Location = new System.Drawing.Point(434, 215);
            this.txtconfsenha.Name = "txtconfsenha";
            this.txtconfsenha.PasswordChar = '•';
            this.txtconfsenha.Size = new System.Drawing.Size(75, 20);
            this.txtconfsenha.TabIndex = 10;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(89, 215);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(152, 20);
            this.txtlogin.TabIndex = 8;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(350, 215);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(89, 13);
            this.lblConfirmarSenha.TabIndex = 24;
            this.lblConfirmarSenha.Text = "Confirmar Senha*";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(243, 215);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 13);
            this.lblSenha.TabIndex = 23;
            this.lblSenha.Text = "Senha*";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(41, 215);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 22;
            this.lblUsuario.Text = "Usuário";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(89, 167);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(152, 20);
            this.dtpNascimento.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(293, 167);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(216, 20);
            this.txtemail.TabIndex = 7;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(249, 167);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 19;
            this.lblemail.Text = "Email";
            // 
            // lblnascimento
            // 
            this.lblnascimento.AutoSize = true;
            this.lblnascimento.Location = new System.Drawing.Point(4, 167);
            this.lblnascimento.Name = "lblnascimento";
            this.lblnascimento.Size = new System.Drawing.Size(80, 13);
            this.lblnascimento.TabIndex = 18;
            this.lblnascimento.Text = "Dt. Nascimento";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(89, 20);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(102, 20);
            this.txtcpf.TabIndex = 0;
            this.txtcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(57, 20);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(31, 13);
            this.lblcpf.TabIndex = 16;
            this.lblcpf.Text = "CPF*";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxEstado.Location = new System.Drawing.Point(293, 117);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(57, 21);
            this.cbxEstado.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(249, 124);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(434, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalavar
            // 
            this.btnSalavar.Location = new System.Drawing.Point(288, 259);
            this.btnSalavar.Name = "btnSalavar";
            this.btnSalavar.Size = new System.Drawing.Size(75, 23);
            this.btnSalavar.TabIndex = 11;
            this.btnSalavar.Text = "Salvar";
            this.btnSalavar.UseVisualStyleBackColor = true;
            this.btnSalavar.Click += new System.EventHandler(this.btnSalavar_Click);
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(404, 117);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(105, 20);
            this.txttelefone.TabIndex = 5;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(89, 117);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(152, 20);
            this.txtcidade.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(89, 65);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(420, 20);
            this.txtEndereco.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(241, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(31, 72);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(44, 124);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(197, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtglistar);
            this.tabPage2.Controls.Add(this.gpbConsultar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consuta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(6, 70);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(503, 184);
            this.dtglistar.TabIndex = 1;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistar_CellContentClick);
            // 
            // gpbConsultar
            // 
            this.gpbConsultar.Controls.Add(this.rdbTodos);
            this.gpbConsultar.Controls.Add(this.btnpesquisar);
            this.gpbConsultar.Controls.Add(this.txtPesquisa);
            this.gpbConsultar.Controls.Add(this.rdbusuario);
            this.gpbConsultar.Controls.Add(this.rdbcpf);
            this.gpbConsultar.Controls.Add(this.rdbNome);
            this.gpbConsultar.Location = new System.Drawing.Point(6, 6);
            this.gpbConsultar.Name = "gpbConsultar";
            this.gpbConsultar.Size = new System.Drawing.Size(503, 58);
            this.gpbConsultar.TabIndex = 0;
            this.gpbConsultar.TabStop = false;
            this.gpbConsultar.Text = "Consultar Por";
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(6, 24);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 5;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(412, 24);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnpesquisar.TabIndex = 4;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(246, 24);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(159, 20);
            this.txtPesquisa.TabIndex = 3;
            // 
            // rdbusuario
            // 
            this.rdbusuario.AutoSize = true;
            this.rdbusuario.Location = new System.Drawing.Point(168, 24);
            this.rdbusuario.Name = "rdbusuario";
            this.rdbusuario.Size = new System.Drawing.Size(61, 17);
            this.rdbusuario.TabIndex = 2;
            this.rdbusuario.Text = "Usuário";
            this.rdbusuario.UseVisualStyleBackColor = true;
            // 
            // rdbcpf
            // 
            this.rdbcpf.AutoSize = true;
            this.rdbcpf.Location = new System.Drawing.Point(120, 24);
            this.rdbcpf.Name = "rdbcpf";
            this.rdbcpf.Size = new System.Drawing.Size(45, 17);
            this.rdbcpf.TabIndex = 1;
            this.rdbcpf.Text = "CPF";
            this.rdbcpf.UseVisualStyleBackColor = true;
            // 
            // rdbNome
            // 
            this.rdbNome.AutoSize = true;
            this.rdbNome.Location = new System.Drawing.Point(64, 24);
            this.rdbNome.Name = "rdbNome";
            this.rdbNome.Size = new System.Drawing.Size(53, 17);
            this.rdbNome.TabIndex = 0;
            this.rdbNome.Text = "Nome";
            this.rdbNome.UseVisualStyleBackColor = true;
            // 
            // pnlbotoes
            // 
            this.pnlbotoes.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlbotoes.Controls.Add(this.btnFechar);
            this.pnlbotoes.Controls.Add(this.btnExcluir);
            this.pnlbotoes.Controls.Add(this.btnAlterar);
            this.pnlbotoes.Controls.Add(this.btnNovo);
            this.pnlbotoes.Location = new System.Drawing.Point(12, 333);
            this.pnlbotoes.Name = "pnlbotoes";
            this.pnlbotoes.Size = new System.Drawing.Size(527, 55);
            this.pnlbotoes.TabIndex = 4;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(433, 18);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(295, 18);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(157, 18);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(19, 18);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmfuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 399);
            this.Controls.Add(this.pnlbotoes);
            this.Controls.Add(this.tbcFuncionario);
            this.Name = "frmfuncionarios";
            this.Text = "frmfuncionarios";
            this.tbcFuncionario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            this.gpbConsultar.ResumeLayout(false);
            this.gpbConsultar.PerformLayout();
            this.pnlbotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcFuncionario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtconfsenha;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblnascimento;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalavar;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.GroupBox gpbConsultar;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rdbusuario;
        private System.Windows.Forms.RadioButton rdbcpf;
        private System.Windows.Forms.RadioButton rdbNome;
        private System.Windows.Forms.Panel pnlbotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
    }
}