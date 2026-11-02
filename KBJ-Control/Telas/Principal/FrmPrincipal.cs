using KBJK_Control.Telas.Dashboard;
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

            var dashboard = new ucDashboard();
            dashboard.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(dashboard);
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
    }
}
