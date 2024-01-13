namespace Magenta.Tools.Text.Distinct;

public static class DistinctExtensions
{
    public static IEnumerable<TSource> CustomDistinct<TSource>(this IEnumerable<TSource> source)
    {
        return source.Distinct(EqualityComparer<TSource>.Default);
    }

    private static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source,
        IEqualityComparer<TSource> comparer)
    {
        ArgumentNullException.ThrowIfNull(source);
        return DistinctFunc(source, comparer ?? EqualityComparer<TSource>.Default);
    }

    private static IEnumerable<TSource> DistinctFunc<TSource>(IEnumerable<TSource> source,
        IEqualityComparer<TSource> comparer)
    {
        var seenElements = new HashSet<TSource>(comparer);
        foreach (var item in source)
        {
            if (seenElements.Add(item))
            {
                yield return item;
            }
        }
    }
}