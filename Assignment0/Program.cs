public class LeapYear
{
    public static void Main()
    {
        Console.WriteLine("Enter a year:");
        string temp = Console.ReadLine();
        int input;
        if(int.TryParse(temp, out input)){
            if (new LeapYear().IsLeapYear(input))
        {
            Console.WriteLine("yay");
        }
        else
        {
            Console.WriteLine("nay");
        }
        } else {
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