using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ejer1.Models
{
    [Serializable]

    public class Solicitud : IExportable
    {
        public int Numero { get; set; }
        public string Motivo { get; set; }

        public override string ToString()
        {
            return $"{Numero}({Motivo})";
        }

        public void Importar(string linea)
        {  
            string[] datos = linea.Split(";");
            Numero = Convert.ToInt32(datos[0]);
            Motivo = datos[1];
        }
    }
}
