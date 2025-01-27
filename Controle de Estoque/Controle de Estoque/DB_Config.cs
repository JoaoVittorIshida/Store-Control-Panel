using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque
{
    //Classe de configuração do banco de dados
    public static class DB_Config
    {
        public static string ObterStringConexao()
        {
            //Alterar para acessar o banco no seu PC
            return "Server=localhost;Database=db_lojinha;User=root;Pwd=joaoishida";
        }
    }
}
