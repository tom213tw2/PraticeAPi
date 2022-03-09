using System.Collections.Generic;

namespace PraticeAPi.Models
{
    public class CountrySunRegionPost
    {
        public class SubRegionPost
        {
            public string SubRegion { get; set; }
        }
        public class SubRegionResultPost
        {
            public string SubRegion { get; set; }
            public IEnumerable<string> Countries { get; set; }
        }

    }
}