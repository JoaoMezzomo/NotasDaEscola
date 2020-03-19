using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotasDaEscola
{
    public partial class FormAdicionarDis : Form
    {
        public bool telaAberta;

        public FormAdicionarDis()
        {
            InitializeComponent();

            telaAberta = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telaAberta = false;
            this.Hide();
        }

        private void FormAdicionarDis_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaAberta = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNome.Text))
            {
                MessageBox.Show("Você precisa informar o nome da Disciplina", "Nome não informado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txbMedia.Text))
            {
                MessageBox.Show("Você precisa informar a média da Disciplina", "Média não informada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            char[] verificarMedia = txbMedia.Text.ToCharArray();

            foreach (char carac in verificarMedia)
            {
                if (!char.IsNumber(carac))
                {
                    if ((carac == ',') || (carac == '.'))
                    {

                    }
                    else
                    {
                        MessageBox.Show("A média que você informou é inválida", "Média inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            Disciplina disciplina = new Disciplina();

            disciplina.nome = txbNome.Text;
            disciplina.media = Convert.ToDouble(txbMedia.Text);

            Data data = new Data();

            data.AdicionarNovaDisciplina(disciplina);

            MessageBox.Show("A disciplina " + disciplina.nome + " foi cadastrada", "Disciplina cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
