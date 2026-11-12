using KBJK_Control.Telas.Dashboard;
using KBJK_Control.Telas.Recepcao;
using KBJK_Control.Telas.Visitantes;
using KBJK_Control.Telas.Historico;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBJK_Control.Telas.Principal
{
    public partial class FrmPrincipal : Form
    {
        private readonly uint _usuarioId;

        public FrmPrincipal() : this(0)
        {
        }

        public FrmPrincipal(uint usuarioId)
        {
            _usuarioId = usuarioId;
            InitializeComponent();

            ConfigurarIcones();
            AbrirTela(new ucDashboard(usuarioId));
            SelecionarBotao(btnDashboard);
        }

        private void AbrirTela(UserControl tela)
        {
            while (pnlConteudo.Controls.Count > 0)
            {
                Control anterior = pnlConteudo.Controls[0];
                pnlConteudo.Controls.Remove(anterior);
                anterior.Dispose();
            }

            tela.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(tela);
        }

        private void ConfigurarIcones()
        {
            btnDashboard.Tag = IconChar.ChartLine;
            btnRecepcao.Tag = IconChar.DoorOpen;
            btnVisitantes.Tag = IconChar.Users;
            btnHistorico.Tag = IconChar.Clock;
            btnSair.Tag = IconChar.SignOutAlt;

            Button[] botoes =
            {
        btnDashboard, btnRecepcao, btnVisitantes,
        btnHistorico, btnSair
    };

            foreach (Button botao in botoes)
            {
                botao.ImageAlign = ContentAlignment.MiddleLeft;
                botao.TextAlign = ContentAlignment.MiddleLeft;
                botao.TextImageRelation = TextImageRelation.ImageBeforeText;
                botao.Padding = new Padding(28, 0, 0, 0);

                // Espaçamento entre o ícone e o texto.
                botao.Text = "  " + botao.Text.Trim();

                AtualizarIcone(botao);
            }
        }

        private void AtualizarIcone(Button botao)
        {
            if (botao.Tag is not IconChar icone)
                return;

            using (var gerador = new IconButton())
            {
                gerador.IconChar = icone;
                gerador.IconSize = 24;
                gerador.IconColor = botao.ForeColor;

                Image novaImagem = (Image)gerador.Image.Clone();
                Image imagemAnterior = botao.Image;

                botao.Image = novaImagem;
                imagemAnterior?.Dispose();
            }
        }

        private void SelecionarBotao(Button selecionado)
        {
            Button[] botoes =
            {
                btnDashboard,
                btnRecepcao,
                btnVisitantes,
                btnHistorico
             };

            foreach (var botao in botoes)
            {
                bool ativo = botao == selecionado;

                botao.BackColor = ativo
                    ? Color.FromArgb(232, 185, 63)
                    : Color.FromArgb(20, 34, 55);

                botao.ForeColor = ativo ? Color.Black : Color.White;
                AtualizarIcone(botao);
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucHistorico());
            SelecionarBotao(btnHistorico);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {

            AbrirTela(new ucDashboard(_usuarioId));
            SelecionarBotao(btnDashboard);

        }

        private void btnRecepcao_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucRecepcao(_usuarioId));
            SelecionarBotao(btnRecepcao);
        }

        private void btnVisitantes_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucVisitantes());
            SelecionarBotao(btnVisitantes);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var telaLogin = new frmLogin())
            {
                telaLogin.ShowDialog();
            }
            this.Close();
        }

    }
}

