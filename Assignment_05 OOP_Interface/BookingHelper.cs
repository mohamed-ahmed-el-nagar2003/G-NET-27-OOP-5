using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP_Interface
{
    internal class BookingHelper
    {


        public void print(Iprintable[] arr_PRI)
        {
            for (int i = 0; i < arr_PRI.Length; i++)
            {

                if (arr_PRI[i] != null)
                {

                    arr_PRI[i].print();
                }



            }
        }
    }
}
