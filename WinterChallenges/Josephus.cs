using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WinterChallenges
{
    class Josephus
    {
        public static int LastPersonStanding(int numberOfPeeps, int killingInterval)
        {

            //formula: LastPersonStanding(numberOfPeeps, killingInterval) = (((LastPersonStanding(numberOfPeeps - 1), killingInterval) + killingInterval - 1) % numberOfPeeps) + 1, where LastPersonStanding(1, killingInterval) = 1

            if (numberOfPeeps == 1)
                return 1;
            else
                return (LastPersonStanding(numberOfPeeps - 1, killingInterval) + killingInterval - 1) % numberOfPeeps + 1;
        }

        //REFACTOR CODE TO DISPLAY THE DECEASED IN PARENTHESIS 
        //EXAMPLE
        //1st round: 1 2 (3) 4 5 (6) 7 8 (9) 10
        //2nd round:                            1 (2) 4 5 (7) 8 10
        //3rd round:                                                (1) 4 5 (8) 10
        //4th round:                                                               4 (5) 10
        //5th round:                                                                        4 (10)


            //create a list of peeps
            //var circle = Enumerable.Range(1, numberOfPeeps).ToList();
            //indicates starting position
            //var position = 1;
            //creates a list of dead peeps
            //var deceased = new List<int>();
            //while (circle.Count > 1)
           //{

        //        for (var i = 0; i < circle.Count; i++)
        //        {
        //            if (position % killingInterval == 0)
        //            {
        //                deceased.Add(circle[i]);
        //            }
        //            position++;
        //        }
        //        circle = circle.Where(x => !deceased.Contains(x)).ToList();

        //    }
        //    return circle.First();
        //}


            

        }
}
