using System;
using System.Collections.Generic;
namespace LabsSolutions.QALibrary
{
    public abstract class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
            this.animalType = AnimalType.Bird;
        }

        public abstract void MakeNest();
    }
}