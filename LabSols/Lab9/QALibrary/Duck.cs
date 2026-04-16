namespace LabsSolutions.QALibrary;

public class Duck : Bird
{
    public Duck(string name) : base(name)
    {
    }
    
    public override string MakeNest()
    {
        return "Making a nest like a Duck!";
    }
}
