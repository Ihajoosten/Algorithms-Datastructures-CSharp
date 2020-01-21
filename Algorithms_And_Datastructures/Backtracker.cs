using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdsTryoutCSharp.Backtracker
{
    class Backtracker
    {
        public static void MMain(String[] args)
        {

            MagicSquare ms = new MagicSquare();
            Backtrack(ms);

        }

        private static void Backtrack(MagicSquare ms)
        {
            if (!ms.IsReady())
            {
                // candidate values are from 1 to 9 in case of a magic square of size 3
                for (int i = 1; i < MagicSquare.Size * MagicSquare.Size + 1; i++)
                {
                    if (!ms.CandidateUsed(i))
                    {
                        MagicSquare msCopy = ms.DeepCopy();
                        msCopy.SetCandidate(i);
                        Backtrack(msCopy);
                    }
                }
            }
        }
    }
}
