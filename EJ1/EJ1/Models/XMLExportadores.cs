using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EJ1.Models
{
    internal class XMLExportadores
    {
        public bool Importar(string data, IExportador exportador)
        {
            Regex r = new Regex(@"");
            Match m = r.Match(data);
            if (m.Success)
            {
                string patente = m.Groups[1].Value;
                DateTime vencimiento = DateTime.ParseExact(patente, "dd/MM/yyyy", CultureInfo.InvariantCulture); 
                double importe = Convert.ToDouble(m.Groups[3].Value);
                return true;
            }
            return false;
        }
    }
}
