using System;
using System.Collections.Generic;
using System.Text;

namespace Datatypess
{
    //public class Var_Dynamickeyword
    //{
    //    static void Main(string[] args)
    //    {
    //        //var name = "Pujitha";

    //        //Console.WriteLine(name);
    //        //Console.WriteLine(name.GetType());

    //        var price = 500;
    //        var quantity = 4;

    //        var total = price * quantity;

    //        Console.WriteLine(total);
    //        Console.WriteLine(total.GetType());

    //    }
    //}

    public class Var_Dynamickeyword
    {
        static void Main(string[] args)
        {
            //dynamic name = "Pujitha";
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetType());
            //name = 500;
            //Console.WriteLine(name);
            //Console.WriteLine(name.GetType());

            dynamic value = 100;
            Console.WriteLine(value);

            value = "Hello";
            Console.WriteLine(value);

            value = 25.5;
            Console.WriteLine(value);
        }
    }
}
