// Importation de l'espace de noms System qui contient des classes de base comme Console, Exception, etc.
using System;

// Importation de l'espace de noms 'Element' pour accéder aux classes comme 'Atome'
using Element;

// Importation de l'espace de noms 'Univers' pour accéder aux classes comme 'Univers2D'
using Univers;

// Déclaration du namespace principal de l'application
namespace CorbeilledecouverteDP
{
    // Déclaration de la classe Program, qui contient le point d'entrée de l'application
    class Program
    {
        // La méthode Main est le point d'entrée du programme. Elle est exécutée au démarrage.
        static void Main(string[] args)
        {
            // Création d'un nouvel objet Univers2D appelé 'monUnivers' avec une largeur et une hauteur de 10
            Univers2D monUnivers = new Univers2D(10, 10);

            // Début d'un bloc try pour gérer les éventuelles erreurs qui pourraient survenir pendant l'exécution
            try
            {
                // Création d'un objet Atome nommé 'carbone'
                // On utilise le constructeur de la classe Atome en passant "Carbone" comme nom,
                // "C" comme symbole, et 12.01074 comme masse.
                // Ensuite, on initialise la propriété Position de cet atome à la coordonnée (2, 3).
                Atome carbone = new Atome("Carbone", "C", 12.01074)
                {
                    Position = (2, 3)  // Initialisation de la position de l'atome carbone
                };

                // Création d'un objet Atome nommé 'hydrogene'
                // On passe "Hydrogène" comme nom, "H" comme symbole, et 1.00794 comme masse.
                // La position de cet atome est fixée à (5, 5).
                Atome hydrogene = new Atome("Hydrogène", "H", 1.00794)
                {
                    Position = (5, 5)  // Initialisation de la position de l'atome d'hydrogène
                };

                // Création d'un objet Atome nommé 'lithium'
                // On passe "Lithium" comme nom, "Li" comme symbole, et 6.941 comme masse.
                // La position de cet atome est fixée à (0, 0).
                Atome lithium = new Atome("Lithium", "Li", 6.941)
                {
                    Position = (0, 0)  // Initialisation de la position de l'atome de lithium
                };

                // Ajout de l'atome 'carbone' dans l'univers en appelant la méthode AjouterElement
                monUnivers.AjouterElement(carbone);

                // Ajout de l'atome 'hydrogene' dans l'univers
                monUnivers.AjouterElement(hydrogene);

                // Ajout de l'atome 'lithium' dans l'univers
                monUnivers.AjouterElement(lithium);

                // Affichage d'un message dans la console pour indiquer le début de l'affichage des éléments présents dans l'univers
                Console.WriteLine("Éléments présents dans l'univers :");

                // Boucle foreach pour parcourir chaque élément dans la collection retournée par la méthode ParcourirElements de 'monUnivers'
                foreach (var element in monUnivers.ParcourirElements())
                {
                    // Pour chaque élément, on affiche sa représentation textuelle (grâce à la méthode ToString() qui est appelée automatiquement)
                    Console.WriteLine(element);
                }

                // Récupération de l'élément qui se trouve à la position (5,5) en appelant la méthode ObtenirElementA
                // La méthode renvoie un objet de type ElementBase ou null si aucun élément n'est trouvé
                ElementBase elementTrouve = monUnivers.ObtenirElementA(5, 5);

                // Affichage d'un saut de ligne et d'un message pour indiquer qu'on va afficher l'élément trouvé à la position (5,5)
                Console.WriteLine("\nÉlément à la position (5,5) :");

                // Vérification : si elementTrouve n'est pas null, on affiche ses informations (grâce à ToString()),
                // sinon, on affiche "Aucun élément trouvé."
                Console.WriteLine(elementTrouve != null ? elementTrouve.ToString() : "Aucun élément trouvé.");
            }
            // Bloc catch pour attraper les exceptions éventuelles et éviter que le programme ne se termine brutalement
            catch (Exception ex)
            {
                // Affichage dans la console du message d'erreur récupéré à partir de l'exception
                Console.WriteLine("Erreur : " + ex.Message);
            }

            // Affichage d'un message demandant à l'utilisateur d'appuyer sur une touche avant de fermer la fenêtre de la console
            Console.WriteLine("\nAppuyez sur une touche pour fermer...");

            // Attend que l'utilisateur appuie sur une touche, ce qui permet de garder la fenêtre de la console ouverte
            Console.ReadKey();
        }
    }
}
