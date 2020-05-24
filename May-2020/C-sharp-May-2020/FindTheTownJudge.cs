using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_May_2020
{
    class FindTheTownJudge
    {
        public int FindJudge(int N, int[][] trust)
        {
            Dictionary<int, int> possibleJudge = new Dictionary<int, int>(); // Judge, amountOfTrust
            Dictionary<int, int> townFolk = new Dictionary<int, int>(); // Number, amountOfVotes

            foreach (int[] folk in trust)
            {
                //Console.WriteLine("Count : " + possibleJudge.Count);
                if (townFolk.ContainsKey(folk[0]))
                {

                }
                else
                {
                    //Console.WriteLine("Adding townfolk : " + folk[0]);
                    townFolk.Add(folk[0], 1);
                }

                if (possibleJudge.ContainsKey(folk[1]))
                {
                    possibleJudge[folk[1]] = possibleJudge[folk[1]] + 1;
                }
                else
                {
                    //Console.WriteLine("Adding possibleJudge " + folk[1]);
                    possibleJudge.Add(folk[1], 1);
                }
            }

            if (townFolk.Count == N)
            {
                //Console.WriteLine("No judges");
                return -1;
            }
            else if (townFolk.Count == 0 && N == 1)
            {
                //Only one Townfolk and he is a judge.
                return 1;
            }

            foreach (KeyValuePair<int, int> judge in possibleJudge)
            {
            //Console.WriteLine("Comparing " + judge.Value + " and " + (N - 1));
                if (judge.Value == N - 1)
                {
                    return judge.Key;
                }
            }
            return -1;
        }
    }
}
