using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopravniSoutez
{
    public class Disciplina
    {
        private string nazev = "";
        private int body = 0;

        public string Nazev
        {
            get
            {
                return nazev;
            }

            set
            {
                nazev = value;
            }

        }

        public int Body
        {
            get
            {
                return body;
            }

            set
            {
                body = value;
            }

        }
    }   
}
