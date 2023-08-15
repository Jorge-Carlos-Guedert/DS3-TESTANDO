namespace Testando
{
    partial class FrmProduto
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
            this.Código = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.checkBoxPerecivel = new System.Windows.Forms.CheckBox();
            this.lblValidade = new System.Windows.Forms.Label();
            this.dateValidade = new System.Windows.Forms.DateTimePicker();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisarProduto = new System.Windows.Forms.TextBox();
            this.dtProduto = new System.Windows.Forms.DataGridView();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(68, 251);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(40, 13);
            this.Código.TabIndex = 9;
            this.Código.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(122, 244);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantidade";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(122, 296);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 1;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(122, 322);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(122, 270);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // checkBoxPerecivel
            // 
            this.checkBoxPerecivel.AutoSize = true;
            this.checkBoxPerecivel.Location = new System.Drawing.Point(122, 348);
            this.checkBoxPerecivel.Name = "checkBoxPerecivel";
            this.checkBoxPerecivel.Size = new System.Drawing.Size(112, 17);
            this.checkBoxPerecivel.TabIndex = 3;
            this.checkBoxPerecivel.Text = "Produto Perecível";
            this.checkBoxPerecivel.UseVisualStyleBackColor = true;
            this.checkBoxPerecivel.Click += new System.EventHandler(this.checkBoxPerecivel_Click);
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.Location = new System.Drawing.Point(68, 378);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(48, 13);
            this.lblValidade.TabIndex = 13;
            this.lblValidade.Text = "Validade";
            // 
            // dateValidade
            // 
            this.dateValidade.Location = new System.Drawing.Point(122, 371);
            this.dateValidade.Name = "dateValidade";
            this.dateValidade.Size = new System.Drawing.Size(200, 20);
            this.dateValidade.TabIndex = 4;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(122, 402);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(274, 402);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(110, 510);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // ptbFoto
            // 
            this.ptbFoto.Location = new System.Drawing.Point(564, 83);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(302, 207);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoto.TabIndex = 14;
            this.ptbFoto.TabStop = false;
            this.ptbFoto.Click += new System.EventHandler(this.ptbFoto_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(441, 274);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(35, 13);
            this.lblFoto.TabIndex = 14;
            this.lblFoto.Text = "label1";
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(652, 402);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 23);
            this.btnFoto.TabIndex = 5;
            this.btnFoto.Text = "Inserir Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 592);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnFoto);
            this.tabPage1.Controls.Add(this.ptbFoto);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.Código);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnInserir);
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.checkBoxPerecivel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPreco);
            this.tabPage1.Controls.Add(this.txtQuantidade);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblValidade);
            this.tabPage1.Controls.Add(this.dateValidade);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPesquisarProduto);
            this.tabPage2.Controls.Add(this.dtProduto);
            this.tabPage2.Controls.Add(this.txtPesquisarProduto);
            this.tabPage2.Controls.Add(this.lblPesquisar);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(256, 43);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 9;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisarProduto
            // 
            this.txtPesquisarProduto.Location = new System.Drawing.Point(315, 36);
            this.txtPesquisarProduto.Name = "txtPesquisarProduto";
            this.txtPesquisarProduto.Size = new System.Drawing.Size(229, 20);
            this.txtPesquisarProduto.TabIndex = 10;
            // 
            // dtProduto
            // 
            this.dtProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProduto.Location = new System.Drawing.Point(110, 62);
            this.dtProduto.Name = "dtProduto";
            this.dtProduto.Size = new System.Drawing.Size(754, 442);
            this.dtProduto.TabIndex = 11;
            this.dtProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProduto_CellClick);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Location = new System.Drawing.Point(565, 32);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarProduto.TabIndex = 12;
            this.btnPesquisarProduto.Text = "Pesquisar";
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 586);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblFoto);
            this.Name = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Código;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.CheckBox checkBoxPerecivel;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.DateTimePicker dateValidade;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtProduto;
        private System.Windows.Forms.TextBox txtPesquisarProduto;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnPesquisarProduto;
    }
}