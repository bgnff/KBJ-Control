using KBJK_Control.Telas.Dashboard;
using KBJK_Control.Telas.Recepcao;
using KBJK_Control.Telas.Visitantes;
using KBJK_Control.Telas.Historico;
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
        public FrmPrincipal()
        {
            InitializeComponent();

            AbrirTela(new ucDashboard());
            SelecionarBotao(btnDashboard);
        }

        private void AbrirTela(UserControl tela)
        {
            // Libera a tela anterior.
            while (pnlConteudo.Controls.Count > 0)
            {
                var anterior = pnlConteudo.Controls[0];
                pnlConteudo.Controls.Remove(anterior);
                anterior.Dispose();
            }

            tela.Dock = DockStyle.Fill;
            pnlConteudo.Controls.Add(tela);
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
                    ? Color.FromArgb(212, 165, 30)
                    : Color.FromArgb(37, 45, 56);

                botao.ForeColor = ativo ? Color.Black : Color.White;
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucHistorico());
            SelecionarBotao(btnHistorico);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {

            AbrirTela(new ucDashboard());
            SelecionarBotao(btnDashboard);

        }

        private void btnRecepcao_Click(object sender, EventArgs e)
        {
            AbrirTela(new ucRecepcao());
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
