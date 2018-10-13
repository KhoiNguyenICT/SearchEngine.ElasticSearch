using System;

namespace SearchEngine.ElasticSearch.Extensions
{
    internal static class StringExtension
    {
        internal static string ToCameCase(this string value)
        {
            return Char.ToLowerInvariant(value[0]) + value.Substring(1);
        }

    }
}
