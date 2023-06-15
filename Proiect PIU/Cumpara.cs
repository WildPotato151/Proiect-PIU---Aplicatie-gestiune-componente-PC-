using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    public class Cumpara
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int idCumparare { get; set; }
        public int idComponenta { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string adresa { get; set; }

        public const int idCUMPARARE = 0;
        public const int idCOMPONENTA = 1;
        public const int NUME = 2;
        public const int PRENUME = 3;
        public const int ADRESA = 4;

        public Cumpara(int idCumparare = 0, int idComponenta = 0, string nume ="N/A", string prenume = "N/A", string adresa = "N/A")
        {
            this.idCumparare = idCumparare;
            this.idComponenta = idComponenta;
            this.nume = nume;
            this.prenume = prenume;
            this.adresa = adresa;
        }

        public Cumpara(string linieFisier) 
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            idCumparare = int.Parse(dateFisier[idCUMPARARE]);
            idComponenta = int.Parse(dateFisier[idCOMPONENTA]);
            nume = dateFisier[NUME];
            prenume = dateFisier[PRENUME];
            adresa = dateFisier[ADRESA];
        }
        
        public string ConversieLaSir_PentruFisier()
        {
            string cumparaFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idCumparare.ToString(),
                idComponenta.ToString(),
                (nume ?? "N/A"),
                (prenume ?? "N/A"),
                (adresa ?? "N/A")); 
         
            return cumparaFisier;

        }

        public string ShowInfo()
        {
            string ShowInfo_cumparare = string.Format ("[{0}] Cumparator componenta id {1}: {2} {3}, adresa livrare: {4}",
                idCumparare.ToString(),
                idComponenta.ToString(),
                (nume ?? "N/A"),
                (prenume ?? "N/A"),
                (adresa ?? "N/A"));
            
            return ShowInfo_cumparare;
        }


     

    }
}
