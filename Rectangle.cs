using System;
using System.Collections.Generic;
using System.Text;

namespace Class_rectangle
{
  class Rectangle
  {
    // des attriuts privés
    private float _longueur;
    private float _largeur;
    private string _couleur;

    // création des propiétés de _couleur
    public string Couleur
    {
      get { return _couleur; }
    }

    // deux constructeurs un permet de saisir la couleur, mais pas l'autre.
    // les Constructeurs permettent d'utiliser des attributs private
    public Rectangle (float Longueur, float Largeur)
    {
      this._longueur = Longueur;
      this._largeur = Largeur;
    }

    public Rectangle (float Longueur, float Largeur, string Couleur)
    {
      this._longueur = Longueur;
      this._largeur = Largeur;
      this._couleur = Couleur;
    }

    //  Création d'une Méthode pour affiche le périmètre dans la console
    public void Perimetre()
      {
        Console.WriteLine($"Le périmètre est : {(_longueur + _largeur)*2} " );
      }

      //  Création dune Fonction qui renvoie l'aire du rectangle
      public float Aire()
      {
        return _longueur * _largeur;
      }
  }
}
