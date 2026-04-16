using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsSolutions.QALibrary;

public class Fish : Animal
{
    public Fish(string name) : base(name)
    {
        animalType = AnimalType.Fish;
    }

}
