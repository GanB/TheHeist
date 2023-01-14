using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist
{
    internal class TeamMember
    {
        public string? Name { get; set; }
        public byte SkillLevel { get; set; }

        public double CourageFactor { get; set; }

        public override string ToString()
        {
            return $"{this.Name} has skill level {this.SkillLevel} with courage factor {this.CourageFactor}";
        }

    }
}
