using MyCompany.Intranet.Core;

namespace MyCompany.Intranet.Tests;

public class BMIServiceShould
{
    [Fact]
    public void ProcessBMI_WhenIndexLessThan18_5ReturnsTypeLow()
    {
        //arrange
        var expectedType = BMIType.Low;
        var person = new Person { height = 1.70f, weight = 50f };
        var sut = new BMIService();
        
        //act
        var result = sut.ProcessBMI(person);

        //assert
        Assert.Equal(expectedType, result.BMIType);
    } 
    
    [Fact]
    public void ProcessBMI_WhenIndexThan18_5AndLessThan24_9ReturnsTypeNormal()
    {
        //arrange
        var expectedType = BMIType.Normal;
        var person = new Person { height = 1.70f, weight = 70f };
        var sut = new BMIService();
        
        //act
        var result = sut.ProcessBMI(person);

        //assert
        Assert.Equal(expectedType, result.BMIType);
    } 
    
    [Fact]
    public void ProcessBMI_WhenIndexThan24_9AndLessThan29_9ReturnsTypeOverweight()
    {
        //arrange
        var expectedType = BMIType.Overweight;
        var person = new Person { height = 1.70f, weight = 80f };
        var sut = new BMIService();
        
        //act
        var result = sut.ProcessBMI(person);

        //assert
        Assert.Equal(expectedType, result.BMIType);
    } 
    
    [Fact]
    public void ProcessBMI_WhenIndexGreaterThan29_9ReturnsTypeObesity()
    {
        //arrange
        var expectedType = BMIType.Obesity;
        var person = new Person { height = 1.70f, weight = 95f };
        var sut = new BMIService();
        
        //act
        var result = sut.ProcessBMI(person);

        //assert
        Assert.Equal(expectedType, result.BMIType);
    } 
}