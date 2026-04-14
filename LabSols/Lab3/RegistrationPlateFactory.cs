namespace LabsSolutions.Lab3;
public static class RegistrationPlateFactory
{
    private static int count = 0;

    private static string[] regPlates = { "CR11NGE", "QU11RKY", "TOYS4US", "HNZ57", "PUT3", "JB007" };

    public static RegistrationPlate GetNextRegistrationPlate()
    {
        if (count < regPlates.Length)
            return new RegistrationPlate(regPlates[count++]);
        else
            return null;
    }
}
