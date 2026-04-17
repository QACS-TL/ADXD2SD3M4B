namespace LabsSolutions.QALibrary;public class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name)
    {
    }
    public override string MakeNest()
    {
        return "Making a nest like a Penguin!";
    }

    public string Swim()
    {
        return "Swimming like a Penguin!";
    }

    public override string Move()
    {
        return "Moving like a Penguin!";
    }
}
