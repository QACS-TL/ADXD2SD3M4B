using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.QALibrary
{

    public class Fish : Animal, Swimmable
    {
        public Fish(string name) : base(name)
        {
            animalType = AnimalType.Fish;
        }

        public override void Move()
        {
            Console.WriteLine("Moving like a fish!");

        }

        public virtual void Swim()
        {
            Console.WriteLine("Swiming like a fish!");

        }

    }
}
