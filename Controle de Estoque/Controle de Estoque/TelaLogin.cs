using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Controle_de_Estoque
{
    public partial class TelaLogin : Form
    {
        public int NivelPermissao { get; private set; }
        public string UsuarioLogado { get; private set; }

        public TelaLogin()
        {
            InitializeComponent();
        }

        private MySqlConnection Obj_Conn = new MySqlConnection();
        private MySqlCommand Obj_CmdSQL = new MySqlCommand();
        private MySqlDataReader DadosCarregados;

        private void ExibirLogin()
        {

            //limpa os campos de registro

            UsuarioReg.Clear();
            SenhaReg.Clear();
            ConfSenhaReg.Clear();
            CodChave.Clear();
            Combo_RegAtrib.SelectedIndex = -1;


            //ocultar registro

            Label_TelaReg.Visible = false;
            Btn_ConfRegistro.Visible = false;
            Btn_CancelReg.Visible = false;
            UsuarioReg.Visible = false;
            SenhaReg.Visible = false;
            CodChave.Visible = false;
            ConfSenhaReg.Visible = false;
            Combo_RegAtrib.Visible = false;

            //exibir login

            Label_TituloLogin.Text = "Identifique-se";
            Btn_Entrar.Visible = true;
            Btn_ExibirReg.Visible = true;
            Label_TelaLogin.Visible = true;
            UsuarioLogin.Visible = true;
            SenhaLogin.Visible = true;

        }


        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            
            //Executa as validações de usuário e senha no servidor, caso aprovado, passa como parâmetro o usuário e o nível de permissão e encerra a janela.

            try
            {
                Obj_CmdSQL.CommandText = "SELECT * FROM login WHERE usuario = @usuario";
                Obj_CmdSQL.Parameters.Clear();
                Obj_CmdSQL.Parameters.AddWithValue("@usuario", UsuarioLogin.Text);

                DadosCarregados = Obj_CmdSQL.ExecuteReader();
                DadosCarregados.Read();

                if (SenhaLogin.Text == DadosCarregados["senha"].ToString())
                {
                    NivelPermissao = Convert.ToInt32(DadosCarregados["permissao"]);
                    UsuarioLogado = UsuarioLogin.Text;
                    DadosCarregados.Close();

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Senha inválida. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UsuarioLogin.Clear();
                    SenhaLogin.Clear();
                    UsuarioLogin.Focus();
                    DadosCarregados.Close();

                }


            }
            catch (Exception ex) 
            {
                MessageBox.Show("Usuário ou senha inválidos. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsuarioLogin.Clear();
                SenhaLogin.Clear();
                UsuarioLogin.Focus();
                DadosCarregados.Close();

            }


        }

        private void Btn_Registrarse_Click(object sender, EventArgs e)
        {

            UsuarioLogin.Clear();
            SenhaLogin.Clear();

            //ocultar login

            Label_TituloLogin.Text = "    Registre-se";
            Btn_Entrar.Visible = false;
            Btn_ExibirReg.Visible = false;
            Label_TelaLogin.Visible = false;
            UsuarioLogin.Visible = false;
            SenhaLogin.Visible = false;

            //exibir registro

            Label_TelaReg.Visible = true;
            Btn_ConfRegistro.Visible = true;
            Btn_CancelReg.Visible = true;
            UsuarioReg.Visible = true;
            SenhaReg.Visible = true;
            CodChave.Visible = true;
            ConfSenhaReg.Visible = true;
            Combo_RegAtrib.Visible = true;

        }

        private void TelaLogin_Load(object sender, EventArgs e)
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
        }

        private void ConfRegistro_Click(object sender, EventArgs e)
        {

            //Validações realizadas na hora do registro, para evitar dados em branco ou faltantes.

            string strSQL = "";

            if (UsuarioReg.Text == String.Empty || SenhaReg.Text == String.Empty) 
            {
                MessageBox.Show("O usuário/senha não podem ser nulos, verifique e tente novamente", "Usuário/senha nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (SenhaReg.Text != ConfSenhaReg.Text)
            {
                MessageBox.Show("As senhas fornecidas são diferentes, verifique e tente novamente.", "Senhas não condizem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SenhaReg.Clear();
                ConfSenhaReg.Clear();
                SenhaReg.Focus();
                return;
            }

            if (Combo_RegAtrib.SelectedIndex < 0 || Combo_RegAtrib.SelectedIndex > 2)
            {
                MessageBox.Show("A atribuição do usuário não pode ser nula, verifique e tente novamente", "Atribuição nula", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(CodChave.Text != "12345")
            {
                MessageBox.Show("O código chave está incorreto e é necessário para o registro, verifique e tente novamente", "Código chave incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Caso tudo dê certo, fará o registro no banco.

            strSQL = "INSERT INTO login (usuario, senha, permissao) VALUES (@Usuario, @Senha, @Permissao)";

            try
            {

                Obj_CmdSQL.CommandText = strSQL;
                Obj_CmdSQL.Parameters.AddWithValue("@Usuario", UsuarioReg.Text);
                Obj_CmdSQL.Parameters.AddWithValue("@Senha", SenhaReg.Text);
                Obj_CmdSQL.Parameters.AddWithValue("@Permissao", Combo_RegAtrib.SelectedIndex);
                Obj_CmdSQL.ExecuteNonQuery();
                Obj_CmdSQL.Parameters.Clear();

                MessageBox.Show("Registro realizado com sucesso!", "Registro realizado", MessageBoxButtons.OK);
                ExibirLogin();
                return;

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Não foi possível realizar o registro, verifique e tente novamente.", "Registro não realizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DadosCarregados.Close();
                return;
            }
            



        }

        private void Btn_CancelReg_Click(object sender, EventArgs e)
        {
            //Cancelar o registro retorna a tela de login.

            ExibirLogin();
        }
    }
}
