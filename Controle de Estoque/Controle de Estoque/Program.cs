namespace Controle_de_Estoque
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //Programa inicia primeiro o form de login.
            //Com o retorno dos dados do usuário, ele chama o Menu Principal passando esses parâmetros.

            ApplicationConfiguration.Initialize();

            TelaLogin telaLogin = new TelaLogin();
            if (telaLogin.ShowDialog() == DialogResult.OK)
            {
                string usuarioLogado = telaLogin.UsuarioLogado;
                int nivelPermissao = telaLogin.NivelPermissao;

                MenuPrincipal controleEstoque = new MenuPrincipal(usuarioLogado, nivelPermissao);
                Application.Run(controleEstoque);
            }
        }
    }
}