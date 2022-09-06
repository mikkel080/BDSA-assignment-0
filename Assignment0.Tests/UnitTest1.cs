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
}