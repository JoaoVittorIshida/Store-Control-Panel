using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Estoque
{
    internal class CurrentSession
    {
        public string NomeUsuario { get; set; }
        public int NivelPermissao { get; set; }

        public static CurrentSession SessaoAtual { get; private set; }

        public CurrentSession(string nomeUsuario, int nivelPermissao)
        {
            NomeUsuario = nomeUsuario;
            NivelPermissao = nivelPermissao;
        }

        public static void IniciarSessao(string nomeUsuario, int nivelPermissao)
        {
            SessaoAtual = new CurrentSession(nomeUsuario, nivelPermissao);
        }

    }
}
