using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    public class AdminFisier
    {
        private const int NR_MAX_Componente = 200;
        private string numeFisier;

        public AdminFisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AdaugaComponenta(Componenta componenta)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(componenta.ConversieLaSir_PentruFisier());
            }
        }

        public Componenta[] GetComponenta(out int nrComponente)
        {
            Componenta[] componente = new Componenta[NR_MAX_Componente];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrComponente = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    componente[nrComponente++] = new Componenta(linieFisier);
                }
            }

            return componente;
        }

        public Componenta GetComponenta(string brand, string model)
        {
            
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Componenta componenta = new Componenta(linieFisier);
                    if (componenta.brand == brand && componenta.model == model)
                    {
                        return componenta;
                    }
                }
            }

            return new Componenta();
        }

        public Componenta GetComponenta(int id)
        {
            
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Componenta componenta = new Componenta(linieFisier);
                    if (componenta.idComponenta == id)
                    {
                        return componenta;
                    }
                }
            }

            return new Componenta();
        }
        

    }
}
