using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopravniSoutez
{
    public class Soutezici
    {
        private string jmeno = "";
        private string prijmeni = "";
        private int celkovyPocetBodu = 0;

        public string Jmeno
        {
            get
            {
                return jmeno;
            }

            set
            {
                jmeno = value;
            }

        }

        public string Prijmeni
        {
            get
            {
                return prijmeni;
            }

            set
            {
                prijmeni = value;
            }

        }

        public Skola Skola { get; set; }

        public enum Pohlavi
        {
            Muz,
            Zena
        }

        public enum Kategorie
        {
            Mladsi,
            Starsi
        }

        public IList<Disciplina> Discipliny { get; set; } = new List<Disciplina>();

        public int CelkovyPocetBodu
        {
            get
            {
                return celkovyPocetBodu;
            }

            set
            {
                celkovyPocetBodu = value;
            }
            
        }

    }
}
