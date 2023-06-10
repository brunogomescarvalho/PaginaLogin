namespace PaginaLogin
{
    public partial class TelaPrincipalForm : Form
    {
        private static string _login = "abc123";
        private static string _senha = "1234";
        private static int tentativas = 0;
        public TelaPrincipalForm()
        {
            InitializeComponent();

            this.Text = "Sistema";
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;

            this.Shown += SolicitarAutenticacao;         
        }

        private void SolicitarAutenticacao(object? sender, EventArgs e)
        {
           TelaLoginForm telaLogin = new TelaLoginForm();

            DialogResult result = telaLogin.ShowDialog();
           

            if (result == DialogResult.OK)
            {
                string login = telaLogin.login;
                string senha = telaLogin.senha;

               bool validou =  ValidarLogin( senha,  login);

                if (validou == false) 
                {
                    tentativas++;

                    if (tentativas == 3)
                    {
                        MessageBox.Show("Número tentativas excedido");
                        this.Close();
                    }
                   
                    SolicitarAutenticacao(sender,e);               
                }             
            }
            else if(result == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private bool ValidarLogin(string senha, string login)
        {
            if (senha == _senha && login == _login)
            {
                this.Enabled = true;
            }
            else if (senha == _senha && login != _login)
            {
                MessageBox.Show("Login inválido");
                return false;
            }
            else if (senha != _senha && login == _login)
            {
                MessageBox.Show("Senha inválida");
                return false;
            }
            else if (senha != _senha && login != _login)
            {
                MessageBox.Show("Senha e Login inválidos");
                return false;
            }

            return true;
        }
    }
}