using DNDA_Aufgaben;

namespace DNDA_AufgabenTests;

public class WarmUpTests
{
    private WarmUp _systemUnderTest;
    
    [SetUp]
    public void Setup()
    {
        _systemUnderTest = new WarmUp();
    }

    [Test]
    public void SumDouble_DifferentNumbers_ReturnsSum()
    {
        int firstNumber = 5;
        int secondNumber = 3;
        int sumOfBothNumbers = firstNumber + secondNumber;

        var result = _systemUnderTest.SumDouble(firstNumber, secondNumber);
        
        Assert.That(result, Is.EqualTo(sumOfBothNumbers));
    }

    [Test]
    public void SumDouble_EqualNumbers_ReturnsTwiceTheSum()
    {
        var x = 5;
        var y = 5;
        var sum = x + y;

        var result = _systemUnderTest.SumDouble(x, y);
        
        Assert.That(result, Is.EqualTo(sum*2));
    }

    [Test]
    public void CanSleep_WeekdayAndNoVacation_ReturnsFalse()
    {
        var result = _systemUnderTest.CanSleep(true, false);
        
        Assert.That(result, Is.False);
    }
}