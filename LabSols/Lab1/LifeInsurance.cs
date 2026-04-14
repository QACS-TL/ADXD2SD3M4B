namespace LabsSolutions.Lab1;
public class LifeInsurance
{
    public double Calculate()
    {
        const int MIN_AGE = 18;
        const int MAX_AGE = 85;
        const int MIN_YEARS = 10;
        const int MAX_YEARS = 25;

        Utils utils = new Utils();
        string name = utils.Getstring("What is your name? ");

        int age = utils.GetInt("What is your age? ");

        if (age < MIN_AGE || age > MAX_AGE - MIN_YEARS)
        {
            Console.WriteLine("Sorry, we only consider ages between 18 and 75");
            return -1;
        }
        int years = utils.GetInt($"How many years you wish to keep your life insurance (10 min-25 max) ? ");

        if (years < MIN_YEARS || years > MAX_YEARS)
        {
            Console.WriteLine($"Sorry, we only consider insurance for {MIN_YEARS}-{MAX_YEARS} years.");
            return -1;
        }

        int maxYearsAllowed = MAX_AGE - age;  // consider the older people
        if (years > maxYearsAllowed)
        {
            Console.WriteLine($"Sorry, The maximum you can apply for is {maxYearsAllowed} which is less than {years} you wish to apply for.");
            return -1;
        }

        double money = 5 + age + years / 10.0;

        Console.WriteLine("We apply 10% discount for nurses, doctors, teachers and police officers)? ");
        string job = utils.Getstring("Do you work in these areas (y/n)?");

        if (job.ToLower() == "y")
            money *= 0.9;

        return money;
    }
}


