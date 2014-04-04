using System.Collections.Generic;

namespace PersonMobilePortal.Models
{
    public class PageModel
    {
        public readonly static IDictionary<string, string> NavButtons = new Dictionary<string, string>()
        {
            { "Profile", "user" },
            { "Skill", "info" },
            { "Exp", "search" },
            { "More", "grid" }
        };

        public string Title { get; set; }

        public string Icon { get; set; }

        public string NavButtonText { get; set; }
    }
}