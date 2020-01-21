using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AdsTryoutCSharp.Backtracker
{
    public class MagicSquare
    {

        // for a magic square of size 3, the sum value is 15
        // for a magic square of size 4, the sum value is 34
        public const int Size = 3;
        public const int Sum = 15;
        public const int Empty = 0;

        private enum Status { Solved, NotSolved, Error };

        private int[,] ms = new int[Size, Size];
        private Status status;
        private static int nrSolved = 0;

        /**
         * 
         * @return false "if not completely filled AND all filled rows and columns have sum of value 15 (status NotSolved)"
         *         true "if completely filled AND all rows and columns have sum of value 15 (status Solved)
         *         true "at least one filled row or column sum is not equal to 15 (status Error)"
         */
        public bool IsReady()
        {

            bool completelyFilled = true;

            for (int i = 0; i < Size; i++)
            {
                int rowsum = 0;
                int colsum = 0;
                bool rowFilled = true;
                bool colFilled = true;
                for (int j = 0; j < Size; j++)
                {
                    rowsum += ms[i, j];
                    colsum += ms[j, i];
                    if (ms[i, j] == Empty)
                    {
                        rowFilled = false;
                        completelyFilled = false;
                    }
                    if (ms[j, i] == Empty)
                    {
                        colFilled = false;
                        completelyFilled = false;
                    }
                }
                if (rowsum != Sum && rowFilled)
                {
                    status = Status.Error;
                    return true;
                }
                if (colsum != Sum && colFilled)
                {
                    status = Status.Error;
                    return true;
                }
            }

            if (completelyFilled)
            {
                status = Status.Solved;
                nrSolved++;
                Print();
                return true;
            }

            status = Status.NotSolved;
            return false;
        }

        /*
         * @return a deep copy of the magic square
         */
        public MagicSquare DeepCopy()
        {
            MagicSquare deepCopy = new MagicSquare();
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    deepCopy.ms[i, j] = ms[i, j];
                }
            }
            deepCopy.status = status;
            return deepCopy;
        }

        /*
         * checks if a candidate has already been used in the magic square
         */
        public bool CandidateUsed(int candidate)
        {
            Debug.Assert(candidate != Empty, "invalid value");
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (ms[i, j] == candidate)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /*
         * sets the candidates value if the first empty slot; it searches in the
         * following order: first row, from left to right, 
         * then the second row from left to right, ans so on
         */
        public void SetCandidate(int candidate)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (ms[i, j] == Empty)
                    {
                        ms[i, j] = candidate;
                        return;
                    }
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (ms[i, j] < 10)
                    {
                        Debug.WriteLine(" " + ms[i, j] + " ");
                    }
                    else
                    {
                        Debug.WriteLine(ms[i, j] + " ");
                    }
                }
                Debug.WriteLine("");
            }
            Debug.WriteLine("number of magic squares found is " + nrSolved);
        }
    }
}
