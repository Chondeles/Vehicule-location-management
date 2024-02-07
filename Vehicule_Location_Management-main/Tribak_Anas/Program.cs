using Tribak_Anas;

namespace GestionAchat;

class Program
{
        static void Main() 
        {

        Console.WriteLine($" \t\t\t\t Bienvenue au Système de gestion des location de voiture \n ");


        // Création des instances de produits
        Voiture voiture1 = new Voiture { Matv = "A39213", Marquev = "Honda", Prixv = 300 };
        Voiture voiture2 = new Voiture { Matv = "B32315", Marquev = "Nissan", Prixv = 500 };
        Voiture voiture3 = new Voiture { Matv = "C33411", Marquev = "Fiat", Prixv = 350 };




        // Création des instances de clients
        Client client1 = new Client { Nump = "MAR32093", Nomc = "TRIBAK ANAS", Adressec = "MA, FES, AL BADIE 12" };
        Client client2 = new Client { Nump = "FR234029", Nomc = "MOUAD HILALI", Adressec = "MA, CASABLANCA, MAARIF, 36" };


        // Création des instances de commandes
        Location voiture1Client1 = new Location();
        voiture1Client1.Client = client1;
        voiture1Client1.AjouterLocation(voiture2, 1);
        voiture1Client1.AjouterLocation(voiture1, 2);

    

        Location voiture2Client1 = new Location();
        voiture2Client1.Client = client1;
        voiture2Client1.AjouterLocation(voiture3, 3);
        voiture2Client1.AjouterLocation(voiture1, 1);

        

        Location voiture1Client2 = new Location();
        voiture1Client2.Client = client2;
        voiture1Client2.AjouterLocation(voiture1, 1);
        voiture1Client2.AjouterLocation(voiture2, 4);

        Location voiture2Client2 = new Location();
        voiture2Client2.Client = client2;
        voiture2Client2.AjouterLocation(voiture2, 2);
        voiture2Client2.AjouterLocation(voiture3, 1);

        // Création de la classe GestionCommandes
        GestionLocations gestionlocation = new GestionLocations();

        // Ajout des produits à la gestion des commandes
        gestionlocation.AjouterVoiture(voiture1);
        gestionlocation.AjouterVoiture(voiture2);
        gestionlocation.AjouterVoiture(voiture3);

        // Ajout des commandes à la gestion des commandes
        gestionlocation.AjouterLocation(voiture1Client1);
        gestionlocation.AjouterLocation(voiture2Client1);
        gestionlocation.AjouterLocation(voiture1Client2);
        gestionlocation.AjouterLocation(voiture2Client2);

        // Affichage des produits et des commandes
        gestionlocation.AfficherListeVoiture();
        gestionlocation.AfficherListeLocation();

        // Test de la méthode GetQuantiteComm
        Voiture voitureTest = voiture1;
        int quantiteTotale = gestionlocation.GetQuantite(voitureTest);
        Console.WriteLine($"Quantité totale commandée pour {voitureTest.Matv}: {quantiteTotale}");

        // Test de la méthode TrierCommandesParMontantDecroissant
        //gestionCommandes.TrierCommandesParMontantDecroissant();

        // Affichage des commandes après le tri
        gestionlocation.TrierCroissant();
        Console.WriteLine($"la liste triée : {voitureTest.Matv}: {quantiteTotale}");
    }
    }


