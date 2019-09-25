namespace Venda_EduardoVinicius
{
    partial class frmCliente
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
            this.tbcCliente = new System.Windows.Forms.TabControl();
            this.Cadastro = new System.Windows.Forms.TabPage();
            this.gbxCadastroC = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.msktelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lbnendereço = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.Consulta = new System.Windows.Forms.TabPage();
            this.dtglistar = new System.Windows.Forms.DataGridView();
            this.gbxConsulta = new System.Windows.Forms.GroupBox();
            this.btnprocurar = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.rbtncidade = new System.Windows.Forms.RadioButton();
            this.rbtnendereco = new System.Windows.Forms.RadioButton();
            this.rbtnnome = new System.Windows.Forms.RadioButton();
            this.rbtntodos = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.tbcCliente.SuspendLayout();
            this.Cadastro.SuspendLayout();
            this.gbxCadastroC.SuspendLayout();
            this.Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).BeginInit();
            this.gbxConsulta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCliente
            // 
            this.tbcCliente.Controls.Add(this.Cadastro);
            this.tbcCliente.Controls.Add(this.Consulta);
            this.tbcCliente.Location = new System.Drawing.Point(0, 3);
            this.tbcCliente.Name = "tbcCliente";
            this.tbcCliente.SelectedIndex = 0;
            this.tbcCliente.Size = new System.Drawing.Size(708, 262);
            this.tbcCliente.TabIndex = 0;
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.gbxCadastroC);
            this.Cadastro.Location = new System.Drawing.Point(4, 22);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastro.Size = new System.Drawing.Size(700, 236);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            // 
            // gbxCadastroC
            // 
            this.gbxCadastroC.Controls.Add(this.btncancelar);
            this.gbxCadastroC.Controls.Add(this.btnsalvar);
            this.gbxCadastroC.Controls.Add(this.cbxestado);
            this.gbxCadastroC.Controls.Add(this.msktelefone);
            this.gbxCadastroC.Controls.Add(this.txtcidade);
            this.gbxCadastroC.Controls.Add(this.txtendereco);
            this.gbxCadastroC.Controls.Add(this.txtnome);
            this.gbxCadastroC.Controls.Add(this.lbltelefone);
            this.gbxCadastroC.Controls.Add(this.lblestado);
            this.gbxCadastroC.Controls.Add(this.lblcidade);
            this.gbxCadastroC.Controls.Add(this.lbnendereço);
            this.gbxCadastroC.Controls.Add(this.lblnome);
            this.gbxCadastroC.Location = new System.Drawing.Point(9, 7);
            this.gbxCadastroC.Name = "gbxCadastroC";
            this.gbxCadastroC.Size = new System.Drawing.Size(688, 203);
            this.gbxCadastroC.TabIndex = 0;
            this.gbxCadastroC.TabStop = false;
            this.gbxCadastroC.Text = "Informações Clientes";
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(352, 163);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(191, 34);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(76, 163);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(191, 34);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // cbxestado
            // 
            this.cbxestado.FormattingEnabled = true;
            this.cbxestado.Location = new System.Drawing.Point(337, 111);
            this.cbxestado.Name = "cbxestado";
            this.cbxestado.Size = new System.Drawing.Size(121, 21);
            this.cbxestado.TabIndex = 10;
            // 
            // msktelefone
            // 
            this.msktelefone.Location = new System.Drawing.Point(407, 26);
            this.msktelefone.Name = "msktelefone";
            this.msktelefone.Size = new System.Drawing.Size(100, 20);
            this.msktelefone.TabIndex = 9;
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(67, 111);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(215, 20);
            this.txtcidade.TabIndex = 8;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(67, 62);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(264, 20);
            this.txtendereco.TabIndex = 7;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(67, 29);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(264, 20);
            this.txtnome.TabIndex = 6;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Location = new System.Drawing.Point(349, 29);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(52, 13);
            this.lbltelefone.TabIndex = 5;
            this.lbltelefone.Text = "Telefone:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(288, 114);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(43, 13);
            this.lblestado.TabIndex = 4;
            this.lblestado.Text = "Estado:";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(15, 114);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(46, 13);
            this.lblcidade.TabIndex = 2;
            this.lblcidade.Text = "Cidade: ";
            // 
            // lbnendereço
            // 
            this.lbnendereço.AutoSize = true;
            this.lbnendereço.Location = new System.Drawing.Point(5, 69);
            this.lbnendereço.Name = "lbnendereço";
            this.lbnendereço.Size = new System.Drawing.Size(56, 13);
            this.lbnendereço.TabIndex = 1;
            this.lbnendereço.Text = "Endereço:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(23, 36);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(38, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome:";
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.dtglistar);
            this.Consulta.Controls.Add(this.gbxConsulta);
            this.Consulta.Location = new System.Drawing.Point(4, 22);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta.Size = new System.Drawing.Size(700, 236);
            this.Consulta.TabIndex = 1;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            // 
            // dtglistar
            // 
            this.dtglistar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglistar.Location = new System.Drawing.Point(4, 58);
            this.dtglistar.Name = "dtglistar";
            this.dtglistar.Size = new System.Drawing.Size(693, 172);
            this.dtglistar.TabIndex = 1;
            this.dtglistar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbxConsulta
            // 
            this.gbxConsulta.Controls.Add(this.btnprocurar);
            this.gbxConsulta.Controls.Add(this.txtpesquisa);
            this.gbxConsulta.Controls.Add(this.rbtncidade);
            this.gbxConsulta.Controls.Add(this.rbtnendereco);
            this.gbxConsulta.Controls.Add(this.rbtnnome);
            this.gbxConsulta.Controls.Add(this.rbtntodos);
            this.gbxConsulta.Location = new System.Drawing.Point(4, 7);
            this.gbxConsulta.Name = "gbxConsulta";
            this.gbxConsulta.Size = new System.Drawing.Size(693, 45);
            this.gbxConsulta.TabIndex = 0;
            this.gbxConsulta.TabStop = false;
            this.gbxConsulta.Text = "Consulta Por";
            // 
            // btnprocurar
            // 
            this.btnprocurar.Location = new System.Drawing.Point(596, 16);
            this.btnprocurar.Name = "btnprocurar";
            this.btnprocurar.Size = new System.Drawing.Size(75, 23);
            this.btnprocurar.TabIndex = 5;
            this.btnprocurar.Text = "Procurar";
            this.btnprocurar.UseVisualStyleBackColor = true;
            this.btnprocurar.Click += new System.EventHandler(this.btnprocurar_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(293, 18);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(297, 20);
            this.txtpesquisa.TabIndex = 4;
            // 
            // rbtncidade
            // 
            this.rbtncidade.AutoSize = true;
            this.rbtncidade.Location = new System.Drawing.Point(204, 19);
            this.rbtncidade.Name = "rbtncidade";
            this.rbtncidade.Size = new System.Drawing.Size(58, 17);
            this.rbtncidade.TabIndex = 3;
            this.rbtncidade.TabStop = true;
            this.rbtncidade.Text = "Cidade";
            this.rbtncidade.UseVisualStyleBackColor = true;
            // 
            // rbtnendereco
            // 
            this.rbtnendereco.AutoSize = true;
            this.rbtnendereco.Location = new System.Drawing.Point(127, 19);
            this.rbtnendereco.Name = "rbtnendereco";
            this.rbtnendereco.Size = new System.Drawing.Size(71, 17);
            this.rbtnendereco.TabIndex = 2;
            this.rbtnendereco.TabStop = true;
            this.rbtnendereco.Text = "Endereço";
            this.rbtnendereco.UseVisualStyleBackColor = true;
            // 
            // rbtnnome
            // 
            this.rbtnnome.AutoSize = true;
            this.rbtnnome.Location = new System.Drawing.Point(68, 19);
            this.rbtnnome.Name = "rbtnnome";
            this.rbtnnome.Size = new System.Drawing.Size(53, 17);
            this.rbtnnome.TabIndex = 1;
            this.rbtnnome.TabStop = true;
            this.rbtnnome.Text = "Nome";
            this.rbtnnome.UseVisualStyleBackColor = true;
            // 
            // rbtntodos
            // 
            this.rbtntodos.AutoSize = true;
            this.rbtntodos.Location = new System.Drawing.Point(6, 19);
            this.rbtntodos.Name = "rbtntodos";
            this.rbtntodos.Size = new System.Drawing.Size(55, 17);
            this.rbtntodos.TabIndex = 0;
            this.rbtntodos.TabStop = true;
            this.rbtntodos.Text = "Todos";
            this.rbtntodos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnfechar);
            this.panel1.Controls.Add(this.btnexcluir);
            this.panel1.Controls.Add(this.btnalterar);
            this.panel1.Controls.Add(this.btnnovo);
            this.panel1.Location = new System.Drawing.Point(4, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 43);
            this.panel1.TabIndex = 1;
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(600, 10);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 23);
            this.btnfechar.TabIndex = 3;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(417, 10);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 2;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(201, 11);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 1;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(16, 11);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 23);
            this.btnnovo.TabIndex = 0;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbcCliente);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.tbcCliente.ResumeLayout(false);
            this.Cadastro.ResumeLayout(false);
            this.gbxCadastroC.ResumeLayout(false);
            this.gbxCadastroC.PerformLayout();
            this.Consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtglistar)).EndInit();
            this.gbxConsulta.ResumeLayout(false);
            this.gbxConsulta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCliente;
        private System.Windows.Forms.TabPage Cadastro;
        private System.Windows.Forms.GroupBox gbxCadastroC;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxestado;
        private System.Windows.Forms.MaskedTextBox msktelefone;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lbnendereço;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.GroupBox gbxConsulta;
        private System.Windows.Forms.RadioButton rbtntodos;
        private System.Windows.Forms.RadioButton rbtncidade;
        private System.Windows.Forms.RadioButton rbtnendereco;
        private System.Windows.Forms.RadioButton rbtnnome;
        private System.Windows.Forms.DataGridView dtglistar;
        private System.Windows.Forms.Button btnprocurar;
        private System.Windows.Forms.TextBox txtpesquisa;
    }
}