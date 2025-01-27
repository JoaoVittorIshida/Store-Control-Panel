namespace Controle_de_Estoque
{
    partial class VisualizarEstoque
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
            Grid_PainelEstoque = new DataGridView();
            IdProduto = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            Btn_Buscar = new Button();
            Btn_ResetFiltros = new Button();
            ProdBuscar = new TextBox();
            Btn_Voltar = new Button();
            groupBox1 = new GroupBox();
            Btn_BuscarCod = new Button();
            index_CodProduto = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Grid_PainelEstoque).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)index_CodProduto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 65);
            label1.Name = "label1";
            label1.Size = new Size(321, 50);
            label1.TabIndex = 0;
            label1.Text = "Visão do Estoque";
            // 
            // Grid_PainelEstoque
            // 
            Grid_PainelEstoque.AllowUserToAddRows = false;
            Grid_PainelEstoque.AllowUserToDeleteRows = false;
            Grid_PainelEstoque.AllowUserToOrderColumns = true;
            Grid_PainelEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_PainelEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_PainelEstoque.Columns.AddRange(new DataGridViewColumn[] { IdProduto, Produto, Valor, Estoque });
            Grid_PainelEstoque.Location = new Point(69, 144);
            Grid_PainelEstoque.MultiSelect = false;
            Grid_PainelEstoque.Name = "Grid_PainelEstoque";
            Grid_PainelEstoque.ReadOnly = true;
            Grid_PainelEstoque.Size = new Size(1002, 539);
            Grid_PainelEstoque.TabIndex = 1;
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
            // Btn_Buscar
            // 
            Btn_Buscar.Location = new Point(223, 34);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(57, 22);
            Btn_Buscar.TabIndex = 2;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = true;
            Btn_Buscar.Click += Btn_Buscar_Click;
            // 
            // Btn_ResetFiltros
            // 
            Btn_ResetFiltros.Location = new Point(975, 65);
            Btn_ResetFiltros.Name = "Btn_ResetFiltros";
            Btn_ResetFiltros.Size = new Size(96, 22);
            Btn_ResetFiltros.TabIndex = 4;
            Btn_ResetFiltros.Text = "Limpar Filtros";
            Btn_ResetFiltros.UseVisualStyleBackColor = true;
            Btn_ResetFiltros.Click += Btn_ResetV_Click;
            // 
            // ProdBuscar
            // 
            ProdBuscar.Location = new Point(108, 33);
            ProdBuscar.Name = "ProdBuscar";
            ProdBuscar.PlaceholderText = "Nome do Produto";
            ProdBuscar.Size = new Size(109, 23);
            ProdBuscar.TabIndex = 5;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.Location = new Point(975, 93);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(96, 22);
            Btn_Voltar.TabIndex = 7;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = true;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_BuscarCod);
            groupBox1.Controls.Add(index_CodProduto);
            groupBox1.Controls.Add(Btn_Buscar);
            groupBox1.Controls.Add(ProdBuscar);
            groupBox1.Location = new Point(396, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 79);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros de busca (uso individual)";
            // 
            // Btn_BuscarCod
            // 
            Btn_BuscarCod.Location = new Point(373, 34);
            Btn_BuscarCod.Name = "Btn_BuscarCod";
            Btn_BuscarCod.Size = new Size(93, 23);
            Btn_BuscarCod.TabIndex = 9;
            Btn_BuscarCod.Text = "Buscar código";
            Btn_BuscarCod.UseVisualStyleBackColor = true;
            Btn_BuscarCod.Click += Btn_BuscarCod_Click;
            // 
            // index_CodProduto
            // 
            index_CodProduto.Location = new Point(329, 33);
            index_CodProduto.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            index_CodProduto.Name = "index_CodProduto";
            index_CodProduto.Size = new Size(38, 23);
            index_CodProduto.TabIndex = 7;
            // 
            // VisualizarEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 729);
            Controls.Add(groupBox1);
            Controls.Add(Btn_Voltar);
            Controls.Add(Btn_ResetFiltros);
            Controls.Add(Grid_PainelEstoque);
            Controls.Add(label1);
            Name = "VisualizarEstoque";
            Text = "Visualizar estoque";
            Load += VisualizarEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_PainelEstoque).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)index_CodProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView Grid_PainelEstoque;
        private Button Btn_Buscar;
        private Button Btn_Ordenar;
        private Button Btn_ResetFiltros;
        private TextBox ProdBuscar;
        private ComboBox OrdnProd;
        private Button Btn_Voltar;
        private GroupBox groupBox1;
        private Button Btn_BuscarCod;
        private NumericUpDown index_CodProduto;
        private DataGridViewTextBoxColumn IdProduto;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Estoque;
    }
}