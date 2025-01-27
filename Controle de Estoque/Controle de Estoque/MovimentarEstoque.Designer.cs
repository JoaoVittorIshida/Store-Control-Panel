namespace Controle_de_Estoque
{
    partial class MovimentarEstoque
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
            label1 = new Label();
            Box_AltProd = new GroupBox();
            Grid_PainelEstoque = new DataGridView();
            IdProduto = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            index_Estoque = new NumericUpDown();
            Btn_Cancelar = new Button();
            Label_EntrarSair = new Label();
            Btn_Confirmar = new Button();
            Label_Estoque = new Label();
            index_Movimentacao = new NumericUpDown();
            PrecoProduto = new TextBox();
            Label_PrecoProduto = new Label();
            Label_NomeProduto = new Label();
            index_CodProduto = new NumericUpDown();
            Label_CodProduto = new Label();
            NomeProduto = new TextBox();
            Btn_Historico = new Button();
            Btn_Voltar = new Button();
            Btn_Entrada = new Button();
            Btn_Saida = new Button();
            groupBox1 = new GroupBox();
            index_BuscaProduto = new NumericUpDown();
            Btn_Filtrar = new Button();
            groupBox2 = new GroupBox();
            Btn_LimparFiltro = new Button();
            Box_AltProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_PainelEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)index_Estoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)index_Movimentacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)index_CodProduto).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)index_BuscaProduto).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 59);
            label1.Name = "label1";
            label1.Size = new Size(384, 50);
            label1.TabIndex = 0;
            label1.Text = "Movimentar estoque";
            // 
            // Box_AltProd
            // 
            Box_AltProd.BackColor = SystemColors.AppWorkspace;
            Box_AltProd.Controls.Add(Grid_PainelEstoque);
            Box_AltProd.Controls.Add(index_Estoque);
            Box_AltProd.Controls.Add(Btn_Cancelar);
            Box_AltProd.Controls.Add(Label_EntrarSair);
            Box_AltProd.Controls.Add(Btn_Confirmar);
            Box_AltProd.Controls.Add(Label_Estoque);
            Box_AltProd.Controls.Add(index_Movimentacao);
            Box_AltProd.Controls.Add(PrecoProduto);
            Box_AltProd.Controls.Add(Label_PrecoProduto);
            Box_AltProd.Controls.Add(Label_NomeProduto);
            Box_AltProd.Controls.Add(index_CodProduto);
            Box_AltProd.Controls.Add(Label_CodProduto);
            Box_AltProd.Controls.Add(NomeProduto);
            Box_AltProd.Location = new Point(74, 135);
            Box_AltProd.Name = "Box_AltProd";
            Box_AltProd.Size = new Size(973, 492);
            Box_AltProd.TabIndex = 4;
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
            Grid_PainelEstoque.StandardTab = true;
            Grid_PainelEstoque.TabIndex = 15;
            Grid_PainelEstoque.TabStop = false;
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
            // index_Estoque
            // 
            index_Estoque.Enabled = false;
            index_Estoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            index_Estoque.Location = new Point(474, 200);
            index_Estoque.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            index_Estoque.Name = "index_Estoque";
            index_Estoque.Size = new Size(51, 25);
            index_Estoque.TabIndex = 10;
            index_Estoque.TextAlign = HorizontalAlignment.Center;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.Location = new Point(510, 346);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(113, 52);
            Btn_Cancelar.TabIndex = 13;
            Btn_Cancelar.Text = "-";
            Btn_Cancelar.UseVisualStyleBackColor = true;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // Label_EntrarSair
            // 
            Label_EntrarSair.AutoSize = true;
            Label_EntrarSair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_EntrarSair.Location = new Point(316, 239);
            Label_EntrarSair.Name = "Label_EntrarSair";
            Label_EntrarSair.Size = new Size(152, 21);
            Label_EntrarSair.TabIndex = 10;
            Label_EntrarSair.Text = "Produto a entrar: (+)";
            // 
            // Btn_Confirmar
            // 
            Btn_Confirmar.Location = new Point(330, 346);
            Btn_Confirmar.Name = "Btn_Confirmar";
            Btn_Confirmar.Size = new Size(113, 52);
            Btn_Confirmar.TabIndex = 12;
            Btn_Confirmar.Text = "+";
            Btn_Confirmar.UseVisualStyleBackColor = true;
            Btn_Confirmar.Click += Btn_Confirmar_Click;
            // 
            // Label_Estoque
            // 
            Label_Estoque.AutoSize = true;
            Label_Estoque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Estoque.Location = new Point(362, 204);
            Label_Estoque.Name = "Label_Estoque";
            Label_Estoque.Size = new Size(106, 21);
            Label_Estoque.TabIndex = 7;
            Label_Estoque.Text = "Estoque atual:";
            // 
            // index_Movimentacao
            // 
            index_Movimentacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            index_Movimentacao.Location = new Point(474, 239);
            index_Movimentacao.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            index_Movimentacao.Name = "index_Movimentacao";
            index_Movimentacao.Size = new Size(51, 25);
            index_Movimentacao.TabIndex = 11;
            index_Movimentacao.TextAlign = HorizontalAlignment.Center;
            // 
            // PrecoProduto
            // 
            PrecoProduto.Enabled = false;
            PrecoProduto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecoProduto.Location = new Point(474, 158);
            PrecoProduto.Name = "PrecoProduto";
            PrecoProduto.Size = new Size(149, 27);
            PrecoProduto.TabIndex = 9;
            // 
            // Label_PrecoProduto
            // 
            Label_PrecoProduto.AutoSize = true;
            Label_PrecoProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_PrecoProduto.Location = new Point(416, 158);
            Label_PrecoProduto.Name = "Label_PrecoProduto";
            Label_PrecoProduto.Size = new Size(52, 21);
            Label_PrecoProduto.TabIndex = 4;
            Label_PrecoProduto.Text = "Preço:";
            // 
            // Label_NomeProduto
            // 
            Label_NomeProduto.AutoSize = true;
            Label_NomeProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_NomeProduto.Location = new Point(330, 113);
            Label_NomeProduto.Name = "Label_NomeProduto";
            Label_NomeProduto.Size = new Size(138, 21);
            Label_NomeProduto.TabIndex = 3;
            Label_NomeProduto.Text = "Nome do produto:";
            // 
            // index_CodProduto
            // 
            index_CodProduto.Enabled = false;
            index_CodProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            index_CodProduto.Location = new Point(474, 71);
            index_CodProduto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            index_CodProduto.Name = "index_CodProduto";
            index_CodProduto.Size = new Size(51, 25);
            index_CodProduto.TabIndex = 7;
            index_CodProduto.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_CodProduto
            // 
            Label_CodProduto.AutoSize = true;
            Label_CodProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_CodProduto.Location = new Point(323, 71);
            Label_CodProduto.Name = "Label_CodProduto";
            Label_CodProduto.Size = new Size(145, 21);
            Label_CodProduto.TabIndex = 1;
            Label_CodProduto.Text = "Código do produto:";
            // 
            // NomeProduto
            // 
            NomeProduto.Enabled = false;
            NomeProduto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomeProduto.Location = new Point(474, 113);
            NomeProduto.Name = "NomeProduto";
            NomeProduto.Size = new Size(149, 27);
            NomeProduto.TabIndex = 8;
            // 
            // Btn_Historico
            // 
            Btn_Historico.Location = new Point(854, 669);
            Btn_Historico.Name = "Btn_Historico";
            Btn_Historico.Size = new Size(193, 23);
            Btn_Historico.TabIndex = 14;
            Btn_Historico.Text = "Histórico de movimentações";
            Btn_Historico.UseVisualStyleBackColor = true;
            Btn_Historico.Click += Btn_Historico_Click;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.Location = new Point(951, 100);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(96, 22);
            Btn_Voltar.TabIndex = 6;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = true;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // Btn_Entrada
            // 
            Btn_Entrada.Location = new Point(16, 22);
            Btn_Entrada.Name = "Btn_Entrada";
            Btn_Entrada.Size = new Size(104, 48);
            Btn_Entrada.TabIndex = 1;
            Btn_Entrada.Text = "Entrada";
            Btn_Entrada.UseVisualStyleBackColor = true;
            Btn_Entrada.Click += Btn_Entrada_Click;
            // 
            // Btn_Saida
            // 
            Btn_Saida.Location = new Point(165, 22);
            Btn_Saida.Name = "Btn_Saida";
            Btn_Saida.Size = new Size(103, 48);
            Btn_Saida.TabIndex = 2;
            Btn_Saida.Text = "Saída";
            Btn_Saida.UseVisualStyleBackColor = true;
            Btn_Saida.Click += Btn_Saida_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_Saida);
            groupBox1.Controls.Add(Btn_Entrada);
            groupBox1.Location = new Point(470, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 76);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opções de movimentação";
            // 
            // index_BuscaProduto
            // 
            index_BuscaProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            index_BuscaProduto.Location = new Point(20, 33);
            index_BuscaProduto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            index_BuscaProduto.Name = "index_BuscaProduto";
            index_BuscaProduto.Size = new Size(51, 25);
            index_BuscaProduto.TabIndex = 3;
            index_BuscaProduto.TextAlign = HorizontalAlignment.Center;
            // 
            // Btn_Filtrar
            // 
            Btn_Filtrar.Location = new Point(77, 35);
            Btn_Filtrar.Name = "Btn_Filtrar";
            Btn_Filtrar.Size = new Size(69, 22);
            Btn_Filtrar.TabIndex = 4;
            Btn_Filtrar.Text = "Buscar";
            Btn_Filtrar.UseVisualStyleBackColor = true;
            Btn_Filtrar.Click += Btn_Filtrar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Btn_Filtrar);
            groupBox2.Controls.Add(index_BuscaProduto);
            groupBox2.Location = new Point(766, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(163, 76);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtro de busca";
            // 
            // Btn_LimparFiltro
            // 
            Btn_LimparFiltro.Location = new Point(951, 72);
            Btn_LimparFiltro.Name = "Btn_LimparFiltro";
            Btn_LimparFiltro.Size = new Size(96, 22);
            Btn_LimparFiltro.TabIndex = 5;
            Btn_LimparFiltro.Text = "Limpar filtro";
            Btn_LimparFiltro.UseVisualStyleBackColor = true;
            Btn_LimparFiltro.Click += Btn_LimparFiltro_Click;
            // 
            // MovimentarEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 729);
            Controls.Add(Btn_LimparFiltro);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Btn_Voltar);
            Controls.Add(Box_AltProd);
            Controls.Add(Btn_Historico);
            Controls.Add(label1);
            Name = "MovimentarEstoque";
            Text = "Movimentar estoque";
            Load += MovimentarEstoque_Load;
            Box_AltProd.ResumeLayout(false);
            Box_AltProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grid_PainelEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)index_Estoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)index_Movimentacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)index_CodProduto).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)index_BuscaProduto).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox Box_AltProd;
        private Label Label_EntrarSair;
        private Button Btn_Historico;
        private Button Btn_Confirmar;
        private Label Label_Estoque;
        private NumericUpDown index_Movimentacao;
        private TextBox PrecoProduto;
        private Label Label_PrecoProduto;
        private Label Label_NomeProduto;
        private NumericUpDown index_CodProduto;
        private Label Label_CodProduto;
        private TextBox NomeProduto;
        private Button Btn_Voltar;
        private Button Btn_Entrada;
        private Button Btn_Saida;
        private GroupBox groupBox1;
        private Button Btn_Cancelar;
        private NumericUpDown index_BuscaProduto;
        private Button Btn_Filtrar;
        private GroupBox groupBox2;
        private NumericUpDown index_Estoque;
        private Button Btn_LimparFiltro;
        private DataGridView Grid_PainelEstoque;
        private DataGridViewTextBoxColumn IdProduto;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Estoque;
    }
}