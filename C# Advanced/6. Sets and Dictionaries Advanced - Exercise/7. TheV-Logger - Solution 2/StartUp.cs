using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace theV_Logger_Variant2
{
    class StartUp
    {
        static void Main()
        {
            HashSet<string> vloggers = new HashSet<string>();
            Dictionary<string, List<string>> followers = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> followings = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] arguments = input.Split();
                string command = arguments[1];
                if(command == "joined" && input.EndsWith("The V-Logger"))
                {
                    string name = arguments[0];
                    if (!vloggers.Contains(name))
                    {
                        vloggers.Add(name);
                        followers.Add(name, new List<string>());
                        followings.Add(name, new List<string>());
                    }
                }
                else if(command == "followed" && arguments.Length == 3)
                {
                    string follower = arguments[0];
                    string following = arguments[2];
                    if(follower != following && vloggers.Contains(follower) && vloggers.Contains(following))
                    {
                        if(!followers[following].Contains(follower) && !followings[follower].Contains(following))
                        {
                            followers[following].Add(follower);
                            followings[follower].Add(following);
                        }                   
                    }
                }
            }

            var mostFamousVlogger = vloggers.OrderByDescending(a => followers[a].Count).ThenBy(a => followings[a].Count).ToList().First();
            int index = 1;
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            if(mostFamousVlogger != null)
            {
                Console.WriteLine($"{index++}. {mostFamousVlogger}" +
              $" : {followers[mostFamousVlogger].Count} followers, {followings[mostFamousVlogger].Count} following");
                foreach (var follower in followers[mostFamousVlogger].OrderBy(a => a))
                {
                    Console.WriteLine($"*  {follower}");
                }

                vloggers.Remove(mostFamousVlogger);
            }

            foreach (string v in vloggers.OrderByDescending(a => followers[a].Count).ThenBy(f => followings[f].Count))
            {
                Console.WriteLine($"{index++}. {v} : {followers[v].Count} followers, {followings[v].Count} following");
            }
        }
    }
}
