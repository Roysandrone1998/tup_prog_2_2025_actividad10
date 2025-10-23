using System.Runtime.Serialization.Formatters.Binary;
using ejer1.Models;

namespace ejer1
{
    public partial class Form1 : Form
    {
        CentroDeAtencion centro = new CentroDeAtencion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    centro.ImportarCsvSolicitudesEntrantes(fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();

                    }
                }
                VerSolicirudesPendientes();
            }

        }

        protected void VerSolicirudesPendientes()
        {
            lsbVerSolicitudesImportaadas.Items.Clear();
            LinkedListNode<Solicitud> nodo = centro.GetSolicitudesPendientes();

            while (nodo != null)
            {
                lsbVerSolicitudesImportaadas.Items.Add(nodo.Value);
                nodo = nodo.Next;
            }
        }

    }
}