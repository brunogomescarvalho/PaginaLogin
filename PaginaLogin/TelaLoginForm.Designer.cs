namespace PaginaLogin
{
    partial class TelaLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelar = new Button();
            btnOk = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            labelSenha = new Label();
            labelLogin = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(248, 190);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 48);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(130, 190);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 48);
            btnOk.TabIndex = 10;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(93, 111);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(249, 27);
            txtSenha.TabIndex = 9;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(93, 43);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(249, 27);
            txtLogin.TabIndex = 8;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(37, 111);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(52, 20);
            labelSenha.TabIndex = 7;
            labelSenha.Text = "Senha:";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(37, 46);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(49, 20);
            labelLogin.TabIndex = 6;
            labelLogin.Text = "Login:";
            // 
            // TelaLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 283);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(labelSenha);
            Controls.Add(labelLogin);
            Name = "TelaLoginForm";
            Text = "TelaLoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label labelSenha;
        private Label labelLogin;
    }
}