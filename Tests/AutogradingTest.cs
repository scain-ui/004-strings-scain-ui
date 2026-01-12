namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Define_A_Public_Class_Level_String_Variable_Named_FirstName()
    {
        var jobOpenings = new JobOpenings();

        Assert.True(jobOpenings.FirstName.Length > 0, "should define a public class-level string variable named `FirstName`");
    }

    [Fact]
    public void Should_Define_A_Public_Class_Level_String_Variable_Named_JobTitle()
    {
        var jobOpenings = new JobOpenings();

        Assert.True(jobOpenings.JobTitle.Length > 0, "should define a public class-level string variable named `JobTitle`");
    }

    [Fact]
    public void Should_Define_A_Public_Class_Level_String_Variable_Named_City()
    {
        var jobOpenings = new JobOpenings();

        Assert.True(jobOpenings.City.Length > 0, "should define a public class-level string variable named `City`");
    }

    [Fact]
    public void Should_Return_A_String_From_The_PrintOpening_Method_That_Contains_FirstName_JobTitle_And_City_And_A_New_Line()
    {
        var jobOpenings = new JobOpenings();

        Assert.True(jobOpenings.PrintOpening().Contains(jobOpenings.FirstName), "should return a string from the `PrintOpening` method that contains `FirstName`");
        Assert.True(jobOpenings.PrintOpening().Contains(jobOpenings.JobTitle), "should return a string from the `PrintOpening` method that contains `JobTitle`");
        Assert.True(jobOpenings.PrintOpening().Contains(jobOpenings.City), "should return a string from the `PrintOpening` method that contains `City`");
        Assert.True(jobOpenings.PrintOpening().Contains("\r\n"), "should return a string from the `PrintOpening` method that contains a new line");
    }
}