using System.Collections.Generic;
using SearchEngine.ElasticSearch.Contracts;

namespace SearchEngine.ElasticSearch
{
    public static class MapTypeSearch
    {
        public static Dictionary<string, IDocumentInfo> Map { private set; get; } = new Dictionary<string, IDocumentInfo>();
        internal static bool AutoRefeshDefault { get; set; }
        internal static void AddMap<TEntity>(IDocumentInfo documentInfo)
        {
            Map.Add(typeof(TEntity).FullName, documentInfo);
        }

    }
}
