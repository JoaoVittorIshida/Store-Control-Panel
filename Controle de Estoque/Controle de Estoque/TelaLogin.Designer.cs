namespace Controle_de_Estoque
{
    partial class TelaLogin
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
            Label_TituloLogin = new Label();
            Label_TelaLogin = new Label();
            UsuarioLogin = new TextBox();
            SenhaLogin = new TextBox();
            Btn_Entrar = new Button();
            Btn_ExibirReg = new Button();
            Label_TelaReg = new Label();
            UsuarioReg = new TextBox();
            SenhaReg = new TextBox();
            ConfSenhaReg = new TextBox();
            Combo_RegAtrib = new ComboBox();
            CodChave = new TextBox();
            Btn_ConfRegistro = new Button();
            Btn_CancelReg = new Button();
            SuspendLayout();
            // 
            // Label_TituloLogin
            // 
            Label_TituloLogin.AutoSize = true;
            Label_TituloLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_TituloLogin.Location = new Point(178, 35);
            Label_TituloLogin.Name = "Label_TituloLogin";
            Label_TituloLogin.Size = new Size(209, 40);
            Label_TituloLogin.TabIndex = 0;
            Label_TituloLogin.Text = "Identifique-se";
            // 
            // Label_TelaLogin
            // 
            Label_TelaLogin.AutoSize = true;
            Label_TelaLogin.BackColor = Color.Transparent;
            Label_TelaLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_TelaLogin.Location = new Point(148, 124);
            Label_TelaLogin.Name = "Label_TelaLogin";
            Label_TelaLogin.Size = new Size(209, 189);
            Label_TelaLogin.TabIndex = 1;
            Label_TelaLogin.Text = "Usuário:\r\n\r\n  Senha:\r\n\r\n\r\n\r\n\r\n\r\n                   Não é registrado?";
            // 
            // UsuarioLogin
            // 
            UsuarioLogin.Location = new Point(216, 126);
            UsuarioLogin.Name = "UsuarioLogin";
            UsuarioLogin.Size = new Size(151, 23);
            UsuarioLogin.TabIndex = 2;
            // 
            // SenhaLogin
            // 
            SenhaLogin.Location = new Point(216, 169);
            SenhaLogin.Name = "SenhaLogin";
            SenhaLogin.PasswordChar = '*';
            SenhaLogin.Size = new Size(151, 23);
            SenhaLogin.TabIndex = 3;
            SenhaLogin.UseSystemPasswordChar = true;
            // 
            // Btn_Entrar
            // 
            Btn_Entrar.Location = new Point(250, 213);
            Btn_Entrar.Name = "Btn_Entrar";
            Btn_Entrar.Size = new Size(75, 23);
            Btn_Entrar.TabIndex = 4;
            Btn_Entrar.Text = "Entrar";
            Btn_Entrar.UseVisualStyleBackColor = true;
            Btn_Entrar.Click += Btn_Entrar_Click;
            // 
            // Btn_ExibirReg
            // 
            Btn_ExibirReg.Location = new Point(236, 336);
            Btn_ExibirReg.Name = "Btn_ExibirReg";
            Btn_ExibirReg.Size = new Size(98, 23);
            Btn_ExibirReg.TabIndex = 5;
            Btn_ExibirReg.Text = "Registrar-se";
            Btn_ExibirReg.UseVisualStyleBackColor = true;
            Btn_ExibirReg.Click += Btn_Registrarse_Click;
            // 
            // Label_TelaReg
            // 
            Label_TelaReg.AutoSize = true;
            Label_TelaReg.BackColor = Color.Transparent;
            Label_TelaReg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_TelaReg.Location = new Point(74, 124);
            Label_TelaReg.Name = "Label_TelaReg";
            Label_TelaReg.Size = new Size(136, 189);
            Label_TelaReg.TabIndex = 6;
            Label_TelaReg.Text = "                 Usuário:\r\n\r\n                    Senha:\r\n\r\nConfirme a senha:\r\n\r\n             Atribuição:\r\n\r\n       Código chave:";
            Label_TelaReg.Visible = false;
            // 
            // UsuarioReg
            // 
            UsuarioReg.Location = new Point(216, 126);
            UsuarioReg.Name = "UsuarioReg";
            UsuarioReg.Size = new Size(151, 23);
            UsuarioReg.TabIndex = 7;
            UsuarioReg.Visible = false;
            // 
            // SenhaReg
            // 
            SenhaReg.Location = new Point(216, 169);
            SenhaReg.Name = "SenhaReg";
            SenhaReg.PasswordChar = '*';
            SenhaReg.Size = new Size(151, 23);
            SenhaReg.TabIndex = 8;
            SenhaReg.UseSystemPasswordChar = true;
            SenhaReg.Visible = false;
            // 
            // ConfSenhaReg
            // 
            ConfSenhaReg.Location = new Point(216, 213);
            ConfSenhaReg.Name = "ConfSenhaReg";
            ConfSenhaReg.PasswordChar = '*';
            ConfSenhaReg.Size = new Size(151, 23);
            ConfSenhaReg.TabIndex = 9;
            ConfSenhaReg.UseSystemPasswordChar = true;
            ConfSenhaReg.Visible = false;
            // 
            // Combo_RegAtrib
            // 
            Combo_RegAtrib.DropDownStyle = ComboBoxStyle.DropDownList;
            Combo_RegAtrib.FormattingEnabled = true;
            Combo_RegAtrib.ImeMode = ImeMode.NoControl;
            Combo_RegAtrib.Items.AddRange(new object[] { "Vendedor", "Gerente", "Administrador" });
            Combo_RegAtrib.Location = new Point(216, 251);
            Combo_RegAtrib.Name = "Combo_RegAtrib";
            Combo_RegAtrib.Size = new Size(151, 23);
            Combo_RegAtrib.TabIndex = 10;
            Combo_RegAtrib.Visible = false;
            // 
            // CodChave
            // 
            CodChave.Location = new Point(216, 290);
            CodChave.MaxLength = 5;
            CodChave.Name = "CodChave";
            CodChave.PasswordChar = '*';
            CodChave.Size = new Size(151, 23);
            CodChave.TabIndex = 11;
            CodChave.UseSystemPasswordChar = true;
            CodChave.Visible = false;
            // 
            // Btn_ConfRegistro
            // 
            Btn_ConfRegistro.Location = new Point(236, 336);
            Btn_ConfRegistro.Name = "Btn_ConfRegistro";
            Btn_ConfRegistro.Size = new Size(98, 23);
            Btn_ConfRegistro.TabIndex = 12;
            Btn_ConfRegistro.Text = "Registrar-se";
            Btn_ConfRegistro.UseVisualStyleBackColor = true;
            Btn_ConfRegistro.Visible = false;
            Btn_ConfRegistro.Click += ConfRegistro_Click;
            // 
            // Btn_CancelReg
            // 
            Btn_CancelReg.Location = new Point(236, 365);
            Btn_CancelReg.Name = "Btn_CancelReg";
            Btn_CancelReg.Size = new Size(98, 23);
            Btn_CancelReg.TabIndex = 13;
            Btn_CancelReg.Text = "Cancelar";
            Btn_CancelReg.UseVisualStyleBackColor = true;
            Btn_CancelReg.Visible = false;
            Btn_CancelReg.Click += Btn_CancelReg_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 490);
            Controls.Add(Btn_CancelReg);
            Controls.Add(Btn_ConfRegistro);
            Controls.Add(CodChave);
            Controls.Add(Combo_RegAtrib);
            Controls.Add(ConfSenhaReg);
            Controls.Add(SenhaReg);
            Controls.Add(UsuarioReg);
            Controls.Add(Btn_ExibirReg);
            Controls.Add(Btn_Entrar);
            Controls.Add(SenhaLogin);
            Controls.Add(UsuarioLogin);
            Controls.Add(Label_TituloLogin);
            Controls.Add(Label_TelaReg);
            Controls.Add(Label_TelaLogin);
            Name = "TelaLogin";
            Text = "Identifique-se";
            Load += TelaLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_TituloLogin;
        private Label Label_TelaLogin;
        private TextBox UsuarioLogin;
        private TextBox SenhaLogin;
        private Button Btn_Entrar;
        private Button Btn_ExibirReg;
        private Label Label_TelaReg;
        private TextBox UsuarioReg;
        private TextBox SenhaReg;
        private TextBox ConfSenhaReg;
        private ComboBox Combo_RegAtrib;
        private TextBox CodChave;
        private Button Btn_ConfRegistro;
        private Button Btn_CancelReg;
    }
}