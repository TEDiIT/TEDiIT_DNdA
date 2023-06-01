using ArrayAufgaben;

namespace DNDA_AufgabenTests;

[TestFixture]
public class Array1Tests
{
    private Array1 _sut;
    
    [SetUp]
    public void SetUp()
    {
        _sut = new Array1();
    }

    [Test]
    public void FirstValue_ReturnsFirstValueOfArray()
    {
        var arr = new[] { 2, 5, 3 };

        var result = _sut.FirstValue(arr);
        
        Assert.That(result, Is.EqualTo(arr[0]));
    }

    [Test]
    public void FourAppears_NoFourInFirstOrLastPlace_ReturnsFalse()
    {
        var arr = new[] { 1, 7, 2, 9, 3 };

        var result = _sut.FourAppears(arr);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void FourAppears_FourInFirstPlace_ReturnsTrue()
    {
        var arr = new[] { 4, 7, 2, 9, 3 };
        
        var result = _sut.FourAppears(arr);
        
        Assert.That(result, Is.True);
    }
    
    [Test]
    public void FourAppears_FourInLastPlace_ReturnsTrue()
    {
        var arr = new[] { 1, 7, 2, 9, 4 };
        
        var result = _sut.FourAppears(arr);
        
        Assert.That(result, Is.True);
    }

    [Test]
    public void TwoAppears_NoTwo_ReturnsFalse()
    {
        var arr = new[] { 1, 7, 3, 9, 4 };

        var result = _sut.TwoAppears(arr);
        
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void TwoAppears_TwoExists_ReturnsTrue()
    {
        var arr = new[] { 1, 2, 3, 9, 4 };

        var result = _sut.TwoAppears(arr);
        
        Assert.That(result, Is.True);
    }
}