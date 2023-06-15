using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_PIU;

namespace Proiect_PIU
{
    public class AdminFisierCumparare
    {
        private const int NR_MAX_CUMPARARI = 200;
        private string numeFisier;

        public AdminFisierCumparare(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AdaugareCumparare(Cumpara cumpara)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(cumpara.ConversieLaSir_PentruFisier());
            }
        }

        public Cumpara[] GetCumparare(out int nrCumparari)
        {
            Cumpara[] cumparari = new Cumpara[NR_MAX_CUMPARARI];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrCumparari = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    cumparari[nrCumparari++] = new Cumpara(linieFisier);
                }
            }

            return cumparari;
        }

        public Cumpara GetCumparare(string nume, string prenume)
        {
            
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Cumpara cumpara = new Cumpara(linieFisier);
                    if (cumpara.nume == nume && cumpara.prenume == prenume)
                    {
                        return cumpara;
                    }
                }
            }

            return new Cumpara();
        }

        public Cumpara GetCumparare(int id)
        {
           
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
               
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Cumpara cumpara = new Cumpara(linieFisier);
                    if (cumpara.idCumparare == id)
                    {
                        return cumpara;
                    }
                }
            }

            return new Cumpara();
        }
    }
}
