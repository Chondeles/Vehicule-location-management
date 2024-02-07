using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribak_Anas
{
    public class Voiture
    {
        String matv;
        String marquev;
        double prixv;

        public Voiture()
        {
            marquev = "?????";
            matv = "?????";
            prixv = 0;

        }

        public Voiture(string matv, string marquev, double prixv)
        {
            this.matv = matv;
            this.marquev = marquev;
            this.prixv = prixv;
        }


        public string Matv { get => matv; set => matv = value; }
        public string Marquev { get => marquev; set => marquev = value; }
        public double Prixv { get => prixv; set => prixv = value; }

        public override string ToString()
        {
            return matv + "   " + marquev + "   " + prixv + "   ";
        }

        }

    }

