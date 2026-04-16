using LabsSolutions.Lab3;
namespace LabsSolutions.Lab6;

public class Program
{
    public static void Main()
    {
        Account acc = new Account(111, "Bob", 100);
		try
		{
			Console.WriteLine(acc.GetDetails());
			acc.Withdraw(1000);
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			acc.Close();
		}

		for (int i = 0; i < 20; i++)
		{
			try
			{
                RegistrationPlate plate = RegistrationPlateFactory.GetNextRegistrationPlate();
				Console.WriteLine("Issued plate: " + plate.RegPlate);
            }
            catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

    }
}
