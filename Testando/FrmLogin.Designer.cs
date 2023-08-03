namespace Testando
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnCancelarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha :";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(348, 103);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioLogin.TabIndex = 2;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(348, 149);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaLogin.TabIndex = 3;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(214, 273);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 4;
            this.btnLogar.Text = "Login";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.Location = new System.Drawing.Point(484, 273);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarLogin.TabIndex = 5;
            this.btnCancelarLogin.Text = "Cancelar";
            this.btnCancelarLogin.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 321);
            this.Controls.Add(this.btnCancelarLogin);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnCancelarLogin;
    }
}