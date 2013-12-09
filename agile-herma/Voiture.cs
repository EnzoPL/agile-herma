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

       //public long direction { get; set; }
       //public int vitesse { get; set; }

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


       public Voiture(int pX,int pY)
       {
           this.X = pX;
           this.Y = pY;
       }


       public Voiture()
       {
           this.X = 0;
           this.Y = 0;
       }

       public String positionParDefaut()
       {
           String coord = "La voiture est a : " + X + ", " + Y;
           return coord;
       }

   }
}
