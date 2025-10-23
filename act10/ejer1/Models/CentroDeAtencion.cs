using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1.Models
{

    public class CentroDeAtencion
    {
        LinkedList<Solicitud> solicitudesEntrantes = new LinkedList<Solicitud>();
        Queue<Solicitud> colaDeAtencion = new Queue<Solicitud>();
        public void ImportarCsvSolicitudesEntrantes(FileStream fs)
        {
            StreamReader sr = new StreamReader(fs);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                Solicitud solicitud = new Solicitud();
                solicitud.Importar(linea);

                solicitudesEntrantes.AddLast(solicitud);
            }
            sr.Close();
        }
        public LinkedListNode<Solicitud> GetSolicitudesPendientes()
        {
            return solicitudesEntrantes.First;
        }
        public void Atender(Solicitud soicitud)
        {
            solicitudesEntrantes.Remove(soicitud);
            colaDeAtencion.Enqueue(soicitud);
        }
        public string[] VerDescripcionColaAtencion()
        {
            string[] descripciones = new string[colaDeAtencion.Count];
            int n = 0;
            foreach (Solicitud solicitud in colaDeAtencion )
            {
                descripciones[n++]= solicitud.ToString();
            }
            return descripciones;
        }
    }
}