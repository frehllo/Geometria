using System;

namespace Geometria
{
    public class Rettangolo
    {
        private double x, y, width, height;

        public Rettangolo (double x, double y, double w, double h)
        {
            this.x = x;
            this.y = y;
            width = w;
            height = h;
        }

        public double CalcolaArea()
        {
            return height * width;
        }

        public double CalcolaPerimetro()
        {
            return height * 2 + width * 2;
        }

        public bool Contiene(Rettangolo r)
        {
            if (x <= r.x && y <= r.y && x + width >= r.x + r.width && y + height >= r.y + r.height)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
