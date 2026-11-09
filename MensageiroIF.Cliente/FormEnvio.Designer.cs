namespace MensageiroIF.Cliente
{
    partial class FormEnvio
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.cboDestinatario = new System.Windows.Forms.ComboBox();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lstHistorico = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(111, 146);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(412, 90);
            this.txtMensagem.TabIndex = 0;
            // 
            // cboDestinatario
            // 
            this.cboDestinatario.FormattingEnabled = true;
            this.cboDestinatario.Location = new System.Drawing.Point(543, 146);
            this.cboDestinatario.Name = "cboDestinatario";
            this.cboDestinatario.Size = new System.Drawing.Size(121, 21);
            this.cboDestinatario.TabIndex = 1;
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(600, 256);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(64, 17);
            this.chkUrgente.TabIndex = 2;
            this.chkUrgente.Text = "Urgente";
            this.chkUrgente.UseVisualStyleBackColor = true;
            this.chkUrgente.CheckedChanged += new System.EventHandler(this.chkUrgente_CheckedChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(543, 183);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(121, 53);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.Location = new System.Drawing.Point(111, 279);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(553, 238);
            this.lstHistorico.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contato x";
            // 
            // FormEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 616);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHistorico);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.chkUrgente);
            this.Controls.Add(this.cboDestinatario);
            this.Controls.Add(this.txtMensagem);
            this.Name = "FormEnvio";
            this.Text = "Mensageiro IF — Envio";
            this.Load += new System.EventHandler(this.FormEnvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.ComboBox cboDestinatario;
        private System.Windows.Forms.CheckBox chkUrgente;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lstHistorico;
        private System.Windows.Forms.Label label1;
    }
}