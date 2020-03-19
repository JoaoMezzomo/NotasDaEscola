using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasDaEscola
{
    class Disciplina
    {
        public string nome { get; set; }

        public double trimestre1 { get; set; }

        public double trimestre2 { get; set; }

        public double trimestre3 { get; set; }

        public double recuperacao { get; set; }

        public double media { get; set; }

        public double total { get; set; }

        public string aprovacao { get; set; }
    }
}
