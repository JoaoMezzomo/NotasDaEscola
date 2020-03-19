using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace NotasDaEscola
{
    public partial class FormEditarDis : Form
    {
        public bool telaAberta;

        Data data = new Data();

        XmlDocument dataArquivoSalvar;

        Disciplina disciplinaSalvar;

        public FormEditarDis()
        {
            InitializeComponent();
        }

        public FormEditarDis(int index)
        {
            InitializeComponent();

            CarregarInformações(index);
        }

        private void CarregarInformações(int index)
        {
            XmlDocument dataArquivo = new XmlDocument();

            dataArquivo = data.CarregarXml();

            XmlNode dis = dataArquivo.SelectSingleNode("DISCIPLINAS");

            XmlNodeList disFilhas = dis.ChildNodes;

            
            Disciplina disciplinaGrid = new Disciplina();

            disciplinaGrid.nome = disFilhas[index].Name;

            XmlNode trimestre1 = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[index].Value + "/TRIMESTRE1");
            if (!string.IsNullOrEmpty(trimestre1.InnerText))
            {
                disciplinaGrid.trimestre1 = Convert.ToDouble(trimestre1.InnerText);
            }

            XmlNode trimestre2 = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[index].Value + "/TRIMESTRE2");
            if (!string.IsNullOrEmpty(trimestre2.InnerText))
            {
                disciplinaGrid.trimestre2 = Convert.ToDouble(trimestre2.InnerText);
            }

            XmlNode trimestre3 = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[index].Value + "/TRIMESTRE3");
            if (!string.IsNullOrEmpty(trimestre3.InnerText))
            {
                disciplinaGrid.trimestre3 = Convert.ToDouble(trimestre3.InnerText);
            }

            XmlNode recuperacao = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[index].Value + "/RECUPERACAO");
            if (!string.IsNullOrEmpty(recuperacao.InnerText))
            {
                disciplinaGrid.recuperacao = Convert.ToDouble(recuperacao.InnerText);
            }

            XmlNode media = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[index].Value + "/MEDIA");
            if (!string.IsNullOrEmpty(media.InnerText))
            {
                disciplinaGrid.media = Convert.ToDouble(media.InnerText);
            }

            XmlNode total = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[index].Value + "/TOTAL");
            if (!string.IsNullOrEmpty(total.InnerText))
            {
                disciplinaGrid.total = Convert.ToDouble(total.InnerText);
            }

            XmlNode aprovacao = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[index].Value + "/APROVACAO");
            if (!string.IsNullOrEmpty(aprovacao.InnerText))
            {
                disciplinaGrid.aprovacao = aprovacao.InnerText;
            }

            txbNome.Text = disciplinaGrid.nome;
            txbTrimestre1.Text = disciplinaGrid.trimestre1.ToString();
            txbTrimestre2.Text = disciplinaGrid.trimestre2.ToString();
            txbTrimestre3.Text = disciplinaGrid.trimestre3.ToString();
            txbRecuperacao.Text = disciplinaGrid.recuperacao.ToString();
            txbMedia.Text = disciplinaGrid.media.ToString();

            dataArquivoSalvar = dataArquivo;

            disciplinaSalvar = disciplinaGrid;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            data.SalvarAlteracoes(disciplinaSalvar, dataArquivoSalvar);

            MessageBox.Show("Suas alterações para a disciplina: " + disciplinaSalvar.nome +" foram salvas", "Alterações salvas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telaAberta = false;
            this.Hide();
        }
    }
}
