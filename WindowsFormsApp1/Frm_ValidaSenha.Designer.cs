
namespace WindowsFormsApp1
{
    partial class Frm_ValidaSenha
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
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_EscondeSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(12, 45);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(218, 26);
            this.Txt_Senha.TabIndex = 0;
            this.Txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyDown);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.Location = new System.Drawing.Point(12, 90);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 34);
            this.Lbl_Resultado.TabIndex = 1;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.Location = new System.Drawing.Point(236, 22);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(143, 36);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_EscondeSenha
            // 
            this.Btn_EscondeSenha.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_EscondeSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EscondeSenha.Location = new System.Drawing.Point(236, 64);
            this.Btn_EscondeSenha.Name = "Btn_EscondeSenha";
            this.Btn_EscondeSenha.Size = new System.Drawing.Size(143, 36);
            this.Btn_EscondeSenha.TabIndex = 3;
            this.Btn_EscondeSenha.Text = "Mostra senha";
            this.Btn_EscondeSenha.UseVisualStyleBackColor = false;
            this.Btn_EscondeSenha.Click += new System.EventHandler(this.Btn_EscondeSenha_Click);
            // 
            // Frm_ValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 212);
            this.Controls.Add(this.Btn_EscondeSenha);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Txt_Senha);
            this.Name = "Frm_ValidaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de Senhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_EscondeSenha;
    }
}