using System;
using System.Collections.Generic;
using System.Text;

namespace _22_03_22_properties_ex_2
{
    class Storage
    {
            
        private int teller;
        private int noemer;
        private double breuk;

        public int Teller
        {
            get { return teller; }
            set { teller = value; }
        }
        public int Noemer
        {
            get { return noemer; }
            set { noemer = value; }
        }
        public double Breuk
        {
            get { return breuk; }
            set { breuk = value; }
        }
        public Storage()
        {
            teller = 20;
            noemer = 10;
            
        }
        public Storage(int OpvragenTeller, int OpvragenNoemer)
        {

            teller = OpvragenTeller;
            noemer = OpvragenNoemer;
            breuk = teller / noemer;
        }
    }
}
