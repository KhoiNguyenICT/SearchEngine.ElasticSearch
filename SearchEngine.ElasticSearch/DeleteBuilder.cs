using System;
using SearchEngine.ElasticSearch.Enum;

namespace SearchEngine.ElasticSearch
{
    public class DeleteBuilder
    {
        public string PropertyName { get; internal set; }
        public DeleteBehavior Behavior { get; internal set; }
        public Type EntityType { get; internal set; }
    }
}
