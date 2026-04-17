using System;

namespace LabsSolutions.QALibrary
{
    public class Duck : Bird, Flyable, Swimmable
    {
        public Duck(string name) : base(name)
        {
        }

        public override void MakeNest()
        {
            Console.WriteLine("Making a nest like a Duck!");

        }
        public override void Move()
        {
            Console.WriteLine("Moveing like a Duck!");

        }
        public virtual void Swim()
        {
            Console.WriteLine("Diving under water like a Duck!");

        }
        public void Fly()
        {
            Console.WriteLine("Flying like a Duck!");
        }

    }
}
