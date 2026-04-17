namespace LabsSolutions.QALibrary;

public class Duck : Bird, IFlyable, ISwimmable
{
    public Duck(string name) : base(name)
    {
    }

    public override string MakeNest()
    {
        return "Making a nest like a Duck!";

    }
    public override string Move()
    {
        return "Moving like a Duck!";
    }
    public virtual string Swim()
    {
        return "Diving under water like a Duck!";
    }
    public string Fly()
    {
        return "Flying like a Duck!";
    }

}
