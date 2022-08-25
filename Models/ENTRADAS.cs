using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCine.Models
{
    public class ENTRADAS
    {
        // PROPIEDADES:
        // digitar "prop" y presionar 2
        // veces la tecla TAB
        public int NroEntrada { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string NombrePelicula { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe {
            get {
                return Precio * Cantidad;
            }
        }
    }
}
