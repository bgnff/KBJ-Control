using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBJK_Control.Telas.Historico
{
    public partial class ucHistorico : UserControl
    {
        public ucHistorico()
        {
            InitializeComponent();
            cmbSituacaoHistorico.SelectedIndex = 0;
        }

        private void dgvHistorico_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvHistorico.Columns[e.ColumnIndex].Name != "colSituacao")
                return;

            string situacao = Convert.ToString(e.Value)?.Trim() ?? "";

            Color cor = dgvHistorico.DefaultCellStyle.ForeColor;

            if (situacao.Equals("Em andamento",
                StringComparison.OrdinalIgnoreCase))
            {
                cor = Color.FromArgb(40, 100, 71);
            }
            else if (situacao.Equals("Encerrada",
                StringComparison.OrdinalIgnoreCase))
            {
                cor = Color.FromArgb(180, 45, 45);
            }
        }

        private void cmbSituacaoHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}