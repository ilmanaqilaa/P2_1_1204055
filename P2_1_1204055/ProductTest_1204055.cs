﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204055
{
    class ProductTest_1204055
    {
        /*static void Main(String[] args)
        {
            Product_1204055 myProduct = new Product_1204055();

            myProduct.MyType = "DVD"; set nilai

            Console.WriteLine(myProduct.MyType); memanggil data
        }*/

        /*static void Main(String[] args)
        {
            Book_1204055 myBook = new Book_1204055("Book", "C# Object Oriented Solution", "300");

            Console.WriteLine("\"the book {0} has {1} pages\"", myBook.MyTitle, myBook.PageCount);
        }*/

        static void Main(String[] args)
        {
            Book_1204055 product1 = new Book_1204055("Book", "C# Object Oriented Solution", "300");
            DVD_1204055 product2 = new DVD_1204055("Eternal Sunshine of The Spotless Mind", "145");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} minutes duration", product2.MyType, product2.MyTitle, product2.Duration);
        }


    }
}
