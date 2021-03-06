﻿using System;
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
       private long _vitesse;

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
       public long Vitesse
       {
           get { return _vitesse; }
           set { _vitesse = value; }
       }
       public void Accelerer (long acc) 
       { 
           // !!!!!!!!!!!!!!!!!!!!!!!!!
           // Vitesse max à modifier
            if (this.Vitesse < 300) { 
                this.Vitesse = this.Vitesse * acc;
            }
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

       public Voiture(int pX ,int pY)
       {
           this.Longueur = 3;
           this.Largeur = 2;
           this.Vitesse = 0;
           this.Direction = 0;
           this.X = pX;
           this.Y = pY;
       }


       public Voiture()
       {
           this.Longueur = 3;
           this.Largeur = 2;
           this.Vitesse = 0;
           this.Direction = 0;
           this.X = 0;
           this.Y = 0;
       }

   }
}
