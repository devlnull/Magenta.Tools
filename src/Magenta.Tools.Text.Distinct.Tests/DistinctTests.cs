namespace Magenta.Tools.Text.Distinct.Tests;

public class DistinctTests
{
    [Fact]
    public void Distinct_WithDuplicateLines_MustDistinct()
    {
        var arg = "100\n101\n102\n100\n102\n102\n100\n";
        var expectedResult = "100\n101\n102";

        var transformerFactory = new DistinctTransformerFactory();
        var transformer = transformerFactory.Create();

        var result = transformer.Transform(arg);
        
        Assert.Equal(expectedResult, result);
    }
}