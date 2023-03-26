using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_Proiect
{
    internal class Tranzactie : ICloneable, IComparable
    {
        private int numarTranzactie;
        private double valoare;
        private List<Produs> listaProduse;

        public Tranzactie(int numarTranzactie, double valoare, List<Produs> listaProduse)
        {
            this.numarTranzactie = numarTranzactie;
            this.valoare = valoare;
            foreach(Produs produs in listaProduse)
            {
                this.listaProduse.Add(produs);
            }
        }

        public object Clone()
        {
            Tranzactie clona = (Tranzactie)this.MemberwiseClone();
            // MemberwiseClone() -> metoda a clasei Object
            // face shallow copy la toti membrii
            // facem cast la clasa noastra Tranzactie, deoarece MemberwiseClone()
            // returneaza un obiect de tip Object

            // facem deep copy la membrii ce necesita asta:
            List<Produs> listaProduse = new List<Produs>();
            foreach(Produs produs in this.listaProduse)
            {
                listaProduse.Add(produs);
            }
            clona.listaProduse = listaProduse;

            return clona;
        }

        public int CompareTo(object obj)
        {
            Tranzactie a = (Tranzactie)obj;
            if (this.valoare > a.valoare)
                return 1;
            else if (this.valoare < a.valoare)
                return -1;
            else return 0;
        }

        public override string ToString()
        {
            string output = "Numar Tranzactie: " + numarTranzactie + " Valoare: " + valoare;
            foreach(var produs in this.listaProduse)
            {
                output += produs.ToString();
            }
            return output;
        }
    }
}
