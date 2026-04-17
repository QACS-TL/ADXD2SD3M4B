using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.QALibrary
{
    public abstract class Animal : Moveable
    {
        internal AnimalType animalType;

        public string Name { get; private set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal moving!");
        }
    }

}