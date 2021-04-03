using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercises_31
{
    class Chef
    {

        // we make simple methods here
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad() 
        {
            Console.WriteLine("The Chef makes salad");
        }

        // using "virtual" here allows us to do the method override with the italianChef class
        // subclasses can overide or change the funcationality of the super class method here 
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ Ribs");
        }
            
        



    }
}
