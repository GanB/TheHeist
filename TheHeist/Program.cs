namespace TheHeist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Phase1
            Console.WriteLine("Plan Your Heist!");

            var teamMember = new TeamMember();

            bool isNameValid;
            string? name;

            do
            {
                Console.WriteLine("Team Member Name:");
                name = Console.ReadLine();

                isNameValid = !string.IsNullOrWhiteSpace(name);


                if (isNameValid) teamMember.Name = name;
                else Console.WriteLine("Please enter a valid name!");


            } while (!isNameValid);


            bool isValidSkillLevel;
            byte skillLevel;

            do
            {
                Console.WriteLine("Skill Level:");
                isValidSkillLevel = Byte.TryParse(Console.ReadLine(), out skillLevel);

                if (isValidSkillLevel) teamMember.SkillLevel = skillLevel;
                else Console.WriteLine("Skill Level should be a positive integer!");


            } while (!isValidSkillLevel);


            bool isValidCourageFactor;
            double courageFactor;

            do
            {
                Console.WriteLine("Courage Factor:");
                isValidCourageFactor = Double.TryParse(Console.ReadLine(), out courageFactor);

                if (isValidCourageFactor && courageFactor >= 0.0 && courageFactor <= 2.0) teamMember.CourageFactor = courageFactor;
                else
                {
                    isValidCourageFactor = false;
                    Console.WriteLine("Courage Factor should be between 0.0 and 2.0!");
                }


            } while (!isValidCourageFactor);

            Console.WriteLine(teamMember.ToString());

            #endregion

        }

    }
}