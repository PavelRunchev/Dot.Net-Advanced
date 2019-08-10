using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger
{
    class VLogger
    {
        private string vloggername;
        private List<string> followers;
        private List<string> followings;

        public VLogger(string name)
        {
            this.Vloggername = name;
            this.followers = new List<string>();
            this.followings = new List<string>();
        }

        public string Vloggername
        {
            get => vloggername;
            set => vloggername = value;
        }

        public List<string> Followers
        {
            get => followers;
        }

        public List<string> Followings
        {
            get => followings;
        }
    }

    class Program
    {
        static void Main()
        {
            List<VLogger> vloggers = new List<VLogger>();

            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] arguments = input.Split();
                string command = arguments[1];
                if(command == "joined" && input.EndsWith("The V-Logger"))
                {
                    string name = arguments[0];
                    VLogger vlogger = new VLogger(name);
                    if(!vloggers.Any(v => v.Vloggername == name))
                        vloggers.Add(vlogger);
                }
                else if(command == "followed" && arguments.Length == 3)
                {
                    string followName = arguments[0];
                    string followingName = arguments[2];
                    VLogger currentFollower = vloggers.FirstOrDefault(x => x.Vloggername == followName);
                    VLogger currentFollowing = vloggers.FirstOrDefault(x => x.Vloggername == followingName);
                    if(currentFollower != null && currentFollowing != null)
                    {
                        if (!currentFollowing.Followers.Contains(currentFollower.Vloggername) 
                            && currentFollowing.Vloggername != currentFollower.Vloggername)
                        {
                            currentFollowing.Followers.Add(currentFollower.Vloggername);
                            currentFollower.Followings.Add(currentFollowing.Vloggername);
                        }
                    }
                }
            }


            PrintVloggers(vloggers);
        }

        private static void PrintVloggers(List<VLogger> vloggers)
        {
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            VLogger mostFamousVlogger = vloggers.OrderByDescending(x => x.Followers.Count).ThenBy(y => y.Followings.Count).First();
            int index = 1;

            if (mostFamousVlogger != null)
            {
                Console.WriteLine($"{index++}. {mostFamousVlogger.Vloggername} : {mostFamousVlogger.Followers.Count} followers, {mostFamousVlogger.Followings.Count} following");
                foreach (string follower in mostFamousVlogger.Followers.OrderBy(f => f))
                {
                    Console.WriteLine($"*  {follower}");
                }

                vloggers.Remove(mostFamousVlogger);
            }

            foreach (var vlogger in vloggers.OrderByDescending(x => x.Followers.Count).ThenBy(y => y.Followings.Count))
            {
                Console.WriteLine($"{index++}. {vlogger.Vloggername} " +
                    $": {vlogger.Followers.Count} followers, {vlogger.Followings.Count} following");
            }
        }
    }
}
