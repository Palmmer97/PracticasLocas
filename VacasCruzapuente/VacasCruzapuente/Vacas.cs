using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacasCruzapuente
{
    class Vacas
    {
         public string Nombre { get; set; }
        public int TiempoMinutos { get; set; }
        public Vacas(string Nom, int Tim)
        {
            Nombre = Nom;
            TiempoMinutos = Tim;
        }
    }
}
