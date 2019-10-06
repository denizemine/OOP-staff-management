using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    static class MergeSortClass
    {
        public static List<Staff> Sort(List<Staff> input, string sortChoice)
        {
            List<Staff> Result = new List<Staff>();
            List<Staff> Left = new List<Staff>();
            List<Staff> Right = new List<Staff>();

            if (input.Count <= 1)
                return input;

            int midpoint = input.Count / 2;
            for (int i = 0; i < midpoint; i++)
                Left.Add(input[i]);
            for (int i = midpoint; i < input.Count; i++)
                Right.Add(input[i]);

            Left = Sort(Left, sortChoice); //Recursion! :o
            Right = Sort(Right, sortChoice);
            Result = Merge(Left, Right, sortChoice);

            return Result;



        }
        private static List<Staff> Merge(List<Staff> Left, List<Staff> Right, string sortChoice)
        {
            List<Staff> Result = new List<Staff>();
            while (Left.Count > 0 && Right.Count > 0)
            {
                if (sortChoice == "ascending")
                {
                    if (Left[0].Salary < Right[0].Salary)
                    {
                        Result.Add(Left[0]);
                        Left.RemoveAt(0);
                    }
                    else
                    {
                        Result.Add(Right[0]);
                        Right.RemoveAt(0);
                    }

                }
                else if (sortChoice == "descending")
                {
                    if (Left[0].Salary > Right[0].Salary)
                    {
                        Result.Add(Left[0]);
                        Left.RemoveAt(0);
                    }
                    else
                    {
                        Result.Add(Right[0]);
                        Right.RemoveAt(0);
                    }
                }

            }

            while (Left.Count > 0)
            {
                Result.Add(Left[0]);
                Left.RemoveAt(0);
            }

            while (Right.Count > 0)
            {
                Result.Add(Right[0]);
                Right.RemoveAt(0);
            }

            return Result;
        }
    }
}
