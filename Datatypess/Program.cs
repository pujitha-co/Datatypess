using System;
namespace Datatypess
{
    class Variables
    {
        static void Main(string[] args)
        {
            //        string name = "pujitha";
            //        int age = 23;
            //        double marks = 85.5;

            //        Console.WriteLine(name);
            //        Console.WriteLine(age);
            //        Console.WriteLine(marks);

            string product = "Notebook";
            int quantity = 5;
            double price = 200;

            double totalBill = quantity * price;

            Console.WriteLine("Product = " + product);
            Console.WriteLine("Quantity = " + quantity);
            Console.WriteLine("Total Bill = " + totalBill);
        }
    }


    
}