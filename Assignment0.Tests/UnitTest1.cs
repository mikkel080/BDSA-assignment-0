namespace Assignment0.Tests;

public class UnitTest1
{
    [Fact]
    public void IsDivisibleByFour()
    {
        var LeapYear = new LeapYear();
        //Asserts
        Assert.True(LeapYear.IsLeapYear(1996));
    }
    [Fact]
    public void isDivisibleByFourHundred()
    {
        var LeapYear = new LeapYear();
        //Asserts
        Assert.True(LeapYear.IsLeapYear(2000));
    }
    [Fact]
    public void isDivisibleByOneHundred()
    {
        var LeapYear = new LeapYear();
        //Asserts
        Assert.False(LeapYear.IsLeapYear(1900));
    }

    [Fact]
    public void UserInputIsInteger()
    {
        var LeapYear = new LeapYear();
        var writer = new StringWriter();
        var reader = new StringReader("Not a year");
        Console.SetOut(writer);
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(Assignment0));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        //Asserts
        var tempactual = writer.GetStringBuilder().ToString().TrimEnd();
        string[] listoftempactual = tempactual.Split('\n');
        var actual = listoftempactual[1];
        Assert.Equal("Input was not a year.", actual);
    }

     [Fact]
    public void UserInputIsafter1582()
    {
        var LeapYear = new LeapYear();
        var writer = new StringWriter();
        var reader = new StringReader("1582");
        Console.SetOut(writer);
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(Assignment0));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        //Asserts
        var tempactual = writer.GetStringBuilder().ToString().TrimEnd();
        string[] listoftempactual = tempactual.Split('\n');
        var actual = listoftempactual[1];
        Assert.Equal("Please time a year after 1582.", actual);
    }
}