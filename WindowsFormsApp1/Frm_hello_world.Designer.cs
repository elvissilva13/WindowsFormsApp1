
namespace WindowsFormsApp1
{
    partial class Frm_hello_world
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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Btn_login = new System.Windows.Forms.Button();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.Lbl_Verificacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Britannic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Lbl_titulo.Location = new System.Drawing.Point(326, 97);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(108, 44);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "login";
            this.Lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(297, 164);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(160, 26);
            this.Txt_Email.TabIndex = 1;
            // 
            // Txt_senha
            // 
            this.Txt_senha.BackColor = System.Drawing.SystemColors.Control;
            this.Txt_senha.Location = new System.Drawing.Point(297, 209);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.Size = new System.Drawing.Size(160, 26);
            this.Txt_senha.TabIndex = 2;
            // 
            // Btn_login
            // 
            this.Btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_login.Location = new System.Drawing.Point(297, 252);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(160, 35);
            this.Btn_login.TabIndex = 3;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = false;
            this.Btn_login.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Btn_sair
            // 
            this.Btn_sair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_sair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_sair.Location = new System.Drawing.Point(562, 404);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(200, 34);
            this.Btn_sair.TabIndex = 4;
            this.Btn_sair.Text = "Sair da Aplicação";
            this.Btn_sair.UseVisualStyleBackColor = false;
            this.Btn_sair.Click += new System.EventHandler(this.Btn_sair_Click);
            // 
            // Lbl_Verificacao
            // 
            this.Lbl_Verificacao.AutoSize = true;
            this.Lbl_Verificacao.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Verificacao.ForeColor = System.Drawing.Color.White;
            this.Lbl_Verificacao.Location = new System.Drawing.Point(293, 354);
            this.Lbl_Verificacao.Name = "Lbl_Verificacao";
            this.Lbl_Verificacao.Size = new System.Drawing.Size(0, 39);
            this.Lbl_Verificacao.TabIndex = 5;
            // 
            // Frm_hello_world
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Verificacao);
            this.Controls.Add(this.Btn_sair);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "Frm_hello_world";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_senha;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.Label Lbl_Verificacao;
    }
}

