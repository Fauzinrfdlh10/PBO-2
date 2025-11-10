using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240032
{
    public class Book_714240032 : Product_714240032
    {
        protected string pageCount;

        public Book_714240032(string type, string title, string pagecount)
            : base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        // Implementasi metode abstrak
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and it has {2} pages", MyType, MyTitle, PageCount);
        }
    }
}
