namespace Controle_de_Estoque
{
    partial class AlterarProdutos
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
            Label_AltProdutos = new Label();
            Btn_CriarProd = new Button();
            Btn_EditarProd = new Button();
            Box_AltProd = new GroupBox();
            Grid_PainelEstoque = new DataGridView();
            IdProduto = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            Btn_Cancelar = new Button();
            Btn_Confirmar = new Button();
            Label_Estoque = new Label();
            index_Estoque = new NumericUpDown();
            PrecoProduto = new TextBox();
            Label_PrecoProduto = new Label();
            Label_NomeProduto = new Label();
            index_CodProduto = new NumericUpDown();
            Label_CodProduto = new Label();
            NomeProduto = new TextBox();
            Btn_Voltar = new Button();
            Btn_ExcluirProd = new Button();
            Box_AltProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_PainelEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)index_Estoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)index_CodProduto).BeginInit();
            SuspendLayout();
            // 
            // Label_AltProdutos
            // 
            Label_AltProdutos.AutoSize = true;
            Label_AltProdutos.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_AltProdutos.Location = new Point(84, 65);
            Label_AltProdutos.Name = "Label_AltProdutos";
            Label_AltProdutos.Size = new Size(312, 50);
            Label_AltProdutos.TabIndex = 0;
            Label_AltProdutos.Text = "Alterar produtos";
            // 
            // Btn_CriarProd
            // 
            Btn_CriarProd.Location = new Point(522, 65);
            Btn_CriarProd.Name = "Btn_CriarProd";
            Btn_CriarProd.Size = new Size(112, 59);
            Btn_CriarProd.TabIndex = 1;
            Btn_CriarProd.Text = "Criar produto";
            Btn_CriarProd.UseVisualStyleBackColor = true;
            Btn_CriarProd.Click += Btn_CriarProd_Click;
            // 
            // Btn_EditarProd
            // 
            Btn_EditarProd.Location = new Point(669, 65);
            Btn_EditarProd.Name = "Btn_EditarProd";
            Btn_EditarProd.Size = new Size(112, 59);
            Btn_EditarProd.TabIndex = 2;
            Btn_EditarProd.Text = "Editar produto";
            Btn_EditarProd.UseVisualStyleBackColor = true;
            Btn_EditarProd.Click += Btn_EditarProd_Click;
            // 
            // Box_AltProd
            // 
            Box_AltProd.BackColor = SystemColors.AppWorkspace;
            Box_AltProd.Controls.Add(Grid_PainelEstoque);
            Box_AltProd.Controls.Add(Btn_Cancelar);
            Box_AltProd.Controls.Add(Btn_Confirmar);
            Box_AltProd.Controls.Add(Label_Estoque);
            Box_AltProd.Controls.Add(index_Estoque);
            Box_AltProd.Controls.Add(PrecoProduto);
            Box_AltProd.Controls.Add(Label_PrecoProduto);
            Box_AltProd.Controls.Add(Label_NomeProduto);
            Box_AltProd.Controls.Add(index_CodProduto);
            Box_AltProd.Controls.Add(Label_CodProduto);
            Box_AltProd.Controls.Add(NomeProduto);
            Box_AltProd.Location = new Point(84, 165);
            Box_AltProd.Name = "Box_AltProd";
            Box_AltProd.Size = new Size(973, 492);
            Box_AltProd.TabIndex = 3;
            Box_AltProd.TabStop = false;
            // 
            // Grid_PainelEstoque
            // 
            Grid_PainelEstoque.AllowUserToAddRows = false;
            Grid_PainelEstoque.AllowUserToDeleteRows = false;
            Grid_PainelEstoque.AllowUserToOrderColumns = true;
            Grid_PainelEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_PainelEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_PainelEstoque.Columns.AddRange(new DataGridViewColumn[] { IdProduto, Produto, Valor, Estoque });
            Grid_PainelEstoque.Location = new Point(0, 0);
            Grid_PainelEstoque.MultiSelect = false;
            Grid_PainelEstoque.Name = "Grid_PainelEstoque";
            Grid_PainelEstoque.ReadOnly = true;
            Grid_PainelEstoque.Size = new Size(973, 492);
            Grid_PainelEstoque.TabIndex = 5;
            // 
            // IdProduto
            // 
            IdProduto.HeaderText = "Id do Produto";
            IdProduto.Name = "IdProduto";
            IdProduto.ReadOnly = true;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            Produto.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Estoque
            // 
            Estoque.HeaderText = "Estoque";
            Estoque.Name = "Estoque";
            Estoque.ReadOnly = true;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Location = new Point(501, 343);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(103, 52);
            Btn_Cancelar.TabIndex = 11;
            Btn_Cancelar.Text = "-";
            Btn_Cancelar.UseVisualStyleBackColor = true;
            Btn_Cancelar.Visible = false;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // Btn_Confirmar
            // 
            Btn_Confirmar.Location = new Point(329, 343);
            Btn_Confirmar.Name = "Btn_Confirmar";
            Btn_Confirmar.Size = new Size(103, 52);
            Btn_Confirmar.TabIndex = 10;
            Btn_Confirmar.Text = "+";
            Btn_Confirmar.UseVisualStyleBackColor = true;
            Btn_Confirmar.Visible = false;
            Btn_Confirmar.Click += Btn_Confirmar_Click;
            // 
            // Label_Estoque
            // 
            Label_Estoque.AutoSize = true;
            Label_Estoque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Estoque.Location = new Point(364, 187);
            Label_Estoque.Name = "Label_Estoque";
            Label_Estoque.Size = new Size(68, 21);
            Label_Estoque.TabIndex = 7;
            Label_Estoque.Text = "Estoque:";
            // 
            // index_Estoque
            // 
            index_Estoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            index_Estoque.Location = new Point(438, 187);
            index_Estoque.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            index_Estoque.Name = "index_Estoque";
            index_Estoque.Size = new Size(51, 25);
            index_Estoque.TabIndex = 9;
            index_Estoque.TextAlign = HorizontalAlignment.Center;
            // 
            // PrecoProduto
            // 
            PrecoProduto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecoProduto.Location = new Point(438, 141);
            PrecoProduto.MaxLength = 10;
            PrecoProduto.Name = "PrecoProduto";
            PrecoProduto.Size = new Size(149, 27);
            PrecoProduto.TabIndex = 8;
            PrecoProduto.TextChanged += PrecoProduto_TextChanged_1;
            PrecoProduto.KeyPress += PrecoProduto_KeyPress;
            // 
            // Label_PrecoProduto
            // 
            Label_PrecoProduto.AutoSize = true;
            Label_PrecoProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_PrecoProduto.Location = new Point(380, 141);
            Label_PrecoProduto.Name = "Label_PrecoProduto";
            Label_PrecoProduto.Size = new Size(52, 21);
            Label_PrecoProduto.TabIndex = 4;
            Label_PrecoProduto.Text = "Preço:";
            // 
            // Label_NomeProduto
            // 
            Label_NomeProduto.AutoSize = true;
            Label_NomeProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_NomeProduto.Location = new Point(294, 96);
            Label_NomeProduto.Name = "Label_NomeProduto";
            Label_NomeProduto.Size = new Size(138, 21);
            Label_NomeProduto.TabIndex = 3;
            Label_NomeProduto.Text = "Nome do produto:";
            // 
            // index_CodProduto
            // 
            index_CodProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            index_CodProduto.Location = new Point(438, 54);
            index_CodProduto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            index_CodProduto.Name = "index_CodProduto";
            index_CodProduto.Size = new Size(51, 25);
            index_CodProduto.TabIndex = 6;
            index_CodProduto.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_CodProduto
            // 
            Label_CodProduto.AutoSize = true;
            Label_CodProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_CodProduto.Location = new Point(287, 54);
            Label_CodProduto.Name = "Label_CodProduto";
            Label_CodProduto.Size = new Size(145, 21);
            Label_CodProduto.TabIndex = 1;
            Label_CodProduto.Text = "Código do produto:";
            // 
            // NomeProduto
            // 
            NomeProduto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomeProduto.Location = new Point(438, 96);
            NomeProduto.Name = "NomeProduto";
            NomeProduto.Size = new Size(149, 27);
            NomeProduto.TabIndex = 7;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.Location = new Point(962, 101);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(95, 23);
            Btn_Voltar.TabIndex = 4;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = true;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Btn_ExcluirProd
            // 
            Btn_ExcluirProd.Location = new Point(810, 65);
            Btn_ExcluirProd.Name = "Btn_ExcluirProd";
            Btn_ExcluirProd.Size = new Size(112, 59);
            Btn_ExcluirProd.TabIndex = 3;
            Btn_ExcluirProd.Text = "Excluir produto";
            Btn_ExcluirProd.UseVisualStyleBackColor = true;
            Btn_ExcluirProd.Click += Btn_ExcluirProd_Click;
            // 
            // AlterarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 729);
            Controls.Add(Btn_ExcluirProd);
            Controls.Add(Btn_Voltar);
            Controls.Add(Box_AltProd);
            Controls.Add(Btn_EditarProd);
            Controls.Add(Btn_CriarProd);
            Controls.Add(Label_AltProdutos);
            Name = "AlterarProdutos";
            Text = "Alterar produtos";
            Load += AlterarProdutos_Load;
            Box_AltProd.ResumeLayout(false);
            Box_AltProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_PainelEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)index_Estoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)index_CodProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_AltProdutos;
        private Button Btn_CriarProd;
        private Button Btn_EditarProd;
        private GroupBox Box_AltProd;
        private Label Label_CodProduto;
        private TextBox NomeProduto;
        private NumericUpDown index_CodProduto;
        private Label Label_PrecoProduto;
        private Label Label_NomeProduto;
        private TextBox PrecoProduto;
        private Button Btn_Voltar;
        private NumericUpDown index_Estoque;
        private Button Btn_Cancelar;
        private Button Btn_Confirmar;
        private Label Label_Estoque;
        private Button Btn_ExcluirProd;
        private DataGridView Grid_PainelEstoque;
        private DataGridViewTextBoxColumn IdProduto;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Estoque;
    }
}