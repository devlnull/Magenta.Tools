namespace Magenta.Tools.Text.Extensions;

public static class TextExtensions
{
    public static string CleanSeparate(this IEnumerable<string> lines, char separator)
    {
        ArgumentNullException.ThrowIfNull(lines);

        if (lines.Any() is false)
            return string.Empty;

        var textResult = string.Join(separator, lines);

        return textResult.TrimStart(separator).TrimEnd(separator);
    }
}