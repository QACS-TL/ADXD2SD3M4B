namespace LabsSolutions.QALibrary;
public class Penguin : Bird
{
    public Penguin(string name) : base(name)
    {
    }

    public override string MakeNest()
    {
        return "Making a nest like a Penguin!";
    }
}
