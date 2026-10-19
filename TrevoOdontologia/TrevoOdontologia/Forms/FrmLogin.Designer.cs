
namespace TrevoOdontologia.Forms
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlMarca;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNomeClinica;
        private System.Windows.Forms.Label lblDescricaoMarca;
        private System.Windows.Forms.Label lblVersao;

        private System.Windows.Forms.TableLayoutPanel tlpConteudo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TableLayoutPanel tlpLogin;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox chkMostrarSenha;
        private System.Windows.Forms.LinkLabel lnkEsqueciSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblRodape;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tlpPrincipal = new TableLayoutPanel();
            pnlMarca = new Panel();
            lblDescricaoMarca = new Label();
            lblNomeClinica = new Label();
            picLogo = new PictureBox();
            lblVersao = new Label();
            tlpConteudo = new TableLayoutPanel();
            pnlLogin = new Panel();
            tlpLogin = new TableLayoutPanel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            chkMostrarSenha = new CheckBox();
            lnkEsqueciSenha = new LinkLabel();
            btnEntrar = new Button();
            btnSair = new Button();
            lblRodape = new Label();
            tlpPrincipal.SuspendLayout();
            pnlMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            tlpConteudo.SuspendLayout();
            pnlLogin.SuspendLayout();
            tlpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tlpPrincipal.Controls.Add(pnlMarca, 0, 0);
            tlpPrincipal.Controls.Add(tlpConteudo, 1, 0);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Margin = new Padding(0);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 1;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.Size = new Size(1000, 650);
            tlpPrincipal.TabIndex = 0;
            // 
            // pnlMarca
            // 
            pnlMarca.BackColor = Color.FromArgb(23, 105, 76);
            pnlMarca.Controls.Add(lblDescricaoMarca);
            pnlMarca.Controls.Add(lblNomeClinica);
            pnlMarca.Controls.Add(picLogo);
            pnlMarca.Controls.Add(lblVersao);
            pnlMarca.Dock = DockStyle.Fill;
            pnlMarca.Location = new Point(3, 3);
            pnlMarca.Name = "pnlMarca";
            pnlMarca.Padding = new Padding(24);
            pnlMarca.Size = new Size(414, 644);
            pnlMarca.TabIndex = 0;
            // 
            // lblDescricaoMarca
            // 
            lblDescricaoMarca.Dock = DockStyle.Top;
            lblDescricaoMarca.Font = new Font("Segoe UI", 11F);
            lblDescricaoMarca.ForeColor = Color.FromArgb(225, 242, 233);
            lblDescricaoMarca.Location = new Point(24, 269);
            lblDescricaoMarca.Name = "lblDescricaoMarca";
            lblDescricaoMarca.Size = new Size(366, 65);
            lblDescricaoMarca.TabIndex = 0;
            lblDescricaoMarca.Text = "Cuidado, organização e confiança\nem um só lugar.";
            lblDescricaoMarca.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNomeClinica
            // 
            lblNomeClinica.Dock = DockStyle.Top;
            lblNomeClinica.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblNomeClinica.ForeColor = Color.White;
            lblNomeClinica.Location = new Point(24, 214);
            lblNomeClinica.Name = "lblNomeClinica";
            lblNomeClinica.Size = new Size(366, 55);
            lblNomeClinica.TabIndex = 1;
            lblNomeClinica.Text = "Trevo Odontologia";
            lblNomeClinica.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Dock = DockStyle.Top;
            picLogo.Location = new Point(24, 24);
            picLogo.Margin = new Padding(0, 0, 0, 20);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(366, 190);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblVersao
            // 
            lblVersao.Dock = DockStyle.Bottom;
            lblVersao.Font = new Font("Segoe UI", 8.5F);
            lblVersao.ForeColor = Color.FromArgb(225, 242, 233);
            lblVersao.Location = new Point(24, 592);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(366, 28);
            lblVersao.TabIndex = 3;
            lblVersao.Text = "Sistema de Gestão Odontológica";
            lblVersao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpConteudo
            // 
            tlpConteudo.BackColor = Color.FromArgb(248, 250, 249);
            tlpConteudo.ColumnCount = 3;
            tlpConteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpConteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpConteudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpConteudo.Controls.Add(pnlLogin, 1, 1);
            tlpConteudo.Controls.Add(lblRodape, 1, 2);
            tlpConteudo.Dock = DockStyle.Fill;
            tlpConteudo.Location = new Point(420, 0);
            tlpConteudo.Margin = new Padding(0);
            tlpConteudo.Name = "tlpConteudo";
            tlpConteudo.Padding = new Padding(20);
            tlpConteudo.RowCount = 3;
            tlpConteudo.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpConteudo.RowStyles.Add(new RowStyle(SizeType.Percent, 76F));
            tlpConteudo.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpConteudo.Size = new Size(580, 650);
            tlpConteudo.TabIndex = 1;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlLogin.Controls.Add(tlpLogin);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(77, 96);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Padding = new Padding(24);
            pnlLogin.Size = new Size(426, 457);
            pnlLogin.TabIndex = 0;
            // 
            // tlpLogin
            // 
            tlpLogin.ColumnCount = 1;
            tlpLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLogin.Controls.Add(lblTitulo, 0, 0);
            tlpLogin.Controls.Add(lblSubtitulo, 0, 1);
            tlpLogin.Controls.Add(lblUsuario, 0, 2);
            tlpLogin.Controls.Add(txtUsuario, 0, 3);
            tlpLogin.Controls.Add(lblSenha, 0, 4);
            tlpLogin.Controls.Add(txtSenha, 0, 5);
            tlpLogin.Controls.Add(chkMostrarSenha, 0, 6);
            tlpLogin.Controls.Add(lnkEsqueciSenha, 0, 7);
            tlpLogin.Controls.Add(btnEntrar, 0, 8);
            tlpLogin.Controls.Add(btnSair, 0, 9);
            tlpLogin.Dock = DockStyle.Fill;
            tlpLogin.Location = new Point(24, 24);
            tlpLogin.Margin = new Padding(0);
            tlpLogin.Name = "tlpLogin";
            tlpLogin.RowCount = 10;
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tlpLogin.Size = new Size(376, 407);
            tlpLogin.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(35, 55, 46);
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(370, 61);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bem-vindo!";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Dock = DockStyle.Fill;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(105, 120, 112);
            lblSubtitulo.Location = new Point(3, 61);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(370, 36);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Entre com seus dados para continuar.";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.ForeColor = Color.FromArgb(45, 60, 52);
            lblUsuario.Location = new Point(3, 97);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(370, 28);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuário";
            lblUsuario.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Dock = DockStyle.Fill;
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(0, 130);
            txtUsuario.Margin = new Padding(0, 5, 0, 8);
            txtUsuario.MaxLength = 100;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(376, 29);
            txtUsuario.TabIndex = 0;
            // 
            // lblSenha
            // 
            lblSenha.Dock = DockStyle.Fill;
            lblSenha.ForeColor = Color.FromArgb(45, 60, 52);
            lblSenha.Location = new Point(3, 169);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(370, 28);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            lblSenha.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Dock = DockStyle.Fill;
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(0, 202);
            txtSenha.Margin = new Padding(0, 5, 0, 5);
            txtSenha.MaxLength = 100;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(376, 29);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // chkMostrarSenha
            // 
            chkMostrarSenha.Dock = DockStyle.Fill;
            chkMostrarSenha.Font = new Font("Segoe UI", 9F);
            chkMostrarSenha.ForeColor = Color.FromArgb(75, 90, 82);
            chkMostrarSenha.Location = new Point(3, 244);
            chkMostrarSenha.Name = "chkMostrarSenha";
            chkMostrarSenha.Size = new Size(370, 26);
            chkMostrarSenha.TabIndex = 2;
            chkMostrarSenha.Text = "Mostrar senha";
            chkMostrarSenha.CheckedChanged += chkMostrarSenha_CheckedChanged;
            // 
            // lnkEsqueciSenha
            // 
            lnkEsqueciSenha.ActiveLinkColor = Color.FromArgb(15, 75, 53);
            lnkEsqueciSenha.Dock = DockStyle.Fill;
            lnkEsqueciSenha.Font = new Font("Segoe UI", 9F);
            lnkEsqueciSenha.LinkColor = Color.FromArgb(23, 105, 76);
            lnkEsqueciSenha.Location = new Point(3, 273);
            lnkEsqueciSenha.Name = "lnkEsqueciSenha";
            lnkEsqueciSenha.Size = new Size(370, 32);
            lnkEsqueciSenha.TabIndex = 3;
            lnkEsqueciSenha.TabStop = true;
            lnkEsqueciSenha.Text = "Esqueci minha senha";
            lnkEsqueciSenha.TextAlign = ContentAlignment.MiddleRight;
            lnkEsqueciSenha.VisitedLinkColor = Color.FromArgb(23, 105, 76);
            lnkEsqueciSenha.LinkClicked += lnkEsqueciSenha_LinkClicked;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(23, 105, 76);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Dock = DockStyle.Fill;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(0, 313);
            btnEntrar.Margin = new Padding(0, 8, 0, 8);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(376, 32);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.White;
            btnSair.Cursor = Cursors.Hand;
            btnSair.Dock = DockStyle.Fill;
            btnSair.FlatAppearance.BorderColor = Color.FromArgb(210, 220, 214);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F);
            btnSair.ForeColor = Color.FromArgb(75, 90, 82);
            btnSair.Location = new Point(0, 358);
            btnSair.Margin = new Padding(0, 5, 0, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(376, 44);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // lblRodape
            // 
            lblRodape.Dock = DockStyle.Fill;
            lblRodape.Font = new Font("Segoe UI", 8.5F);
            lblRodape.ForeColor = Color.FromArgb(125, 135, 129);
            lblRodape.Location = new Point(77, 556);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(426, 74);
            lblRodape.TabIndex = 1;
            lblRodape.Text = "Acesso restrito a usuários autorizados";
            lblRodape.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            CancelButton = btnSair;
            ClientSize = new Size(1000, 650);
            Controls.Add(tlpPrincipal);
            Font = new Font("Segoe UI", 10F);
            KeyPreview = true;
            MinimumSize = new Size(760, 540);
            Name = "FrmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trevo Odontologia - Login";
            tlpPrincipal.ResumeLayout(false);
            pnlMarca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            tlpConteudo.ResumeLayout(false);
            pnlLogin.ResumeLayout(false);
            tlpLogin.ResumeLayout(false);
            tlpLogin.PerformLayout();
            ResumeLayout(false);
        }
    }
}
