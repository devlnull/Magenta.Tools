using Magenta.Tools.Text.Extensions;

namespace Magenta.Tools.Text.Distinct;

public class TextDistinctTransformer : ITextTransformer
{
    private const char Separator = '\n';
    
    public string Transform(string text)
    {
        var lines = text
            .Split(Separator)
            .CustomDistinct();

        return lines.CleanSeparate(Separator);
    }
}