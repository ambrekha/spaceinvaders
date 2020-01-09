using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SpaceInvaders
{
    class SpaceShip : GameObject
    {
        /// Représente le vaisseau du joueur
        /// Des images de vaisseaux sont inclues dans Resources > ship*.png 

        private double speedPixelPerSecond; // vitesse de déplacement du joueur
        public Vecteur2D position;
        public int lives;
        public Bitmap image;

        public SpaceShip(Vecteur2D position, int lives, Bitmap image)
        {
            this.position = position;
            this.lives = lives;
            this.image = image;
        }

        public override void Update(Game gameInstance, double deltaT)
        {

        }

        public override void Draw(Game gameInstance, Graphics graphics)
        {
            graphics.DrawImage(image, new Point((int)position.x, (int)position.y));
        }

        public override bool IsAlive()
        {
            if (lives > 0) return true;
            return false;
        }

    }
}
