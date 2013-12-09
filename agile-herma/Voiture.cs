using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agile_herma
{
   public class Voiture
   {   
       private int _x;
       private int _y;
       private long _direction;
       private int _vitesse;
       private long _largeur;
       private long _longueur;

       public long Longueur
       {
           get { return _longueur; }
           set { _longueur = value; }
       }

       public long Largeur
       {
           get { return _largeur; }
           set { _largeur = value; }
       }

       public long Direction
       {
           get { return _direction; }
           set { _direction = value; }
       }
       public int Vitesse
       {
           get { return _vitesse; }
           set { _vitesse = value; }
       }
       public int X
       {
           get { return _x; }
           set { _x = value; }
       }

       public int Y
       {
           get { return _y; }
           set { _y = value; }
       }

       public Voiture(int pX ,int pY, int pV = 0)
       {
           this.Vitesse = pV;
           this.X = pX;
           this.Y = pY;
       }


       public Voiture()
       {
           this.Vitesse = 0;
           this.X = 0;
           this.Y = 0;
       }

   }
}
