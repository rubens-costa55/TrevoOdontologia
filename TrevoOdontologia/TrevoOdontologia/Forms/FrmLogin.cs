
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TrevoOdontologia.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            CarregarLogo();
        }

        private void CarregarLogo()
        {
            string caminhoLogo = Path.Combine(
                AppContext.BaseDirectory,
                "Assets",
                "TrevoLogo.jpeg");

            if (!File.Exists(caminhoLogo))
                return;

            try
            {
                using (Image imagemOriginal = Image.FromFile(caminhoLogo))
                {
                    picLogo.Image = new Bitmap(imagemOriginal);
                }
            }
            catch (Exception)
            {
                // O formulário continua funcionando se a imagem não carregar.
            }
        }

        private void chkMostrarSenha_CheckedChanged(
            object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !chkMostrarSenha.Checked;
        }

        private void lnkEsqueciSenha_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(
                "Entre em contato com o administrador do sistema para redefinir sua senha.",
                "Recuperação de senha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show(
                    "Digite seu usuário.",
                    "Trevo Odontologia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show(
                    "Digite sua senha.",
                    "Trevo Odontologia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSenha.Focus();
                return;
            }

            MessageBox.Show(
                "A tela está pronta. A autenticação será conectada ao banco de dados na próxima etapa.",
                "Trevo Odontologia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnEntrar.PerformClick();
            }
        }
    }
}
