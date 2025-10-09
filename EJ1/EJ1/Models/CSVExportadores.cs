using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1.Models
{
    internal class CSVExportadores
    {
        public string Exportar(Multa m)
        {
            throw new NotImplementedException();
        }
        public bool Importar (string data, Multa multa)
        {
            string[] Campos = data.Split(';');
            string patente = Campos [0];
        }
    }
}
