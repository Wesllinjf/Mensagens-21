namespace MensageiroIF.Cliente
{
    partial class FormCadastro
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
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtNome);
            this.grpDados.Controls.Add(this.lblNome);
            this.grpDados.Controls.Add(this.lblApelido);
            this.grpDados.Controls.Add(this.txtApelido);
            this.grpDados.Location = new System.Drawing.Point(79, 26);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(591, 189);
            this.grpDados.TabIndex = 0;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados do usuário";
            this.grpDados.Enter += new System.EventHandler(this.grpDados_Enter);
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(20, 27);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(48, 13);
            this.lblApelido.TabIndex = 1;
            this.lblApelido.Text = "Apelido: ";
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(23, 58);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(532, 20);
            this.txtApelido.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 108);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome completo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 142);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(532, 20);
            this.txtNome.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(313, 221);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 45);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(79, 283);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(591, 238);
            this.lstUsuarios.TabIndex = 2;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 616);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.grpDados);
            this.Name = "FormCadastro";
            this.Text = "Mensageiro IF — Cadastro";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListBox lstUsuarios;
    }
}

