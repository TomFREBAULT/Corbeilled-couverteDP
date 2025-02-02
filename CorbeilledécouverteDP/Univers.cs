using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using Element;  // Pour utiliser la classe Atome et ElementBase

namespace Univers
{
    public class Univers2D
    {
        // Dimensions de l'univers
        public int Largeur { get; }
        public int Hauteur { get; }

        // Liste interne des éléments présents dans l'univers
        private readonly List<ElementBase> _elements;

        public Univers2D(int largeur, int hauteur)
        {
            if (largeur <= 0 || hauteur <= 0)
                throw new ArgumentException("Les dimensions de l'univers doivent être positives.");

            Largeur = largeur;
            Hauteur = hauteur;
            _elements = new List<ElementBase>();
        }

        // Méthode pour ajouter un élément dans l'univers
        public void AjouterElement(ElementBase element)
        {
            // Vérification de la position dans l'univers
            if (element.Position.X < 0 || element.Position.X >= Largeur ||
                element.Position.Y < 0 || element.Position.Y >= Hauteur)
            {
                throw new Exception("L'élément est en dehors des limites de l'univers.");
            }

            // Vérifier qu'il n'y a pas déjà un élément à cette position
            foreach (var elem in _elements)
            {
                if (elem.Position.Equals(element.Position))
                {
                    throw new Exception("Un élément existe déjà à cette position.");
                }
            }

            // Vérifier qu'on n'ajoute pas deux fois le même élément (par exemple, en comparant l'instance ou un identifiant unique)
            if (_elements.Contains(element))
            {
                throw new Exception("Cet élément est déjà présent dans l'univers.");
            }

            _elements.Add(element);
        }

        // Récupérer l'élément à une position donnée
        public ElementBase ObtenirElementA(int x, int y)
        {
            foreach (var element in _elements)
            {
                if (element.Position.X == x && element.Position.Y == y)
                {
                    return element;
                }
            }
            return null;
        }

        // Parcourir tous les éléments de l'univers
        public IEnumerable<ElementBase> ParcourirElements()
        {
            return _elements;
        }
    }
}

