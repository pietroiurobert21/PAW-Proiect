using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_Proiect
{
    [Serializable]
    public class Tranzactie : ICloneable, IComparable, IDGenerator
    {
        private string idTranzactie;
        private double valoare;
        private string username;
        //private List<Produs> listaProduse;

        public Tranzactie()
        {
            idTranzactie = "";
            valoare = 0.0;
        }

        public Tranzactie(string numarTranzactie, double valoare, string username)//, List<Produs> listaProduse)
        {
            this.idTranzactie = numarTranzactie;
            this.valoare = valoare;
            this.username = username;
            // foreach(Produs produs in listaProduse)
            // {
            //     this.listaProduse.Add(produs);
            //}
        }

        public string IdTranzactie { get => idTranzactie; set => idTranzactie = value; }
        public double Valoare { get => valoare; set => valoare = value; }

        public string Username { get => username; set => username = value; }
        public object Clone()
        {
            Tranzactie clona = (Tranzactie)this.MemberwiseClone();
            // MemberwiseClone() -> metoda a clasei Object
            // face shallow copy la toti membrii
            // facem cast la clasa noastra Tranzactie, deoarece MemberwiseClone()
            // returneaza un obiect de tip Object

            // facem deep copy la membrii ce necesita asta:
            //List<Produs> listaProduse = new List<Produs>();
            //foreach(Produs produs in this.listaProduse)
            //{
            //    listaProduse.Add(produs);
            //}
            //clona.listaProduse = listaProduse;

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

        public string generateID(int length)
        {
            string ID = "id";
            char x = 'A', y = 'a';
            List<char> upper = new List<char>();
            List<char> lower = new List<char>();

            for (int i = 0; i < 25; i++)
            { // 25 letters from the Alphabet
                upper.Add((char)(x + i));
                lower.Add((char)(y + i));
            }
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                int randomIndex = rand.Next(upper.Count);
                int use_digits = rand.Next(2); //0 - use digit, 1 - use letter
                if (use_digits == 0)
                    ID += rand.Next(10);
                else
                    ID += upper[randomIndex];
            }
            return ID;
        }
    }
}
