using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribak_Anas
{

    public class Location
    {
        static int cmp = 0;
        int nump;
        Client client;
        double montantloc;
        Dictionary<Voiture, int> quantite;

        public Location()
        {
            cmp++;
            nump = cmp;
            quantite = new Dictionary<Voiture, int>();
        }

        public Location(int nump, Client client, Dictionary<Voiture, int> quantite, double montantloc)
        {
            this.nump = nump;
            this.client = client;
            this.quantite = quantite;
            this.montantloc = montantloc;
        }

        public int Nump { get => nump; set => nump = value; }
        public Client Client { get => client; set => client = value; }
        public double Montantloc { get => montantloc; set => montantloc = value; }
        public Dictionary<Voiture, int> Quantite { get => quantite; set => quantite = value; }

        public void AjouterLocation(Voiture p, int q)
        {
            if (quantite.ContainsKey(p))
                quantite[p] += q;
            else
                quantite.Add(p, q);

            montantloc += p.Prixv * q;
        }

        public override string ToString()
        {
            return nump + "   " + client + "  " + quantite + "   " + montantloc;
        }


    }
}
