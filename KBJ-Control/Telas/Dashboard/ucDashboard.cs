using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBJK_Control.Telas.Dashboard
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void dgvVisitasHoje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvVisitasHoje.Columns[e.ColumnIndex].Name == "colDetalhes")
            {
                var linha = dgvVisitasHoje.Rows[e.RowIndex];

                string visitante =
                    Convert.ToString(linha.Cells["colVisitante"].Value) ?? "";

                MessageBox.Show(
                    $"Visita selecionada: {visitante}",
                    "Detalhes da visita");
            }
        }

        private void PintarBordaCartao(object sender, PaintEventArgs e)
        {
            if (sender is not Panel painel)
                return;

            using (var caneta = new Pen(Color.FromArgb(212, 217, 223)))
            {
                e.Graphics.DrawRectangle(
                    caneta,
                    0,
                    0,
                    painel.ClientSize.Width - 1,
                    painel.ClientSize.Height - 1);
            }
        }

        private void dgvVisitasHoje_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvVisitasHoje.Columns[e.ColumnIndex].Name != "colSituacao")
                return;

            string situacao = Convert.ToString(e.Value)?.Trim() ?? "";

            Color cor = dgvVisitasHoje.DefaultCellStyle.ForeColor;

            if (situacao.Equals(
                "Em andamento",
                StringComparison.OrdinalIgnoreCase))
            {
                cor = Color.FromArgb(40, 100, 71);
            }
            else if (situacao.Equals(
                "Encerrada",
                StringComparison.OrdinalIgnoreCase))
            {
                cor = Color.FromArgb(180, 45, 45);
            }

            e.CellStyle.ForeColor = cor;
            e.CellStyle.SelectionForeColor = cor;
        }
    }
}
