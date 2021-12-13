using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inkopslistan_ovn_2_8
{
    class Vara
    {
        protected string namn;

        public Vara(string n)
        {
            this.namn = n;
        }

        public string Namn { get => namn; set => namn = value; }
        
        public virtual double BeräknaPris()
        {
            return 0.0;
        }
    }

    class StyckSak : Vara
    {
        double styckPris;
        int antal;

        /// <summary>
        /// En vara i antal
        /// </summary>
        /// <param name="n">Namn på varan</param>
        /// <param name="p">Pris på varan i kronor per styck</param>
        /// <param name="a">Antal av varan.</param>
        public StyckSak(string n, double p, int a):base(n)
        {
            this.styckPris = p;
            this.antal = a;
        }

        /// <summary>
        /// Beräknar priset utifrån hur många man köper.
        /// </summary>
        /// <returns></returns>
        public override double BeräknaPris()
        {
            return Math.Round(antal * styckPris, 2, MidpointRounding.AwayFromZero);
        }

        public override string ToString()
        {
            return namn + " " + antal + " st. " + styckPris + " kr/st. = " 
                + BeräknaPris() + " kr.";
        }

        public double StyckPris { get => styckPris; set => styckPris = value; }
    }

    class LösVikt:Vara
    {
        //Variabler
        protected double kiloPris;
        protected double vikt;

        /// <summary>
        /// En vara i lösvikt
        /// </summary>
        /// <param name="n">Namn på varan</param>
        /// <param name="p">Pris på varan i kronor per kilogram</param>
        /// <param name="v">Vikt på varan i kilogram.</param>
        public LösVikt(string n, double p, double v):base(n)
        {
            kiloPris = p;
            vikt = v;
        }

        //Egenskaper
        public double KiloPris { get => kiloPris; set => kiloPris = value; }
        public double Vikt { get => vikt; set => vikt = value; }

        /// <summary>
        /// Beräknar priset per kilogram.
        /// </summary>
        /// <returns></returns>
        public override double BeräknaPris()
        {
            return Math.Round(vikt * kiloPris, 2, MidpointRounding.AwayFromZero);
        }

        public override string ToString()
        {
            return namn + " " + vikt + " kg. " + kiloPris + " kr/kg. = " 
                + BeräknaPris() + " kr." ;
        }
    }
}
