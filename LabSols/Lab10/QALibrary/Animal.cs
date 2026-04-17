namespace LabsSolutions.QALibrary;

public abstract class Animal : IMoveable
{
    internal AnimalType animalType;

    private string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get
        {
            return name;
        }
    }

    public virtual string Move()
    {
        return "Animal moving!";
    }
}
