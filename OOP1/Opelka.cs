using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Opelka
    {
        private string jmeno;
        private string prijmeni;
        private bool hasDs = false;
        private string oblibenaOkurka;
        private List<string> jmenaPsu;

        //konstruktor
        /*public Opelka()
        {
        }*/
        public Opelka()
        {
        }
        public Opelka(string jmeno = "Opelka", string prijmeni = "Opelka")
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
        }

        public override string ToString()
        {
            return "Právě vypisuješ třídu Opelka a opelku, který se jmenuje " + jmeno;
        }
        public string Jmeno { get; set; }

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

        public string OblibenaOkurka { get; set; }

        public List<string> JmenaPsu { get; set; }

    }
}
