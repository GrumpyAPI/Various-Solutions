using System;
using System.Collections.Generic;
using System.Text;

namespace Teamwork_Projects
{
    class Team
    {
        public Team(string teamName, string creatorName, List<string> members)
        {
            TeamName = teamName;
            CreatorName = creatorName;
            Members = members;
        }

        public string TeamName { get; set; }

        public string CreatorName { get; set; }

        public List<string> Members { get; set; }
    }
}
