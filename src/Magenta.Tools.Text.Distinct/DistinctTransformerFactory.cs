namespace Magenta.Tools.Text.Distinct;

public class DistinctTransformerFactory : ITextTransformerFactory
{
    public ITextTransformer Create()
    {
        return new TextDistinctTransformer();
    }
}