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
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {

        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnRecepcao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVisitantes_Click(object sender, EventArgs e)
        {
            
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
