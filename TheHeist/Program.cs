namespace TheHeist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Phase1
            Console.WriteLine("Plan Your Heist!");
            var TeamMembers = new TeamMembers();

            bool addMoreMembers = false;

            do
            {
                bool isNameValid;
                string? name;

                do
                {
                    Console.WriteLine("Team Member Name:");
                    name = Console.ReadLine();

                    isNameValid = !string.IsNullOrWhiteSpace(name);


                    if (!isNameValid) Console.WriteLine("Please enter a valid name!");


                } while (!isNameValid);


                bool isSkillLevelValid;
                byte skillLevel;

                do
                {
                    Console.WriteLine("Skill Level:");
                    isSkillLevelValid = Byte.TryParse(Console.ReadLine(), out skillLevel);

                    if (!isSkillLevelValid) Console.WriteLine("Skill Level should be a positive integer!");


                } while (!isSkillLevelValid);


                bool isCourageFactorValid;
                double courageFactor;

                do
                {
                    Console.WriteLine("Courage Factor:");
                    isCourageFactorValid = Double.TryParse(Console.ReadLine(), out courageFactor);

                    if (isCourageFactorValid && courageFactor >= 0.0 && courageFactor <= 2.0) continue;
                    else
                    {
                        isCourageFactorValid = false;
                        Console.WriteLine("Courage Factor should be between 0.0 and 2.0!");
                    }


                } while (!isCourageFactorValid);

                var teamMember = new TeamMember(name, skillLevel, courageFactor);
                TeamMembers.AddTeamMember(teamMember);
                Console.WriteLine("Do you want to add another member? - Y/N");
                var userResponse = Console.ReadLine().ToLower();
                bool isResponseValid = !string.IsNullOrWhiteSpace(userResponse);

                addMoreMembers = (isResponseValid && userResponse == "y") ? true : false;

            } while (addMoreMembers);

            #endregion

            #region Phase2

            var teamMembers = TeamMembers.GetTeamMembers();

            Console.WriteLine($"There are {teamMembers.Count} member(s) in the team");
            Console.WriteLine("Below are the list of team members----------------");
            Console.WriteLine("//////////////////////////////////////////////////");

            foreach (var member in teamMembers)
            {
                Console.WriteLine(member.ToString());

            }

            Console.WriteLine("//////////////////////////////////////////////////");

            #endregion

        }

    }
}