using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var bird1 = new Bird();
            {
                bird1.IsAlive = true;
                bird1.Name = "Eagle";
                bird1.NumberLegs = 2;
                bird1.Age = 2;
                bird1.Raptor = true;
                bird1.SoundMade = "Screach";
                bird1.CanFly = true;
                bird1.WingSpan = 5;
            }
            Console.WriteLine("tell me about this bird");
            Console.WriteLine($"is it currently alive?:{bird1.IsAlive} , name of species?:{bird1.Name}, number of legs?:{bird1.NumberLegs}, age:{bird1.Age}+" +
                $", is it a raptor?:{bird1.Raptor}, what sound does it make?{bird1.SoundMade}, can it fly?:{bird1.CanFly},wingspan: {bird1.WingSpan}");
            
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var rep1 = new Reptile(true, 0, 5, "snake", true, 8.50, false, false);
            Console.WriteLine();
            
        }
    }
}
