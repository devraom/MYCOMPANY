using MyCompany.Intranet.Core;

namespace MyCompany.Intranet.Tests;

public class PersonShould
{
    [Fact]
    public void Weight_SetWeightValue_ReturnSameValue()
    {
        //arrange
        float expected = 70;
        var sut = new Person();
        
        //act
        sut.weight = expected;
        var result = sut.weight;
        
        //assert
        Assert.Equal(expected, result);
    } 
}