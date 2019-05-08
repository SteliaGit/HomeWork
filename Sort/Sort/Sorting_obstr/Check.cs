using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_obstr
{
     class Check : Base_sort
    {
        
        public Check (string inputt) : base(inputt)
        { }
        protected override void Chek()
        {
            base.Chek();
            if ( ins != 0)
            {
                ins = Convert.ToInt32(inputt);   
            }

        }
       
    }
}
