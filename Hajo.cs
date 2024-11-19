using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hajoegyszeru_vinklarik1119
{
    internal class Hajo
    {
        string neme;
        string kategoria;
        int foglalt;
        int osszes;

        public string Neme { get => neme; set => neme = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public int Foglalt { get => foglalt; set => foglalt = value; }
        public int Osszes { get => osszes; set => osszes = value; }

        public Hajo(string sor)
        {
            string[] darabok = sor.Split(';');
            string nemekat = darabok[0];
            string[] db = nemekat.Split('-');
            neme = db[0];
            kategoria = db[1];
            foglalt = Convert.ToInt32(darabok[1]);
            osszes = Convert.ToInt32(darabok[2]);
                
        }
        public int Szabadhelyek()
        {
            return osszes - foglalt;
        }
    }
}
