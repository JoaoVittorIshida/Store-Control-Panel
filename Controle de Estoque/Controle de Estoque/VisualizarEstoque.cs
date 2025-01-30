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
    public partial class VisualizarEstoque : Form
    {
        public VisualizarEstoque()
        {
            InitializeComponent();
        }

        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader DadosCarregados;

        private void AtualizarDataGridSemFiltro()
        {

            //Atualiza o data grid sem filtros aplicados.

            try
            {
                string strSQL, produto;
                int idproduto, estoque;
                decimal valor;

                Grid_PainelEstoque.Rows.Clear();
                strSQL = "SELECT idproduto, produto, valorvenda, estoque FROM estoque";

                Obj_CmdSQL.CommandText = strSQL;

                DadosCarregados = Obj_CmdSQL.ExecuteReader();
                if (DadosCarregados.HasRows)
                {
                    while (DadosCarregados.Read())
                    {
                        idproduto = Convert.ToInt32(DadosCarregados["idproduto"]);
                        produto = DadosCarregados["produto"].ToString();
                        valor = Convert.ToDecimal(DadosCarregados["valorvenda"]);
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
            catch
            {
                MessageBox.Show("Erro ao se comunicar com o banco de dados", "Erro no servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void AtualizarDataGridComFiltro(int op, string prodbusca, int idbusca)
        {

            //Atualiza o Data grid com filtros aplicados, passados como parâmetros, assim reaproveitando a função

            try
            {
                string strSQL = "", produto;
                int idproduto, estoque;
                decimal valor;

                Grid_PainelEstoque.Rows.Clear();
                if (op == 1)
                    strSQL = "SELECT idproduto, produto, valorvenda, estoque FROM estoque WHERE produto LIKE " + "'%" + prodbusca + "%'";
                if (op == 2)
                    strSQL = "SELECT idproduto, produto, valorvenda, estoque FROM estoque WHERE idproduto = " + idbusca;
                if (op != 1 && op != 2)
                    return;


                Obj_CmdSQL.CommandText = strSQL;

                DadosCarregados = Obj_CmdSQL.ExecuteReader();
                if (DadosCarregados.HasRows)
                {
                    while (DadosCarregados.Read())
                    {
                        idproduto = Convert.ToInt32(DadosCarregados["idproduto"]);
                        produto = DadosCarregados["produto"].ToString();
                        valor = Convert.ToDecimal(DadosCarregados["valorvenda"]);
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
            catch 
            {
                MessageBox.Show("Erro ao se comunicar com o banco de dados", "Erro no servidor", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }


        private void Btn_ResetV_Click(object sender, EventArgs e)
        {

            //Limpa os campos de filtro e atualiza o data grid sem filtros

            ProdBuscar.Text = string.Empty;
            index_CodProduto.Value = 0;
            AtualizarDataGridSemFiltro();

        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VisualizarEstoque_Load(object sender, EventArgs e)
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

            AtualizarDataGridSemFiltro();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            AtualizarDataGridComFiltro(1, ProdBuscar.Text, 0);
        }

        private void Btn_BuscarCod_Click(object sender, EventArgs e)
        {
           AtualizarDataGridComFiltro(2, "", (int)index_CodProduto.Value);
        }
    }
}
