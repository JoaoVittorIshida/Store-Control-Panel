namespace Controle_de_Estoque
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label_TituloMenu = new Label();
            Btn_VEstoque = new Button();
            Btn_MovimentarEstoque = new Button();
            Btn_AProdutos = new Button();
            Label_BemVindo = new Label();
            Btn_Sair = new Button();
            SuspendLayout();
            // 
            // Label_TituloMenu
            // 
            Label_TituloMenu.AutoSize = true;
            Label_TituloMenu.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_TituloMenu.Location = new Point(298, 51);
            Label_TituloMenu.Name = "Label_TituloMenu";
            Label_TituloMenu.Size = new Size(565, 65);
            Label_TituloMenu.TabIndex = 0;
            Label_TituloMenu.Text = "Gerenciador de estoque";
            // 
            // Btn_VEstoque
            // 
            Btn_VEstoque.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_VEstoque.Location = new Point(426, 169);
            Btn_VEstoque.Name = "Btn_VEstoque";
            Btn_VEstoque.Size = new Size(298, 86);
            Btn_VEstoque.TabIndex = 1;
            Btn_VEstoque.Text = "Visualizar estoque";
            Btn_VEstoque.UseVisualStyleBackColor = true;
            Btn_VEstoque.Click += Btn_VEstoque_Click;
            // 
            // Btn_MovimentarEstoque
            // 
            Btn_MovimentarEstoque.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_MovimentarEstoque.Location = new Point(426, 323);
            Btn_MovimentarEstoque.Name = "Btn_MovimentarEstoque";
            Btn_MovimentarEstoque.Size = new Size(298, 84);
            Btn_MovimentarEstoque.TabIndex = 2;
            Btn_MovimentarEstoque.Text = "Movimentar estoque";
            Btn_MovimentarEstoque.UseVisualStyleBackColor = true;
            Btn_MovimentarEstoque.Click += Btn_MovimentarEstoque_Click;
            // 
            // Btn_AProdutos
            // 
            Btn_AProdutos.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_AProdutos.Location = new Point(426, 469);
            Btn_AProdutos.Name = "Btn_AProdutos";
            Btn_AProdutos.Size = new Size(298, 87);
            Btn_AProdutos.TabIndex = 3;
            Btn_AProdutos.Text = "Alterar produtos";
            Btn_AProdutos.UseVisualStyleBackColor = true;
            Btn_AProdutos.Click += Btn_AProdutos_Click;
            // 
            // Label_BemVindo
            // 
            Label_BemVindo.AutoSize = true;
            Label_BemVindo.Location = new Point(63, 35);
            Label_BemVindo.Name = "Label_BemVindo";
            Label_BemVindo.Size = new Size(120, 15);
            Label_BemVindo.TabIndex = 4;
            Label_BemVindo.Text = "Bem vindo(a) usuário";
            // 
            // Btn_Sair
            // 
            Btn_Sair.Location = new Point(1045, 690);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(75, 23);
            Btn_Sair.TabIndex = 4;
            Btn_Sair.Text = "Sair";
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 725);
            Controls.Add(Btn_Sair);
            Controls.Add(Label_BemVindo);
            Controls.Add(Btn_AProdutos);
            Controls.Add(Btn_MovimentarEstoque);
            Controls.Add(Btn_VEstoque);
            Controls.Add(Label_TituloMenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MenuPrincipal";
            Text = "Controle de estoque";
            Load += ControleEstoque_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_TituloMenu;
        private Button Btn_VEstoque;
        private Button Btn_MovimentarEstoque;
        private Button Btn_AProdutos;
        private Label Label_BemVindo;
        private Button Btn_Sair;
    }
}
