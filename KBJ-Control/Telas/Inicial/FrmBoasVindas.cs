using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBJK_Control.Telas.Inicial
{
    public partial class FrmBoasVindas : Form
    {
        public FrmBoasVindas()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            using (var login = new frmLogin())
            {
                login.ShowDialog();
            }

            this.Close();
        }
    }
}

