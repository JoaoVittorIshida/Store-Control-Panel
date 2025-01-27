using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Controle_de_Estoque
{
    public partial class AlterarProdutos : Form
    {
        public AlterarProdutos()
        {
            InitializeComponent();
        }

        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader DadosCarregados;

        int op; //op = 1 (Adicionar), op = 2 (Editar);

        private void AlterarProdutos_Load(object sender, EventArgs e)
        {
            Box_AltProd.Enabled = true;
            try
            {
                // String de conexão
                Obj_Conn.ConnectionString = DB_Config.ObterStringConexao();
                Obj_Conn.Open();
                Obj_CmdSQL.Connection = Obj_Conn;

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro: " + Erro.Message, "Erro de Conexão ADO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarDataGridSemFiltro();
        }

        private bool VerificarNomeProdutoRepetido(string nomeProduto, int idProdutoAtual)
        {
            bool nomeRepetido = false;
            try
            {
                if (idProdutoAtual == 0) 
                {
                    Obj_CmdSQL.CommandText = @"SELECT COUNT(*) 
                                       FROM estoque 
                                       WHERE produto = @Produto";
                }
                else 
                {
                    Obj_CmdSQL.CommandText = @"SELECT COUNT(*) 
                                       FROM estoque 
                                       WHERE produto = @Produto 
                                       AND idproduto != @IdProdutoAtual";
                }
                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.Parameters.AddWithValue("@Produto", nomeProduto);

                if (idProdutoAtual != 0)
                {
                    Obj_CmdSQL.Parameters.AddWithValue("@IdProdutoAtual", idProdutoAtual);
                }

                int count = Convert.ToInt32(Obj_CmdSQL.ExecuteScalar());
                if (count > 0)
                {
                    nomeRepetido = true;
                }
            }
            catch
            {
                MessageBox.Show($"Erro ao verificar nome de produto repetido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nomeRepetido;
        }

        private void AtualizarDataGridSemFiltro()
        {

            //Atualiza o data grid sem filtros.

            string strSQL, produto;
            int idproduto, estoque;
            decimal valor;

            Grid_PainelEstoque.Rows.Clear();
            strSQL = "SELECT * FROM estoque";

            Obj_CmdSQL.CommandText = strSQL;

            DadosCarregados = Obj_CmdSQL.ExecuteReader();
            if (DadosCarregados.HasRows)
            {
                while (DadosCarregados.Read())
                {
                    idproduto = Convert.ToInt32(DadosCarregados["idproduto"]);
                    produto = DadosCarregados["produto"].ToString();
                    valor = Convert.ToDecimal(DadosCarregados["valor"]);
                    estoque = Convert.ToInt32(DadosCarregados["estoque"]);

                    string ValorFormatado = "R$" + valor.ToString("N2");

                    Grid_PainelEstoque.Rows.Add(idproduto, produto, ValorFormatado, estoque);

                }
            }
            if (!DadosCarregados.IsClosed)
            {
                DadosCarregados.Close();
            }

        }

        private void Btn_CriarProd_Click(object sender, EventArgs e)
        {
            //Habilita a tela de criação de produto
            op = 1;
            Btn_Confirmar.Text = "Criar produto";
            Btn_Confirmar.Visible = true;
            Btn_Cancelar.Text = "Cancelar criação";
            Btn_Cancelar.Visible = true;
            Grid_PainelEstoque.Visible = false;

            int novo_cod = 1; 

            try
            {
                //Verifica se o ID 1 está sendo utilizado
                Obj_CmdSQL.CommandText = "SELECT COUNT(*) FROM estoque WHERE idproduto = 1";

                if (!DadosCarregados.IsClosed)
                    DadosCarregados.Close();

                DadosCarregados = Obj_CmdSQL.ExecuteReader();
                DadosCarregados.Read();
                int countId1 = Convert.ToInt32(DadosCarregados[0]);

                if (countId1 == 0) //Se o ID 1 não existe, então o próximo código será 1
                {
                    novo_cod = 1;
                }
                else
                {
                    //Consulta para encontrar o menor ID vazio
                    Obj_CmdSQL.CommandText = @"
                SELECT MIN(t.idproduto + 1) AS ProximoIDVazio
                FROM estoque t
                WHERE NOT EXISTS (
                    SELECT 1 
                    FROM estoque e 
                    WHERE e.idproduto = t.idproduto + 1
                )";

                    if (!DadosCarregados.IsClosed)
                        DadosCarregados.Close();

                    DadosCarregados = Obj_CmdSQL.ExecuteReader();

                    if (DadosCarregados.HasRows)
                    {
                        DadosCarregados.Read();
                        if (DadosCarregados[0] != DBNull.Value)
                        {
                            novo_cod = Convert.ToInt32(DadosCarregados[0]);
                        }
                    }
                }

                if (!DadosCarregados.IsClosed)
                    DadosCarregados.Close();

                if (novo_cod == 0)
                {
                    Obj_CmdSQL.CommandText = "SELECT MAX(idproduto) FROM estoque";

                    if (!DadosCarregados.IsClosed)
                        DadosCarregados.Close();

                    DadosCarregados = Obj_CmdSQL.ExecuteReader();
                    if (DadosCarregados.HasRows)
                    {
                        DadosCarregados.Read();
                        if (DadosCarregados[0] != DBNull.Value)
                        {
                            novo_cod = Convert.ToInt32(DadosCarregados[0]) + 1;
                        }
                    }
                }

                if (!DadosCarregados.IsClosed)
                    DadosCarregados.Close();

                index_CodProduto.Value = novo_cod;
                index_CodProduto.Enabled = false;

                Btn_CriarProd.Enabled = false;
                Btn_EditarProd.Enabled = false;
                Btn_ExcluirProd.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao determinar o ID do novo produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!DadosCarregados.IsClosed)
                    DadosCarregados.Close();
            }
        }

        private void Btn_EditarProd_Click(object sender, EventArgs e)
        {
            //Habilita a tela de edição de produto
            op = 2;
            //Puxar os valores da linha do DataGrid para as Textbox de edição
            int cod_edit = Convert.ToInt32(Grid_PainelEstoque.CurrentRow.Cells["IdProduto"].Value);
            NomeProduto.Text = Grid_PainelEstoque.CurrentRow.Cells["Produto"].Value.ToString();
            string valorSemMoeda = (Grid_PainelEstoque.CurrentRow.Cells["Valor"].Value.ToString().Replace("R$", "").Trim());
            decimal valorProduto = Convert.ToDecimal(valorSemMoeda);
            PrecoProduto.Text = (valorSemMoeda).ToString();
            index_Estoque.Value = Convert.ToInt32(Grid_PainelEstoque.CurrentRow.Cells["Estoque"].Value);


            Btn_Confirmar.Text = "Editar produto";
            Btn_Confirmar.Visible = true;
            Btn_Cancelar.Text = "Cancelar edição";
            Btn_Cancelar.Visible = true;
            Grid_PainelEstoque.Visible = false;

            index_CodProduto.Value = cod_edit;
            index_CodProduto.Enabled = false;

            Btn_CriarProd.Enabled = false;
            Btn_EditarProd.Enabled = false;
            Btn_ExcluirProd.Enabled = false;

        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            //Função do botão confirmar, funciona para criar e editar.

            //operação de criação de produto.
            if(index_Estoque.Value < 0)
            {
                MessageBox.Show("Estoque não pode ser negativo, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (op == 1)
            {
                if (string.IsNullOrEmpty(NomeProduto.Text) || string.IsNullOrEmpty(PrecoProduto.Text))
                {
                    MessageBox.Show("Nome ou preço não podem ser nulos, verifique e tente novamente.",
                                    "Erro na criação de produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(VerificarNomeProdutoRepetido(NomeProduto.Text, 0) == true)
                {
                    MessageBox.Show("Nome de produto repetido, verifique e tente novamente.", "Nome repetido", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                try
                {      
                    Obj_CmdSQL.Parameters.Clear();
                    Obj_CmdSQL.CommandText = "INSERT INTO estoque (idproduto, produto, valor, estoque) VALUES (@IDProduto, @Produto, @Valor, @Estoque)";

                    Obj_CmdSQL.Parameters.AddWithValue("@IDProduto", index_CodProduto.Value);
                    Obj_CmdSQL.Parameters.AddWithValue("@Produto", NomeProduto.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Valor", PrecoProduto.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Estoque", index_Estoque.Value);

                    Obj_CmdSQL.ExecuteNonQuery();

                    MessageBox.Show("Criação realizada com sucesso!", "Resultado da operação", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir o produto: " + ex.Message,
                                    "Erro na criação de produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //operação de edição de produto.
            if (op == 2)
            {
                if (string.IsNullOrEmpty(NomeProduto.Text) || string.IsNullOrEmpty(PrecoProduto.Text))
                {
                    MessageBox.Show("Nome ou preço não podem ser nulos, verifique e tente novamente.",
                                    "Erro na edição de produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (VerificarNomeProdutoRepetido(NomeProduto.Text, (int)index_CodProduto.Value) == true)
                {
                    MessageBox.Show("Nome de produto repetido, verifique e tente novamente.", "Nome repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    Obj_CmdSQL.Parameters.Clear();
                    Obj_CmdSQL.CommandText = "UPDATE estoque SET produto = @Produto, valor = @Valor, estoque = @Estoque WHERE idproduto = @IdProduto";

                    Obj_CmdSQL.Parameters.AddWithValue("@Produto", NomeProduto.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Valor", PrecoProduto.Text);
                    Obj_CmdSQL.Parameters.AddWithValue("@Estoque", index_Estoque.Value);
                    Obj_CmdSQL.Parameters.AddWithValue("@IdProduto", index_CodProduto.Value);


                    Obj_CmdSQL.ExecuteNonQuery();

                    MessageBox.Show("Edição realizada com sucesso!", "Resultado da operação", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir o produto: " + ex.Message,
                                    "Erro na criação de produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            Btn_CriarProd.Enabled = true;
            Btn_EditarProd.Enabled = true;
            Btn_ExcluirProd.Enabled = true;

            Btn_Confirmar.Visible = false;
            Btn_Cancelar.Visible = false;
            index_CodProduto.Value = 0;
            NomeProduto.Text = string.Empty;
            PrecoProduto.Text = string.Empty;
            index_Estoque.Value = 0;
            Grid_PainelEstoque.Visible = true;
            AtualizarDataGridSemFiltro();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            //Limpa os campos e retorna a visualização do datagrid atualizado

            Btn_CriarProd.Enabled = true;
            Btn_EditarProd.Enabled = true;
            Btn_ExcluirProd.Enabled = true;

            Btn_Confirmar.Visible = false;
            Btn_Cancelar.Visible = false;

            index_CodProduto.Value = 0;
            NomeProduto.Text = string.Empty;
            PrecoProduto.Text = string.Empty;
            index_Estoque.Value = 0;
            Grid_PainelEstoque.Visible = true;
            AtualizarDataGridSemFiltro();
        }

        private void Btn_ExcluirProd_Click(object sender, EventArgs e)
        {
            //Função de exclusão de produto

            int codProdutoExcluir = Convert.ToInt32(Grid_PainelEstoque.CurrentRow.Cells["IdProduto"].Value);
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este item?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Obj_CmdSQL.CommandText = "DELETE FROM estoque WHERE idproduto =" + codProdutoExcluir;
                    Obj_CmdSQL.ExecuteNonQuery();

                    //Faço isso para resetar o AutoIncrement e seus index do estoque, evita bugs de ID
                    Obj_CmdSQL.CommandText = "ALTER TABLE estoque AUTO_INCREMENT = 1";
                    Obj_CmdSQL.ExecuteNonQuery();

                    MessageBox.Show("Exclusão realizada com sucesso!", "Resultado da operação", MessageBoxButtons.OK);
                    AtualizarDataGridSemFiltro();

                }
                catch
                {
                    MessageBox.Show("Erro ao se comunicar com o banco de dados", "Erro no servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrecoProduto_TextChanged(object sender, EventArgs e)
        {
            //Ajusta o cursor para o final da entrada na mudança de texto
            PrecoProduto.SelectionStart = PrecoProduto.Text.Length;
        }

        private void PrecoProduto_TextChanged_1(object sender, EventArgs e)
        {
            //Obtém o texto atual e formata para o padrão
            string textoAtual = PrecoProduto.Text.Replace(",", "").Replace(".", "");
            if (decimal.TryParse(textoAtual, out decimal valor))
            {
                PrecoProduto.TextChanged -= PrecoProduto_TextChanged;

                //Converte o valor para o formato correto
                PrecoProduto.Text = (valor / 100).ToString("F2", CultureInfo.InvariantCulture);

                //Ajusta o cursor para o final
                PrecoProduto.SelectionStart = PrecoProduto.Text.Length;
                PrecoProduto.TextChanged += PrecoProduto_TextChanged;
            }
        }

        private void PrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir apenas dígitos e o caractere de ponto ou vírgula
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
