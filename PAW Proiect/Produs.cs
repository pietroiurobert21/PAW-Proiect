using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_Proiect
{
    [Serializable]
    public class Produs : IComparable, ICloneable
    {
        private String denumireProdus;
        private const String idProdus = ""; //Implement the password generator from the java proj into id generator
        private double pret;
        public Produs()
        {

        }
        public Produs(string denumireProdus, double pret)
        {
            this.denumireProdus = denumireProdus;
            this.pret = pret;
        }

        public string DenumireProdus { get => denumireProdus; set => denumireProdus = value; }
        public double Pret { get => pret; set => pret = value; }
        public object Clone()
        {
            Produs clona = (Produs)this.MemberwiseClone();
            return clona;
        }
        public int CompareTo(object obj)
        {
            Produs prod = (Produs)obj;
            if (pret < prod.pret)
                return -1;
            else if (pret > prod.pret)
                return 1;
            else
                return 0;
        }
        public override string ToString()
        {
            return " " + denumireProdus;// + "         Pret: " + pret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
