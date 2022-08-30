using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal interface Book : Interface
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public Author author { get; set; }  //containment

        public  string ToString()
        {
            return $"Book[name={Name},Author={this.author.ToString()},price={Price},qty={Qty}";
        }
    }

    public class TestBook
    {
        public static void Main()
        {
            Author b = new Author
            {
                Name = "Mastering C#",
                author = new Author { Name = "Mary", EMail = "mary.s", Gender = 'f' },
                Price = 500,
                Qty = 45
            };

            Author alex = new Author { Name = "Roja", EMail = "roja.p", Gender = 'f' };
            SITLAuthor dummyBook = new SITLAuthor { Name = "C#", author = alex, Price = 19, Qty = 99 };
        }
    }
}

