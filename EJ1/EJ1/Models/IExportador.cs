using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EJ1.Models
{
    public interface IExportador
    {
        bool Importar(string data, Multa m);
        string Exportar(Multa m);
    }
}
