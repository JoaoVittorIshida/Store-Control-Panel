using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    public partial class HistoricoMov : Form
    {
        public HistoricoMov()
        {
            InitializeComponent();
        }

        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader DadosCarregados;

        private void HistoricoMov_Load(object sender, EventArgs e)
        {
            //Funciona por completo no Load, carrega o data grid com a tabela de movimentação

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


                string strSQL = "", usuario, produto, tipo, horario;
                int quantidade;
                
                

                Grid_PainelHistorico.Rows.Clear();

                strSQL = "SELECT * FROM historicomov";

                Obj_CmdSQL.CommandText = strSQL;

                DadosCarregados = Obj_CmdSQL.ExecuteReader();
                if (DadosCarregados.HasRows)
                {
                    while (DadosCarregados.Read())
                    {
                        usuario = DadosCarregados["usuario"].ToString();
                        produto = DadosCarregados["produto"].ToString();
                        tipo = DadosCarregados["tipoMovimentacao"].ToString();
                        quantidade = Convert.ToInt32(DadosCarregados["quantidade"]);
                        DateTime dataHoraCriacao = Convert.ToDateTime(DadosCarregados["horaMovimentacao"]);
                        horario = dataHoraCriacao.ToString();


                        Grid_PainelHistorico.Rows.Add(usuario, produto, tipo, quantidade, horario);

                    }
                }
                if (!DadosCarregados.IsClosed)
                {
                    DadosCarregados.Close();
                }
            
        }
    }
}
