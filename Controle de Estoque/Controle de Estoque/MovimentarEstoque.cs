using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Controle_de_Estoque
{
    public partial class MovimentarEstoque : Form
    {

        private int nivelPermissao = CurrentSession.SessaoAtual.NivelPermissao;
        private string usuarioLogado = CurrentSession.SessaoAtual.NomeUsuario;
        public MovimentarEstoque()
        {
            InitializeComponent();
        }

        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader DadosCarregados;

        int op; //op = 1 (entrada), op = 2 (saída)

        private void AtualizarDataGridComFiltro(int idbusca)
        {
            //Atualiza data grid com filtros definido por um parâmetro.

            string strSQL = "", produto;
            int idproduto, estoque;
            decimal valor;

            Grid_PainelEstoque.Rows.Clear();

            strSQL = "SELECT * FROM estoque WHERE idproduto = " + idbusca;

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

        private void AtualizarDataGridSemFiltro()
        {
            //Atualiza data grid sem filtro

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

        private void AtualizarCampoEdicao()
        {
            //Atualiza campo de edição com o produto selecionado.

            index_CodProduto.Value = Convert.ToInt32(Grid_PainelEstoque.CurrentRow.Cells["IdProduto"].Value);
            NomeProduto.Text = Grid_PainelEstoque.CurrentRow.Cells["Produto"].Value.ToString();
            string valorSemMoeda = (Grid_PainelEstoque.CurrentRow.Cells["Valor"].Value.ToString().Replace("R$", "").Trim());
            decimal valorProduto = Convert.ToDecimal(valorSemMoeda);
            PrecoProduto.Text = (valorSemMoeda).ToString();
            index_Estoque.Value = Convert.ToInt32(Grid_PainelEstoque.CurrentRow.Cells["Estoque"].Value);
        }

        private void MovimentarEstoque_Load(object sender, EventArgs e)
        {
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

            if (nivelPermissao == 0)
            {
                Btn_Entrada.Enabled = false;
                Btn_Historico.Enabled = false; 
            }

            AtualizarDataGridSemFiltro();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Filtrar_Click(object sender, EventArgs e)
        {
            AtualizarDataGridComFiltro((int)index_BuscaProduto.Value);
        }

        private void Btn_LimparFiltro_Click(object sender, EventArgs e)
        {
            //Limpa filtro e atualiza data grid

            index_BuscaProduto.Value = 0;
            AtualizarDataGridSemFiltro();
        }

        private void Btn_Entrada_Click(object sender, EventArgs e)
        {
            //Atualiza botões e labels para operação de entrada

            op = 1;
            Label_EntrarSair.Text = "Produto a entrar: (+)";
            AtualizarCampoEdicao();
            Btn_Confirmar.Text = "Confirmar entrada";
            Btn_Cancelar.Text = "Cancelar entrada";
            Grid_PainelEstoque.Visible = false;

            Btn_Entrada.Enabled = false;
            Btn_Saida.Enabled = false;

        }

        private void Btn_Saida_Click(object sender, EventArgs e)
        {
            //Atualiza botões e labels para operação de saída

            op = 2;
            Label_EntrarSair.Text = "Produto a sair: (-)";
            AtualizarCampoEdicao();
            Btn_Confirmar.Text = "Confirmar saída";
            Btn_Cancelar.Text = "Cancelar saída";
            Grid_PainelEstoque.Visible = false;

            Btn_Entrada.Enabled = false;
            Btn_Saida.Enabled = false;

        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (index_Movimentacao.Value == 0)
            {
                MessageBox.Show("Insira um número diferente de 0 para realizar uma movimentação.", "Movimentação nula?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Entrada
            if (op == 1)
            {
                int novoestoque = (int)(index_Estoque.Value + index_Movimentacao.Value);

                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.CommandText = "UPDATE estoque SET estoque = @Estoque WHERE idproduto = " + index_CodProduto.Value;
                Obj_CmdSQL.Parameters.AddWithValue("@Estoque", novoestoque);

                Obj_CmdSQL.ExecuteNonQuery();
            }

            //Saída
            if (op == 2)
            {
                if ((index_Estoque.Value - index_Movimentacao.Value) < 0)
                {
                    MessageBox.Show("Não é possível definir um estoque negativo, verifique e tente novamente.", "Erro na movimentação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int novoestoque = (int)(index_Estoque.Value - index_Movimentacao.Value);

                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.CommandText = "UPDATE estoque SET estoque = @Estoque WHERE idproduto = " + index_CodProduto.Value;
                Obj_CmdSQL.Parameters.AddWithValue("@Estoque", novoestoque);

                Obj_CmdSQL.ExecuteNonQuery();

            }

            //Registro de histórico de movimentações no banco
            Obj_CmdSQL.Parameters.Clear();
            Obj_CmdSQL.CommandText = "INSERT INTO historicomov (usuario, produto, tipoMovimentacao, quantidade, horaMovimentacao) VALUES (@Usuario, @Produto, @tipoMov, @Quantidade, @horaMov)";
            Obj_CmdSQL.Parameters.AddWithValue("@Usuario", usuarioLogado);
            Obj_CmdSQL.Parameters.AddWithValue("@Produto", NomeProduto.Text);
            if (op == 1)
                Obj_CmdSQL.Parameters.AddWithValue("@tipoMov", "Entrada");
            if (op == 2)
                Obj_CmdSQL.Parameters.AddWithValue("@tipoMov", "Saída");
            Obj_CmdSQL.Parameters.AddWithValue("@Quantidade", index_Movimentacao.Value);
            Obj_CmdSQL.Parameters.AddWithValue("@horaMov", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            Obj_CmdSQL.ExecuteNonQuery();

            MessageBox.Show("Movimentação realizada com sucesso!", "Resultado da movimentação", MessageBoxButtons.OK);
            AtualizarDataGridSemFiltro();
            Grid_PainelEstoque.Visible = true;
            index_Movimentacao.Value = 0;
            if(nivelPermissao >= 1)
                Btn_Entrada.Enabled = true;
            Btn_Saida.Enabled = true;

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Grid_PainelEstoque.Visible = true;
            if (nivelPermissao >= 1)
                Btn_Entrada.Enabled = true;
            Btn_Saida.Enabled = true;

        }

        private void Btn_Historico_Click(object sender, EventArgs e)
        {
            //Chama tela de histórico de movimentações.

            HistoricoMov historicoMov = new HistoricoMov();
            historicoMov.ShowDialog();
        }
    }

}
