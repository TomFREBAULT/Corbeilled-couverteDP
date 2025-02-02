using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Element
{
    // Classe de base pour représenter un élément chimique
    public abstract class ElementBase
    {
        // Propriétés communes
        public string Nom { get; set; }
        public string Symbole { get; set; }
        public double Masse { get; set; }
        
        // La position de l'élément dans l'univers (coordonnées X, Y)
        public (int X, int Y) Position { get; set; }

        protected ElementBase(string nom, string symbole, double masse)
        {
            Nom = nom;
            Symbole = symbole;
            Masse = masse;
        }

        // Affiche les informations de l'élément
        public override string ToString()
        {
            return $"{Nom} ({Symbole}) - Masse : {Masse} - Position : ({Position.X}, {Position.Y})";
        }
    }

    // Classe concrète pour représenter un atome
    public class Atome : ElementBase
    {
        public Atome(string nom, string symbole, double masse) 
            : base(nom, symbole, masse)
        {
        }
    }
}
