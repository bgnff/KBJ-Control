using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using KBJK_Control.Controles;

namespace KBJK_Control.Telas.Dashboard
{
    public partial class FrmCadastrarVisitante : Form
    {
        public FrmCadastrarVisitante()
        {
            InitializeComponent();
            Icon = IconeAplicacao.Criar();
            AnimacaoUI.AplicarHoverBotoes(this);
            AnimacaoUI.AnimarAbertura(this);
            EstiloTabela.AplicarCampo(txtNome);
            EstiloTabela.AplicarCampo(txtSobrenome);
            EstiloTabela.AplicarCampo(cbxTipoDocumento);
            EstiloTabela.AplicarCampo(textBox1);
            EstiloTabela.AplicarCampo(cbxEmissor);
            EstiloTabela.AplicarBotao(btnCancelar);
            EstiloTabela.AplicarBotao(btnSalvarCadastro);
            cbxTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoDocumento.Items.AddRange(new object[] { "RG", "CPF", "PASSAPORTE" });
            cbxEmissor.Items.Add("Brasil");
            cbxEmissor.Text = "Brasil";
            txtNome.MaxLength = 30;
            txtSobrenome.MaxLength = 30;
            textBox1.MaxLength = 20;
            cbxEmissor.MaxLength = 30;
            btnCancelar.Click += (_, _) => Close();
            btnFechar.Click += (_, _) => Close();
            btnSalvarCadastro.Click += SalvarCadastro;
            AcceptButton = btnSalvarCadastro;
            CancelButton = btnCancelar;
            Shown += (_, _) => AplicarArredondamentos();
            Resize += (_, _) => AplicarArredondamentos();
        }

        private void AplicarArredondamentos()
        {
            Region = CriarRegiaoArredondada(ClientRectangle, 14);
        }

        private static Region CriarRegiaoArredondada(Rectangle area, int raio)
        {
            using GraphicsPath caminho = new GraphicsPath();
            int diametro = raio * 2;
            caminho.AddArc(area.Left, area.Top, diametro, diametro, 180, 90);
            caminho.AddArc(area.Right - diametro, area.Top, diametro, diametro, 270, 90);
            caminho.AddArc(area.Right - diametro, area.Bottom - diametro, diametro, diametro, 0, 90);
            caminho.AddArc(area.Left, area.Bottom - diametro, diametro, diametro, 90, 90);
            caminho.CloseFigure();
            return new Region(caminho);
        }

        private void SalvarCadastro(object? sender, EventArgs e)
        {
            var nome = txtNome.Text.Trim();
            var sobrenome = txtSobrenome.Text.Trim();
            var documento = textBox1.Text.Trim();
            var pais = cbxEmissor.Text.Trim();
            if (nome.Length == 0 || sobrenome.Length == 0 || cbxTipoDocumento.SelectedItem is not string tipo || documento.Length == 0 || pais.Length == 0)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Cadastro de visitante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                new VisitanteRepository().Cadastrar(nome, sobrenome, tipo, documento, pais);
                MessageBox.Show("Visitante cadastrado com sucesso.", "Cadastro de visitante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (MySqlConnector.MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("Já existe um visitante com esse documento e país emissor.", "Documento já cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (MySqlConnector.MySqlException)
            {
                MessageBox.Show("Não foi possível salvar o visitante. Verifique a conexão com o banco e tente novamente.", "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblNomeCadastro1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
