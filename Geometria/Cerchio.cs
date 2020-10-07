using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    public class Cerchio
    {
        public const double PI = 3.14;
        private double raggio;
        public double Raggio
        {
            get
            {
                return raggio;
            }
            set
            {
                raggio = value;
            }
        }

        public Cerchio(double r)
        {
            raggio = r;
        }

        public double CalcolaArea()
        {
            return 2 * PI * raggio;
        }

        public double CalcolaCirconferenza()
        {
            return PI * raggio * raggio;
        }

        public string IdentificaCerchio()
        {
            return $"r = {raggio}, c = {CalcolaCirconferenza()}, a = {CalcolaArea()}";
        }

    }
}
