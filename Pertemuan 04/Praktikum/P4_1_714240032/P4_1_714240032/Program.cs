using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240032
{
     internal class ProductTest_714240032
    {
        static void Main(string[] args)
        {
            Book_714240032 Product1 = new Book_714240032("Book", "#C object Oriented Solution", "300");
            DVD_714240032 Product2 = new DVD_714240032("Ethernal Sunshine Of The Spotles Mind ", "145");

            Product1.DisplayInfo();
            Product2.DisplayInfo();
        }
    }
}
    