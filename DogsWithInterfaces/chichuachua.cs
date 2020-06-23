using System;
using System.Collections.Generic;
using System.Text;

namespace DogsWithInterfaces
{
    class chichuachua : iDog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string BarkSound { get; set; }

        public void Bark()
        {
            Console.WriteLine($"A chihuahua goes {BarkSound}");
        }
    }
}
