public class LeapYear
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a year after 1582:");
        string temp = Console.ReadLine();
        int input;
        if (int.TryParse(temp, out input))
        {
            if (input > 1582)
            {
                if (new LeapYear().IsLeapYear(input))
                {
                    Console.WriteLine("yay");
                }
                else
                {
                    Console.WriteLine("nay");
                }
            } else {
                Console.WriteLine("Please time a year after 1582.");
            }
        }
        else
        {
            Console.WriteLine("Input was not a year.");
        }
    }

    public bool IsLeapYear(int year)
    {
        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}