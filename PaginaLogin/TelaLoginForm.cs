using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginaLogin
{
    public partial class TelaLoginForm : Form
    {
        public string login { get; private set; }
        public string senha { get; private set; }

        public TelaLoginForm()
        {
            InitializeComponent();

            this.Text = "Login";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterParent;
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.login = txtLogin.Text;
            this.senha = txtSenha.Text;

            if(login == string.Empty || senha == string.Empty)
            {
                DialogResult = DialogResult.None;
            }
        }
    }
}
