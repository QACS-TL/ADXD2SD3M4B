using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.QALibrary;
    public abstract class Animal
    {
        public AnimalType animalType;
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

    }
