using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    public class Componenta
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int idComponenta;
        public int tipComponenta;
        public string brand;
        public string model;
        public float pret;
        
        public enum tipComponente
        {
            Necunoscut = 0,
            CPU = 1,
            GPU = 2,
            Motherboard = 3,
            SSD = 4,
            PowerSupply = 5,
            Memory = 6,
            Case = 7
            
        }

        private const int idCOMPONENTA = 0;
        private const int TipCOMPONENTA = 1;
        private const int BRAND = 2;
        private const int MODEL = 3;
        private const int PRET = 4;
        



        public Componenta(int idComponenta = 0, int tipComponenta = 0, string brand = "N/A", string model = "N/A", float pret = 0.0f)
        {
            this.idComponenta= idComponenta;
            this.tipComponenta = tipComponenta;
            this.brand = brand;
            this.model = model;
            this.pret = pret;
        }



        public Componenta(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            idComponenta = int.Parse(dateFisier[idCOMPONENTA]);
            tipComponenta = int.Parse(dateFisier[TipCOMPONENTA]);
            brand = dateFisier[BRAND];
            model = dateFisier[MODEL];
            pret = float.Parse(dateFisier[PRET]);


        }

        public string ConversieLaSir_PentruFisier()
        {
            string ComponentaFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idComponenta.ToString(),
                tipComponenta,
                brand,
                model,
                pret.ToString());

            return ComponentaFisier;
        }

        public string ShowInfo()
        {
            string showINFO_componenta = string.Format("#{0}: {1} {2} {3}, {4} ",
                idComponenta.ToString(),
                (tipComponente)tipComponenta,
                brand,
                model,
                pret.ToString());

            return showINFO_componenta;
        }
    }
}
