using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1.Models
{
    public class Multa : IExportable, IComparable
    {

        public string Patente { get; set; }
        public DateTime Vencimiento { get; set; }
        public double Importe { get; set; }

        public int CompareTo(object otherObject)
        {
            Multa other = otherObject as Multa;
            if (other != null)
            {
                return this.Patente.CompareTo(other.Patente);
            }
           return -1;
        }
        public string Exportar(IExportador exportador)
        {
           return exportador.Exportar(this);
        }

        public bool Importar(string data, IExportador exportador)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Patente} (venc.: {Vencimiento: dd/MM/yyyy} Importe:{Importe}";
        }

    }
}
