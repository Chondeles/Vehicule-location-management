using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribak_Anas
{
    public class Client
    {
        String nump;
        string nomc;
        string adressec;


        public Client()
        {
            nump = nomc = adressec = "????????";
        }

        public Client(string nump, string nomc, string adressec)
        {
            this.nump = nump;
            this.nomc = nomc;
            this.adressec = adressec;
        }

        public string Nump { get => nump; set => nump = value; }
        public string Nomc { get => nomc; set => nomc = value; }
        public string Adressec { get => adressec; set => adressec = value; }

        public override string ToString()
        {
            return nump + "   " + nomc + "   " + adressec + "   ";
        }
    }
}
