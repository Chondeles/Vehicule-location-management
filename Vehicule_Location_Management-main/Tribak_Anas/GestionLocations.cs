using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribak_Anas
{
    internal class GestionLocations
    {
        List<Voiture> voiturelist;
        List<Location> locationlist;

        public GestionLocations()
        {
            voiturelist = new List<Voiture>();
            locationlist = new List<Location>();
        }

        public void AjouterVoiture(Voiture voiture)
        {
            voiturelist.Add(voiture);
        }

        public void AfficherListeVoiture()
        {
            Console.WriteLine("Liste des voiture en stock: \t\n");

            foreach (var voiture in voiturelist)
            {
                Console.WriteLine(voiture.ToString());
            }
        }
        public void AjouterLocation(Location location)
        {
            locationlist.Add(location);
        }

        public void AfficherListeLocation()
        {
            Console.WriteLine("Liste des locations:\t\n");
            foreach (var location in locationlist)
            {
                Console.WriteLine(location.ToString());
            }
        }

        public int GetQuantite(Voiture voiture)
        {
            int quantiteTotale = 0;

            foreach (var location in locationlist)
            {
                if (location.Quantite.ContainsKey(voiture))
                {
                    quantiteTotale += location.Quantite[voiture];
                }
            }

            return quantiteTotale;
        }

        public void TrierCroissant()
        {
            locationlist.Sort((c2, c1) => c1.Montantloc.CompareTo(c2.Montantloc));
        }


    }
}
