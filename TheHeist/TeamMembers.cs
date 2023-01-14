using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist
{
    internal class TeamMembers
    {
        private TeamMember? TeamMember { get; set; }
        private IList<TeamMember> Members = new List<TeamMember>();

        public void AddTeamMember(TeamMember? teamMember)
        {
            if (!(teamMember is null)) Members.Add(teamMember);
        }

        public IList<TeamMember> GetTeamMembers()
        {
            return Members;
        }


    }
}
