using MySql.Data.MySqlClient;

namespace Controle_de_Estoque
{
    public partial class MenuPrincipal : Form
    {
        private int nivelPermissao;
        private string usuarioLogado;
        public MenuPrincipal(string usuarioLogado, int nivelPermissao)
        {
            InitializeComponent();
            this.nivelPermissao = nivelPermissao;
            this.usuarioLogado = usuarioLogado;
        }

        private void ControleEstoque_Load(object sender, EventArgs e)
        {
            //Configura os acessos e labels no menu principal de acordo com o usu�rio
            if (nivelPermissao == 0)
            {
                Label_BemVindo.Text = "Bem vindo(a) vendedor(a) " + usuarioLogado;
                Btn_AProdutos.Enabled = false;
            }
            if (nivelPermissao == 1)
            {
                Label_BemVindo.Text = "Bem vindo(a) gerente " + usuarioLogado;
                Btn_AProdutos.Enabled = false;

            }
            if (nivelPermissao == 2)
                Label_BemVindo.Text = "Bem vindo(a) administrador(a) " + usuarioLogado;
        }

        private void Btn_VEstoque_Click(object sender, EventArgs e)
        {
            //Sem restri��es, apenas chama a nova tela

            VisualizarEstoque visualizarEstoque = new VisualizarEstoque();
            visualizarEstoque.ShowDialog();
        }

        private void Btn_AProdutos_Click(object sender, EventArgs e)
        {
            //Sem restri��es, apenas chama a nova tela

            AlterarProdutos alterarProdutos = new AlterarProdutos();
            alterarProdutos.ShowDialog();
        }

        private void Btn_MovimentarEstoque_Click(object sender, EventArgs e)
        {
            //Tem restri��es internas e outras necessidades, ent�o para usu�rio e permiss�o como par�metro

            MovimentarEstoque adicionarEstoque = new MovimentarEstoque(usuarioLogado, nivelPermissao);
            adicionarEstoque.ShowDialog();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            //Reinicia o aplicativo para sair do login
            Application.Restart();
        }
    }
}
