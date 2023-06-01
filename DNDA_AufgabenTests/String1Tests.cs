using StringAufgaben;

namespace DNDA_AufgabenTests;

[TestFixture]
public class String1Tests
{
    private String1 _sut;
    
    [SetUp]
    public void SetUp()
    {
        _sut = new String1();
    }

    [Test]
    public void HalloName_ReturnsNameWithHalloInfront()
    {
        var result = _sut.HalloName("Muster");
        
        Assert.That(result, Is.EqualTo("Hallo Muster"));
    }

    [Test]
    public void MacheAbba_ReturnsStringWithAbbaPattern()
    {
        var result = _sut.MacheAbba("Hi", "Moin");
        
        Assert.That(result, Is.EqualTo("HiMoinMoinHi"));
    }

    [Test]
    public void UmgrenzeWort_ReturnsStringWithCorrectPattern()
    {
        var result = _sut.UmgrenzeWort("[[]]", "Muster");
        
        Assert.That(result, Is.EqualTo("[[Muster]]"));
    }

    [Test]
    public void ErstenBeiden_ReturnsFirstTwoLetters()
    {
        var result = _sut.ErstenBeiden("HiHi");
        
        Assert.That(result, Is.EqualTo("Hi"));
    }
    
    [Test]
    public void ErstenBeiden_EmptyString_ReturnsTwoSymbols()
    {
        var result = _sut.ErstenBeiden("");
        
        Assert.That(result, Is.EqualTo("@@"));
    }
}