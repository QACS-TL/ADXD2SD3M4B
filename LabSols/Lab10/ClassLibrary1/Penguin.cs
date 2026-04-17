using System;

namespace LabsSolutions.QALibrary
{
    public class Penguin : Bird, Swimmable
    {
        public Penguin(string name) : base(name)
        {
        }
        public override void MakeNest()
        {
            Console.WriteLine("Making a nest like a Penguin!");
        }

        public void Swim()
        {
            Console.WriteLine("Swiming like a Penguin!");

        }

        public override void Move()
        {
            Console.WriteLine("Moveing like a Penguin!");
        }
    }
}
