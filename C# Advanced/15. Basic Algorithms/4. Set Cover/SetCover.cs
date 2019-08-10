using System;
using System.Linq;
using System.Collections.Generic;

namespace SetCover
{
    class SetCover
    {
        static void Main()
        {
            /*
            // Greedy Algorithm
            */

            //Example:
            //Universe: 1, 2, 3, 4, 5
            //Number of sets: 4
            //1
            //2, 4
            //5
            //3

            //Output:
            //Sets to take (4):
            //{ 2, 4 }
            // { 1 }
            // { 5 }
            // { 3 }

            //Set Cover solution
            List<int> universe = Console.ReadLine()
                .Split(new string[] { "Universe:", " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int numberOfSet = Console.ReadLine()
                .Split(new string[] { "Number of sets:", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).First();
            List<int[]> sets = new List<int[]>();
            for (int i = 0; i < numberOfSet; i++)
            {
                int[] inputSet = Console.ReadLine()
                    .Split(new string[] {" ", "," }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                sets.Add(inputSet);
            }

            List<int[]> resultSet = ChooseSet(sets, universe);

            //Print founds subSets!
            Console.WriteLine($"Sets to take ({resultSet.Count}):");
            foreach (int[] set in resultSet)
            {
                Console.WriteLine($"{{ {String.Join(", ", set)} }}");
            }
        }

        private static List<int[]> ChooseSet(List<int[]> sets, List<int> universe)
        {
            List<int[]> selectedList = new List<int[]>();
            while(universe.Count > 0)
            {
                int[] currentSet = sets.OrderByDescending(n => n.Count(universe.Contains)).First();
                selectedList.Add(currentSet);


                //If it's found subSet removing from universe and sets collections!
                sets.Remove(currentSet);
                foreach (int num in currentSet)
                {
                    universe.Remove(num);
                }
            }

            return selectedList;
        }
    }
}
