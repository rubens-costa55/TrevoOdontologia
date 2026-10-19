
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace TrevoOdontologia.Forms
{
    public partial class FrmSplash : Form
    {
        private readonly System.Windows.Forms.Timer timerCarregamento;

        private int progresso;
        private float faseAnimacao;
        private bool abrindoLogin;

        public FrmSplash()
        {
            InitializeComponent();

            timerCarregamento = new System.Windows.Forms.Timer();
            timerCarregamento.Interval = 35;
            timerCarregamento.Tick += TimerCarregamento_Tick;

            Load += FrmSplash_Load;
            FormClosed += FrmSplash_FormClosed;
        }

        private void FrmSplash_Load(object? sender, EventArgs e)
        {
            CarregarLogo();

            progresso = 0;
            faseAnimacao = 0;
            abrindoLogin = false;

            prgCarregamento.Value = 0;
            lblStatus.Text = "Preparando o sistema...";
            lblMensagem.Text = "Cuidando do seu sorriso...";

            timerCarregamento.Start();
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
                // A tela continua funcionando sem a logo.
            }
        }

        private void TimerCarregamento_Tick(object? sender, EventArgs e)
        {
            faseAnimacao += 0.08F;

            if (faseAnimacao >= Math.PI * 2)
                faseAnimacao = 0;

            picTrevo.Invalidate();

            if (progresso < 100)
            {
                progresso = Math.Min(progresso + 2, 100);
                prgCarregamento.Value = progresso;

                if (progresso < 30)
                    lblStatus.Text = "Preparando o ambiente...";
                else if (progresso < 60)
                    lblStatus.Text = "Carregando componentes...";
                else if (progresso < 90)
                    lblStatus.Text = "Finalizando inicialização...";
                else
                    lblStatus.Text = "Quase pronto...";

                return;
            }

            if (abrindoLogin)
                return;

            abrindoLogin = true;
            timerCarregamento.Stop();

            AbrirLogin();
        }

        private void picTrevo_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            float largura = picTrevo.ClientSize.Width;
            float altura = picTrevo.ClientSize.Height;

            if (largura <= 0 || altura <= 0)
                return;

            float escalaBase = Math.Min(largura / 100F, altura / 65F);
            float pulsacao =
                1F + 0.04F * (float)Math.Sin(faseAnimacao);
            float escala = escalaBase * pulsacao;

            g.TranslateTransform(largura / 2F, altura / 2F);
            g.ScaleTransform(escala, escala);

            Color verdeEscuro = Color.FromArgb(23, 105, 76);
            Color verdeClaro = Color.FromArgb(48, 139, 101);

            using (SolidBrush folhaEscura = new SolidBrush(verdeEscuro))
            using (SolidBrush folhaClara = new SolidBrush(verdeClaro))
            using (Pen contorno = new Pen(verdeEscuro, 1F))
            using (Pen haste = new Pen(verdeEscuro, 3F))
            {
                haste.StartCap = LineCap.Round;
                haste.EndCap = LineCap.Round;

                // Quatro folhas do trevo.
                g.FillEllipse(folhaEscura, -22, -23, 21, 21);
                g.DrawEllipse(contorno, -22, -23, 21, 21);

                g.FillEllipse(folhaClara, 1, -23, 21, 21);
                g.DrawEllipse(contorno, 1, -23, 21, 21);

                g.FillEllipse(folhaClara, -22, 0, 21, 21);
                g.DrawEllipse(contorno, -22, 0, 21, 21);

                g.FillEllipse(folhaEscura, 1, 0, 21, 21);
                g.DrawEllipse(contorno, 1, 0, 21, 21);

                // Centro e haste.
                g.FillEllipse(folhaEscura, -4, -4, 8, 8);
                g.DrawLine(haste, 0, 5, 0, 23);
            }

            g.ResetTransform();
        }

        private void AbrirLogin()
        {
            Hide();

            try
            {
                using (FrmLogin frmLogin = new FrmLogin())
                {
                    frmLogin.ShowDialog();
                }
            }
            finally
            {
                Close();
            }
        }

        private void FrmSplash_FormClosed(
            object? sender, FormClosedEventArgs e)
        {
            timerCarregamento.Stop();
            timerCarregamento.Dispose();

            if (picLogo.Image != null)
            {
                picLogo.Image.Dispose();
                picLogo.Image = null;
            }
        }
    }
}
