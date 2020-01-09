using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class Vecteur2D
    {
        public double x, y;

        public Vecteur2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vecteur2D()
        {
            this.x = 0;
            this.y = 0;
        }

        public double Norme
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }

            private set { }
        }

        public Vecteur2D addition(Vecteur2D v)
        {
            return new Vecteur2D(this.x + v.x, this.y + v.y);
        }

        public Vecteur2D soustraction(Vecteur2D v)
        {
            return new Vecteur2D(this.x - v.x, this.y - v.y);
        }

        public Vecteur2D moinsUnaire(Vecteur2D v)
        {
            return new Vecteur2D(-v.x, -v.y);
        }

        public Vecteur2D multiplicationScalaireDroite(double scalaire, Vecteur2D v)
        {
            return new Vecteur2D(v.x * scalaire, v.y * scalaire);
        }

        public Vecteur2D multiplicationScalaireGauche(double scalaire, Vecteur2D v)
        {
            return new Vecteur2D(scalaire * v.x, scalaire * v.y);
        }

        public Vecteur2D divisionScalaire(double scalaire, Vecteur2D v)
        {
            return new Vecteur2D(v.x / scalaire, v.y / scalaire);
        }
    }
}
