
namespace TrevoOdontologia.Forms
{
    partial class FrmSplash
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picTrevo;
        private System.Windows.Forms.Label lblNomeClinica;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.ProgressBar prgCarregamento;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVersao;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            picLogo = new System.Windows.Forms.PictureBox();
            picTrevo = new System.Windows.Forms.PictureBox();
            lblNomeClinica = new System.Windows.Forms.Label();
            lblMensagem = new System.Windows.Forms.Label();
            prgCarregamento = new System.Windows.Forms.ProgressBar();
            lblStatus = new System.Windows.Forms.Label();
            lblVersao = new System.Windows.Forms.Label();

            tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTrevo).BeginInit();
            SuspendLayout();

            // FORMULÁRIO
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(800, 550);
            MinimumSize = new System.Drawing.Size(650, 500);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Trevo Odontologia";
            Name = "FrmSplash";
            MaximizeBox = true;
            MinimizeBox = true;
            ShowIcon = false;
            Font = new System.Drawing.Font("Segoe UI", 10F);

            // LAYOUT PRINCIPAL
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPrincipal.BackColor = System.Drawing.Color.White;
            tlpPrincipal.Padding =
                new System.Windows.Forms.Padding(40, 20, 40, 20);
            tlpPrincipal.Margin = new System.Windows.Forms.Padding(0);
            tlpPrincipal.ColumnCount = 1;
            tlpPrincipal.RowCount = 7;

            tlpPrincipal.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(
                    System.Windows.Forms.SizeType.Percent, 100F));

            tlpPrincipal.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 35F));
            tlpPrincipal.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 70F));
            tlpPrincipal.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 17F));
            tlpPrincipal.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 10F));
            tlpPrincipal.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Absolute, 16F));
            tlpPrincipal.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 12F));
            tlpPrincipal.RowStyles.Add(
                new System.Windows.Forms.RowStyle(
                    System.Windows.Forms.SizeType.Percent, 26F));

            // LOGO
            picLogo.Name = "picLogo";
            picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            picLogo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            picLogo.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picLogo.BackColor = System.Drawing.Color.Transparent;
            picLogo.TabStop = false;

            // TREVO ANIMADO
            picTrevo.Name = "picTrevo";
            picTrevo.Dock = System.Windows.Forms.DockStyle.Fill;
            picTrevo.Margin = new System.Windows.Forms.Padding(0);
            picTrevo.BackColor = System.Drawing.Color.Transparent;
            picTrevo.TabStop = false;
            picTrevo.Paint += new System.Windows.Forms.PaintEventHandler(
                picTrevo_Paint);

            // NOME DA CLÍNICA
            lblNomeClinica.Name = "lblNomeClinica";
            lblNomeClinica.Dock = System.Windows.Forms.DockStyle.Fill;
            lblNomeClinica.Text = "Trevo Odontologia";
            lblNomeClinica.Font = new System.Drawing.Font(
                "Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            lblNomeClinica.ForeColor =
                System.Drawing.Color.FromArgb(23, 105, 76);
            lblNomeClinica.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;
            lblNomeClinica.Margin = new System.Windows.Forms.Padding(0);

            // MENSAGEM
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Dock = System.Windows.Forms.DockStyle.Fill;
            lblMensagem.Text = "Cuidando do seu sorriso...";
            lblMensagem.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblMensagem.ForeColor =
                System.Drawing.Color.FromArgb(100, 110, 104);
            lblMensagem.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;
            lblMensagem.Margin = new System.Windows.Forms.Padding(0);

            // BARRA DE PROGRESSO
            prgCarregamento.Name = "prgCarregamento";
            prgCarregamento.Dock = System.Windows.Forms.DockStyle.Fill;
            prgCarregamento.Minimum = 0;
            prgCarregamento.Maximum = 100;
            prgCarregamento.Value = 0;
            prgCarregamento.Style =
                System.Windows.Forms.ProgressBarStyle.Continuous;
            prgCarregamento.Margin = new System.Windows.Forms.Padding(0);

            // STATUS
            lblStatus.Name = "lblStatus";
            lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            lblStatus.Text = "Preparando o sistema...";
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblStatus.ForeColor =
                System.Drawing.Color.FromArgb(23, 105, 76);
            lblStatus.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;
            lblStatus.Margin = new System.Windows.Forms.Padding(0);

            // RODAPÉ
            lblVersao.Name = "lblVersao";
            lblVersao.Dock = System.Windows.Forms.DockStyle.Fill;
            lblVersao.Text = "Sistema de Gestão Odontológica";
            lblVersao.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblVersao.ForeColor =
                System.Drawing.Color.FromArgb(140, 145, 141);
            lblVersao.TextAlign =
                System.Drawing.ContentAlignment.BottomCenter;
            lblVersao.Margin = new System.Windows.Forms.Padding(0);

            // ORGANIZAÇÃO DOS CONTROLES
            tlpPrincipal.Controls.Add(picLogo, 0, 0);
            tlpPrincipal.Controls.Add(picTrevo, 0, 1);
            tlpPrincipal.Controls.Add(lblNomeClinica, 0, 2);
            tlpPrincipal.Controls.Add(lblMensagem, 0, 3);
            tlpPrincipal.Controls.Add(prgCarregamento, 0, 4);
            tlpPrincipal.Controls.Add(lblStatus, 0, 5);
            tlpPrincipal.Controls.Add(lblVersao, 0, 6);

            Controls.Add(tlpPrincipal);

            tlpPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTrevo).EndInit();
            ResumeLayout(false);
        }
    }
}
