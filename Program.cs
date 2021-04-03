using System;

// Inheritance | C# | Tutorial 31

namespace CSharpExercises_31
{
    class Program
    {
        static void Main(string[] args)
        {

            Chef chef = new Chef();
            //chef.MakeSpecialDish();
           
            //chef.MakeChicken();


            ItalianChef italianChef = new ItalianChef();
            //italianChef.MakeChicken();
            //italianChef.MakePasta();


            // we want the italian chef to make his special dish not bbq ribs
            // so we can use an overide of the method within Chef inherited class
            chef.MakeSpecialDish();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
