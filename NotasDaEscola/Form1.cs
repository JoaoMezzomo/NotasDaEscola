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
    public partial class Form1 : Form
    {
        FormAdicionarDis telaAdicionarDis = new FormAdicionarDis();
        FormEditarDis telaEditar = new FormEditarDis();
        Data data = new Data();

        public Form1()
        {
            InitializeComponent();

            data.CarregarXml();

            CarregarGrid();
        }

        private void CarregarGrid() 
        {
            dataGridView1.Rows.Clear();

            XmlDocument dataArquivo = new XmlDocument();

            dataArquivo = data.CarregarXml();

            XmlNode dis = dataArquivo.SelectSingleNode("DISCIPLINAS");

            XmlNodeList disFilhas = dis.ChildNodes;

            for (int i = 0; i < disFilhas.Count; i++)
            {
                Disciplina disciplinaGrid = new Disciplina();

                disciplinaGrid.nome = disFilhas[i].Name;

                XmlNode trimestre1 = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[i].Value + "/TRIMESTRE1");
                if (!string.IsNullOrEmpty(trimestre1.InnerText))
                {
                    disciplinaGrid.trimestre1 = Convert.ToDouble(trimestre1.InnerText);
                }

                XmlNode trimestre2 = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[i].Value + "/TRIMESTRE2");
                if (!string.IsNullOrEmpty(trimestre2.InnerText))
                {
                    disciplinaGrid.trimestre2 = Convert.ToDouble(trimestre2.InnerText);
                }

                XmlNode trimestre3 = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[i].Value + "/TRIMESTRE3");
                if (!string.IsNullOrEmpty(trimestre3.InnerText))
                {
                    disciplinaGrid.trimestre3 = Convert.ToDouble(trimestre3.InnerText);
                }

                XmlNode recuperacao = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[i].Value + "/RECUPERACAO");
                if (!string.IsNullOrEmpty(recuperacao.InnerText))
                {
                    disciplinaGrid.recuperacao = Convert.ToDouble(recuperacao.InnerText);
                }

                XmlNode media = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[i].Value + "/MEDIA");
                if (!string.IsNullOrEmpty(media.InnerText))
                {
                    disciplinaGrid.media = Convert.ToDouble(media.InnerText);
                }

                XmlNode total = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[i].Value + "/TOTAL");
                if (!string.IsNullOrEmpty(total.InnerText))
                {
                    disciplinaGrid.total = Convert.ToDouble(total.InnerText);
                }

                XmlNode aprovacao = dataArquivo.SelectSingleNode("DISCIPLINAS/" + disFilhas[i].Value + "/APROVACAO");
                if (!string.IsNullOrEmpty(aprovacao.InnerText))
                {
                    disciplinaGrid.aprovacao = aprovacao.InnerText;
                }

                dataGridView1.Rows.Add(disciplinaGrid.nome, disciplinaGrid.trimestre1, disciplinaGrid.trimestre2, disciplinaGrid.trimestre3, disciplinaGrid.recuperacao, disciplinaGrid.media, disciplinaGrid.total, disciplinaGrid.aprovacao);
            }
        }

        private void btnAdicionarDis_Click(object sender, EventArgs e)
        {
            telaAdicionarDis.telaAberta = true;
            telaAdicionarDis.ShowDialog();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (telaAdicionarDis.telaAberta == false)
            {
                CarregarGrid();

                timer1.Enabled = false;
            }
        }

        private void btnEditarDis_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Você precisa selecionar uma disciplina para poder editar a mesma.", "Disciplina não selecionada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FormEditarDis telaEditarNo = new FormEditarDis(row.Index);

            telaEditarNo.ShowDialog();

            telaEditar.telaAberta = true;

            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (telaEditar.telaAberta == false)
            { 
                data.CarregarXml();

                CarregarGrid();

                timer2.Enabled = false;
            }
        }
    }
}
