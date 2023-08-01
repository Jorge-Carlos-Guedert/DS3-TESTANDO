namespace Testando
{
    partial class FrmUsuario
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.labId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtUsuario = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnListarUsuario = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.nomeCompleto = new System.Windows.Forms.Label();
            this.txtnomeCompleto = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.telContato = new System.Windows.Forms.Label();
            this.txtTelContato = new System.Windows.Forms.TextBox();
            this.whatsapp = new System.Windows.Forms.Label();
            this.txtwhatsapp = new System.Windows.Forms.TextBox();
            this.endereço = new System.Windows.Forms.Label();
            this.txtEndCompleto = new System.Windows.Forms.TextBox();
            this.ceb = new System.Windows.Forms.Label();
            this.txtCeb = new System.Windows.Forms.TextBox();
            this.cboxIguais = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.cBoxPerfil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(713, 12);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.button2_Click);
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(53, 66);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(19, 13);
            this.labId.TabIndex = 3;
            this.labId.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 66);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(53, 101);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome:";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(97, 101);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 6;
            this.txtnome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(53, 134);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(41, 13);
            this.Senha.TabIndex = 7;
            this.Senha.Text = "Senha:";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(97, 134);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 20);
            this.txtsenha.TabIndex = 8;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(489, 415);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtUsuario
            // 
            this.dtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUsuario.Location = new System.Drawing.Point(970, 545);
            this.dtUsuario.Name = "dtUsuario";
            this.dtUsuario.Size = new System.Drawing.Size(442, 264);
            this.dtUsuario.TabIndex = 10;
            this.dtUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUsuario_CellClick);
            this.dtUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(713, 415);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnListarUsuario
            // 
            this.btnListarUsuario.Location = new System.Drawing.Point(570, 415);
            this.btnListarUsuario.Name = "btnListarUsuario";
            this.btnListarUsuario.Size = new System.Drawing.Size(137, 23);
            this.btnListarUsuario.TabIndex = 12;
            this.btnListarUsuario.Text = "Listar Usuário";
            this.btnListarUsuario.UseVisualStyleBackColor = true;
            this.btnListarUsuario.Click += new System.EventHandler(this.btnListarUsuario_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(408, 415);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Atualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // nomeCompleto
            // 
            this.nomeCompleto.AutoSize = true;
            this.nomeCompleto.Location = new System.Drawing.Point(56, 166);
            this.nomeCompleto.Name = "nomeCompleto";
            this.nomeCompleto.Size = new System.Drawing.Size(82, 13);
            this.nomeCompleto.TabIndex = 14;
            this.nomeCompleto.Text = "Nome Completo";
            // 
            // txtnomeCompleto
            // 
            this.txtnomeCompleto.Location = new System.Drawing.Point(144, 159);
            this.txtnomeCompleto.Name = "txtnomeCompleto";
            this.txtnomeCompleto.Size = new System.Drawing.Size(230, 20);
            this.txtnomeCompleto.TabIndex = 15;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(56, 200);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 16;
            this.email.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(230, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // telContato
            // 
            this.telContato.AutoSize = true;
            this.telContato.Location = new System.Drawing.Point(56, 241);
            this.telContato.Name = "telContato";
            this.telContato.Size = new System.Drawing.Size(89, 13);
            this.telContato.TabIndex = 18;
            this.telContato.Text = "Telefone Contato";
            // 
            // txtTelContato
            // 
            this.txtTelContato.Location = new System.Drawing.Point(144, 234);
            this.txtTelContato.Name = "txtTelContato";
            this.txtTelContato.Size = new System.Drawing.Size(161, 20);
            this.txtTelContato.TabIndex = 19;
            // 
            // whatsapp
            // 
            this.whatsapp.AutoSize = true;
            this.whatsapp.Location = new System.Drawing.Point(56, 275);
            this.whatsapp.Name = "whatsapp";
            this.whatsapp.Size = new System.Drawing.Size(56, 13);
            this.whatsapp.TabIndex = 20;
            this.whatsapp.Text = "Whatsapp";
            // 
            // txtwhatsapp
            // 
            this.txtwhatsapp.Location = new System.Drawing.Point(144, 268);
            this.txtwhatsapp.Name = "txtwhatsapp";
            this.txtwhatsapp.Size = new System.Drawing.Size(161, 20);
            this.txtwhatsapp.TabIndex = 21;
            // 
            // endereço
            // 
            this.endereço.AutoSize = true;
            this.endereço.Location = new System.Drawing.Point(56, 320);
            this.endereço.Name = "endereço";
            this.endereço.Size = new System.Drawing.Size(100, 13);
            this.endereço.TabIndex = 22;
            this.endereço.Text = "Endereço Completo";
            // 
            // txtEndCompleto
            // 
            this.txtEndCompleto.Location = new System.Drawing.Point(161, 313);
            this.txtEndCompleto.Name = "txtEndCompleto";
            this.txtEndCompleto.Size = new System.Drawing.Size(213, 20);
            this.txtEndCompleto.TabIndex = 23;
            // 
            // ceb
            // 
            this.ceb.AutoSize = true;
            this.ceb.Location = new System.Drawing.Point(56, 385);
            this.ceb.Name = "ceb";
            this.ceb.Size = new System.Drawing.Size(34, 13);
            this.ceb.TabIndex = 24;
            this.ceb.Text = "CEB :";
            // 
            // txtCeb
            // 
            this.txtCeb.Location = new System.Drawing.Point(97, 378);
            this.txtCeb.Name = "txtCeb";
            this.txtCeb.Size = new System.Drawing.Size(161, 20);
            this.txtCeb.TabIndex = 25;
            this.txtCeb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboxIguais
            // 
            this.cboxIguais.AutoSize = true;
            this.cboxIguais.Location = new System.Drawing.Point(329, 270);
            this.cboxIguais.Name = "cboxIguais";
            this.cboxIguais.Size = new System.Drawing.Size(54, 17);
            this.cboxIguais.TabIndex = 26;
            this.cboxIguais.Text = "Iguais";
            this.cboxIguais.UseVisualStyleBackColor = true;
            this.cboxIguais.CheckedChanged += new System.EventHandler(this.cboxIguais_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "FUNÇÃO :";
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(119, 341);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(161, 20);
            this.txtFuncao.TabIndex = 28;
            // 
            // cBoxPerfil
            // 
            this.cBoxPerfil.FormattingEnabled = true;
            this.cBoxPerfil.Location = new System.Drawing.Point(408, 132);
            this.cBoxPerfil.Name = "cBoxPerfil";
            this.cBoxPerfil.Size = new System.Drawing.Size(121, 21);
            this.cBoxPerfil.TabIndex = 29;
            this.cBoxPerfil.SelectedIndexChanged += new System.EventHandler(this.cBoxPerfil_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Perfil";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxPerfil);
            this.Controls.Add(this.txtFuncao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxIguais);
            this.Controls.Add(this.txtCeb);
            this.Controls.Add(this.ceb);
            this.Controls.Add(this.txtEndCompleto);
            this.Controls.Add(this.endereço);
            this.Controls.Add(this.txtwhatsapp);
            this.Controls.Add(this.whatsapp);
            this.Controls.Add(this.txtTelContato);
            this.Controls.Add(this.telContato);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtnomeCompleto);
            this.Controls.Add(this.nomeCompleto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnListarUsuario);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dtUsuario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.btnConectar);
            this.Name = "FrmUsuario";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dtUsuario;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnListarUsuario;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label nomeCompleto;
        private System.Windows.Forms.TextBox txtnomeCompleto;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label telContato;
        private System.Windows.Forms.TextBox txtTelContato;
        private System.Windows.Forms.Label whatsapp;
        private System.Windows.Forms.TextBox txtwhatsapp;
        private System.Windows.Forms.Label endereço;
        private System.Windows.Forms.TextBox txtEndCompleto;
        private System.Windows.Forms.Label ceb;
        private System.Windows.Forms.TextBox txtCeb;
        private System.Windows.Forms.CheckBox cboxIguais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.ComboBox cBoxPerfil;
        private System.Windows.Forms.Label label2;
    }
}

