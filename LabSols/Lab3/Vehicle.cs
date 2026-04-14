namespace LabsSolutions.Lab3;
public class Vehicle
{
    public int DistanceTravelled { get; private set; }
    private int lane;
    private RegistrationPlate registrationPlate;

    private static int Count { get; set; }
    private const int MAX_SPEED = 200;
    private const int MIN_SPEED = 0;

    private int speed;

    public int Speed
    {
        get { return speed; }
        set
        {
            if (value > MAX_SPEED) value = MAX_SPEED;
            if (value < MIN_SPEED) value = MIN_SPEED;

            speed = value;
        }
    }

    public Vehicle(int lane, int speed)
    {
        registrationPlate = RegistrationPlateFactory.GetNextRegistrationPlate();
        if (this.registrationPlate == null)
            Console.WriteLine("No registration plates were available.");

        Vehicle.Count++;
        this.lane = lane;
        this.Speed = speed;
    }

    public void Brake(int amount)
    {
        Speed -= amount;
    }

    public void Accelerate(int amount)
    {
        Speed += amount;
        DistanceTravelled += Speed;
    }

    public string GetDetails()
    {
        return $"Lane: {lane} , Speed: {Speed}, Distance travelled: {DistanceTravelled}, Registration Plate: {registrationPlate.RegPlate}";
    }
}

