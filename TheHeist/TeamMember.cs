using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist
{
    internal class TeamMember
    {
        private string? Name { get; set; }
        private byte SkillLevel { get; set; }
        private double CourageFactor { get; set; }

        public TeamMember(string? name, byte skillLevel, double courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;  
        }

        public override string ToString()
        {
            return $"{this.Name} has skill level {this.SkillLevel} with courage factor {this.CourageFactor}";
        }



    }
}
