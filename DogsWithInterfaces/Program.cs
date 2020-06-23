using System;
using System.Globalization;

namespace DogsWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var col = new Collie
            {
                Name = "Lassie", 
                Color = "Light Brown", 
                BarkSound = "TIMMY'S IN A WELL!"

            };
            col.Bark();

            var box = new Boxer
            {
                Name = "Rocky",
                Color = "Black",
                BarkSound = "WOOF WOOF!"
            };
            box.Bark();

            var chi = new chichuachua
            {
                Name = "Killer",
                Color = "White",
                BarkSound = "Yip!"
            };
            chi.Bark();

            iDog[] dogs = new iDog[10];
            dogs[0] = col;
            dogs[1] = box;
            dogs[2] = chi;
            foreach(var dog in dogs)
            {
                if (dog == null) continue;
                Console.WriteLine($"Name is {dog.Name}, color is {dog.Color}, bark is {dog.BarkSound}");
                dog.Bark();
            }
        }
    }
}
