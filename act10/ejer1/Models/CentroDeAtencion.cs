using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1.Models
{

    public class CentroDeAtencion
    {
        LinkedList<Solicitud> solicitudesPendientes = new LinkedList<Solicitud>();
        public void ImportarCsvSolicitudesEntrantes(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                Solicitud solicitud = new Solicitud();
                solicitud.Importar(linea);

                solicitudesPendientes.AddLast(solicitud);
            }
            sr.Close();
        }
        public LinkedListNode<Solicitud> GetSolicitudesPendientes()
        {
            return solicitudesPendientes.First;
        }
    }
}