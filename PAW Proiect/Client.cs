using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_Proiect
{
    [Serializable]
    public class Client : ICloneable, IComparable, IDGenerator
    {
        private String nume;
        private String email;
        private String password;
        private String telefon;
        public Client()
        {
            nume = email = password = telefon = "";
        }
        public Client(string nume, string email, string telefon, string password)
        {
            this.nume = nume;
            this.email = email;
            this.telefon = telefon;
            this.password = password;
        }
        public String Nume { get => nume; set => nume = value; }
        public String Email { get => email; set => email = value; }
        public String Telefon { get => telefon; set => telefon = value; }
        public String Password { get => password; set => password = value; }

        public object Clone()
        {
            Client client = (Client)this.MemberwiseClone();
            return client;
        }
        public int CompareTo(object obj)
        {
            Client client = (Client)obj;
            return string.Compare(email,client.email);
        }
        public override string ToString()
        {
            return "Nume " + nume + " Email " + email + " Telefon " + telefon;
        }
        public string generatePassword(int length)
        {
            string password = "id";
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
                    password += rand.Next(10);
                else
                    password += upper[randomIndex];
            }
            return password;
        }
    }
}
