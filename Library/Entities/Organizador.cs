using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Organizador
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string TipoProyecto { get; set; }
        public string HistorialImpacto { get; set; }
        public string Disponibilidad { get; set; }


    }
}
