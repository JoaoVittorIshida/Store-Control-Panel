namespace Controle_de_Estoque
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //Programa inicia primeiro o form de login.
            //Com o retorno dos dados do usu�rio, ele chama o Menu Principal passando esses par�metros.

            ApplicationConfiguration.Initialize();

            TelaLogin telaLogin = new TelaLogin();
            if (telaLogin.ShowDialog() == DialogResult.OK)
            {
                MenuPrincipal controleEstoque = new MenuPrincipal();
                MovimentarEstoque movimentarEstoque = new MovimentarEstoque();

                if(CurrentSession.SessaoAtual.NivelPermissao == 0)
                    Application.Run(movimentarEstoque);

                if(CurrentSession.SessaoAtual.NivelPermissao != 0)
                    Application.Run(controleEstoque);
            }
        }
    }
}