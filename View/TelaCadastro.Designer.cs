namespace CadastroPessoas
{
    partial class TelaCadastro
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.txtbCPF = new System.Windows.Forms.TextBox();
            this.txtbTelefone = new System.Windows.Forms.TextBox();
            this.txtbSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbConfSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(329, 374);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(154, 43);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefone";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(134, 83);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(261, 23);
            this.txtbNome.TabIndex = 5;
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(134, 203);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(266, 23);
            this.txtbEmail.TabIndex = 7;
            // 
            // txtbCPF
            // 
            this.txtbCPF.Location = new System.Drawing.Point(134, 142);
            this.txtbCPF.Name = "txtbCPF";
            this.txtbCPF.Size = new System.Drawing.Size(116, 23);
            this.txtbCPF.TabIndex = 6;
            // 
            // txtbTelefone
            // 
            this.txtbTelefone.Location = new System.Drawing.Point(278, 142);
            this.txtbTelefone.Name = "txtbTelefone";
            this.txtbTelefone.Size = new System.Drawing.Size(122, 23);
            this.txtbTelefone.TabIndex = 8;
            // 
            // txtbSenha
            // 
            this.txtbSenha.Location = new System.Drawing.Point(134, 301);
            this.txtbSenha.Name = "txtbSenha";
            this.txtbSenha.PasswordChar = '*';
            this.txtbSenha.Size = new System.Drawing.Size(122, 23);
            this.txtbSenha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirmar Senha";
            // 
            // txtbConfSenha
            // 
            this.txtbConfSenha.Location = new System.Drawing.Point(278, 303);
            this.txtbConfSenha.Name = "txtbConfSenha";
            this.txtbConfSenha.PasswordChar = '*';
            this.txtbConfSenha.Size = new System.Drawing.Size(122, 23);
            this.txtbConfSenha.TabIndex = 12;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 455);
            this.Controls.Add(this.txtbConfSenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbSenha);
            this.Controls.Add(this.txtbTelefone);
            this.Controls.Add(this.txtbCPF);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtbNome;
        private TextBox txtbEmail;
        private TextBox txtbCPF;
        private TextBox txtbTelefone;
        private TextBox txtbSenha;
        private Label label5;
        private Label label6;
        private TextBox txtbConfSenha;
    }
}