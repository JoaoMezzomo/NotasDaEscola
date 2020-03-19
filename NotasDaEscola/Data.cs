using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace NotasDaEscola
{
    class Data
    {
        public void AdicionarNovaDisciplina(Disciplina disciplina) 
        {
            XmlDocument data = new XmlDocument();

            data = CarregarXml();

            XmlNode dis = data.SelectSingleNode("DISCIPLINAS");

            XmlElement nome = data.CreateElement(disciplina.nome);

            dis.AppendChild(nome);

            XmlElement trimestre1 = data.CreateElement("TRIMESTRE1");
            trimestre1.InnerText = "";
            nome.AppendChild(trimestre1);

            XmlElement trimestre2 = data.CreateElement("TRIMESTRE2");
            trimestre2.InnerText = "";
            nome.AppendChild(trimestre2);

            XmlElement trimestre3 = data.CreateElement("TRIMESTRE3");
            trimestre3.InnerText = "";
            nome.AppendChild(trimestre3);

            XmlElement recuperacao = data.CreateElement("RECUPERACAO");
            recuperacao.InnerText = "";
            nome.AppendChild(recuperacao);

            XmlElement media = data.CreateElement("MEDIA");
            media.InnerText = disciplina.media.ToString();
            nome.AppendChild(media);

            XmlElement total = data.CreateElement("TOTAL");
            total.InnerText = "";
            nome.AppendChild(total);

            XmlElement aprovacao = data.CreateElement("APROVACAO");
            aprovacao.InnerText = "";
            nome.AppendChild(aprovacao);

            string diretorioData = VerificarPastaData();
            string pathArquivo = diretorioData + "\\Data.xml";

            data.Save(pathArquivo);
        }

        public void SalvarAlteracoes(Disciplina disciplina, XmlDocument data) 
        {
            XmlNode trimestre1 = data.SelectSingleNode("DISCIPLINAS/" + disciplina.nome + "/TRIMESTRE1");
            trimestre1.InnerText = disciplina.trimestre1.ToString();

            XmlNode trimestre2 = data.SelectSingleNode("DISCIPLINAS/" + disciplina.nome + "/TRIMESTRE2");
            trimestre2.InnerText = disciplina.trimestre2.ToString();

            XmlNode trimestre3 = data.SelectSingleNode("DISCIPLINAS/" + disciplina.nome + "/TRIMESTRE3");
            trimestre3.InnerText = disciplina.trimestre3.ToString();

            XmlNode recuperacao = data.SelectSingleNode("DISCIPLINAS/" + disciplina.nome + "/RECUPERACAO");
            recuperacao.InnerText = disciplina.recuperacao.ToString();

            XmlNode media = data.SelectSingleNode("DISCIPLINAS/" + disciplina.nome + "/MEDIA");
            media.InnerText = disciplina.media.ToString();

            XmlNode total = data.SelectSingleNode("DISCIPLINAS/" + disciplina.nome + "/TOTAL");
            total.InnerText = disciplina.total.ToString();

            XmlNode aprovacao = data.SelectSingleNode("DISCIPLINAS/" + disciplina.nome + "/APROVACAO");
            aprovacao.InnerText = disciplina.aprovacao;

            string diretorioData = VerificarPastaData();
            string pathArquivo = diretorioData + "\\Data.xml";

            data.Save(pathArquivo);
        }

        public XmlDocument CarregarXml()
        {
            string diretorioData = VerificarPastaData();
            string pathArquivo = diretorioData + "\\Data.xml";

            XmlDocument arquivoXml = new XmlDocument();

            if (!File.Exists(pathArquivo))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathArquivo))
                {
                    arquivoXml.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\"?>"
                    + "<DISCIPLINAS>"
                    + "</DISCIPLINAS>"
                    );
                }
                arquivoXml.Save(pathArquivo);
            }
            else
            {
                arquivoXml.Load(pathArquivo);
            }

            return arquivoXml;

        }

        public string VerificarPastaData()
        {
            string diretorioTemp = Directory.GetCurrentDirectory() + "\\Data";

            if (!Directory.Exists(diretorioTemp))
            {
                Directory.CreateDirectory(diretorioTemp);
            }

            return diretorioTemp;
        }
    }
}
