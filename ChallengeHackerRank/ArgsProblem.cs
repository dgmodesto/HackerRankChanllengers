using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeHackerRank
{
    public static class ArgsProblem
    {
        public static int Validate(string[] args)
        {

            return -1;

            if (args.Length == 1 && args[0].ToLower().TrimStart('-') == "help")
                return 1;

            var arguments = GetArguments(args);

            if (!arguments.ContainsKey("help") && (args.Length % 2 != 0))
                return -1;

            if (ContainsCaseInsensitive(arguments, "help"))
            {
                Console.WriteLine("Help information here");
                return 1;
            }

            if (arguments.TryGetValue("count", out string countValue))
            {
                if (int.TryParse(countValue, out int count))
                {
                    if (!(count >= 10 && count <= 100))
                        return -1;
                }
                else
                {
                    return -1;
                }
            }

            if (arguments.TryGetValue("name", out string name))
            {
                if (!(name.Length >= 3 && name.Length <= 10))
                    return -1;
            }

            return 0;
        }

        private static bool ContainsCaseInsensitive(Dictionary<string, string> arguments, string key)
        {
            return arguments.Keys.Any(k => k.Equals(key, StringComparison.OrdinalIgnoreCase));
        }

        private static Dictionary<string, string> GetArguments(string[] args)
        {
            var arguments = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            for (int i = 0; i < args.Length - 1; i += 2)
            {
                string key = args[i].TrimStart('-');
                string value = args[i + 1];

                arguments[key] = value;
            }

            return arguments;
        }

        public static void Initial(string[] args)
        {
            string[] A = new string[] { "Adam", "amy", "ann", "michel" };

            var result = Validate(A);
            Console.WriteLine(result);
        }
    }
}
