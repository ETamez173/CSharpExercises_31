using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercises_31
{

    // the ItalianChef class is inheriting and the functionality of the Chef class
    class ItalianChef : Chef
    {

        // using ovverride here we overide the superclass MakeSpecialDish method with ours
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Chicken Parm");
        }

        public void MakePasta()
        {
            Console.WriteLine("The Chef makes Pasta");

        }

    }
}
