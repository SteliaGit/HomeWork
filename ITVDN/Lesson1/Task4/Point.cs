using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Point
    {
        int chislo_2, chislo_1;
      
        string strokovoe;

        public int Chislo_1
        {
            get { return  chislo_1; }
        }
        public int Chislo_2
        {
            get { return chislo_2; }
        }
        public string Strokovoe
        {
            get { return strokovoe; }
        }

        public Point(string strokovoe, int chislo_1, int chislo_2)
        {
            this.strokovoe = strokovoe;
            this.chislo_1 = chislo_1;
            this.chislo_2 = chislo_2;
           
        }
    }
}
