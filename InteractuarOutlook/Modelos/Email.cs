using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractuarOutlook.Modelos {
    public class Email {
        public string Emisor { get; set; }
        public string EmailEmisor { get; set; }
        public string Carpeta { get; set; }
        public string Receptor { get; set; }
        public string Cuerpo { get; set; }
        public string Asunto { get; set; }
        public string FechaRecibo { get; set; }
        public string Enviado { get; set; }
        public string Cuenta { get; set; }
    }
}
