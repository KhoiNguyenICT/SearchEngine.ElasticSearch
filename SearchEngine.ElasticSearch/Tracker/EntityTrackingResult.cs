using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SearchEngine.ElasticSearch.Tracker
{
    public class EntityTrackingResult
    {
        public List<HookedEntityEntry> EntriesAdded { get; set; } = new List<HookedEntityEntry>();
        public List<HookedEntityEntry> EntriesModified { get; set; } = new List<HookedEntityEntry>();
        public List<HookedEntityEntry> EntriesDeleted { get; set; } = new List<HookedEntityEntry>();

        public DbContext Context { get; set; }
    }
}
