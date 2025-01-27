namespace Controle_de_Estoque
{
    partial class HistoricoMov
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
            Grid_PainelHistorico = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Grid_PainelHistorico).BeginInit();
            SuspendLayout();
            // 
            // Grid_PainelHistorico
            // 
            Grid_PainelHistorico.AllowUserToAddRows = false;
            Grid_PainelHistorico.AllowUserToDeleteRows = false;
            Grid_PainelHistorico.AllowUserToOrderColumns = true;
            Grid_PainelHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Grid_PainelHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_PainelHistorico.Columns.AddRange(new DataGridViewColumn[] { Usuario, Produto, Tipo, Quantidade, Horario });
            Grid_PainelHistorico.Location = new Point(12, 12);
            Grid_PainelHistorico.MultiSelect = false;
            Grid_PainelHistorico.Name = "Grid_PainelHistorico";
            Grid_PainelHistorico.ReadOnly = true;
            Grid_PainelHistorico.Size = new Size(776, 426);
            Grid_PainelHistorico.TabIndex = 15;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuário";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Produto
            // 
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            Produto.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // Horario
            // 
            Horario.HeaderText = "Horário";
            Horario.Name = "Horario";
            Horario.ReadOnly = true;
            // 
            // HistoricoMov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Grid_PainelHistorico);
            Name = "HistoricoMov";
            Text = "Histórico de movimentações";
            Load += HistoricoMov_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_PainelHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Grid_PainelHistorico;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Horario;
    }
}