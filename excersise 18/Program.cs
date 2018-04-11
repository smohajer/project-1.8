using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Trial trial = new Trial();
            trial.FindZero(trial.Test(4, 5));
            int[,] isaac = trial.ZeroColRow(trial.Test(4, 5), trial.X, trial.Y);
            foreach (int i in isaac)
            {
                Console.WriteLine(i);
            }
        }
    }

    internal class Trial
    {
        private int n, m, x, y;

        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        //Default Constructor... not needed, just added for training
        public Trial()
        {

        }

        //Builds array original
        public int[,] Test(int n, int m)
        {
            int[,] original = new int[n, m];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    original[i, j] = counter++;
                }
            }
            return original;
        }

        //Finds rows and columns with 0 in it
        public void FindZero(int[,] parameterArray)
        {
            for (int j = 0; j < parameterArray.GetLength(1); j++)
            {
                for (int i = 0; i < parameterArray.GetLength(0); i++)
                {
                    if (parameterArray[i, j] == 0)
                    {
                        this.x = i;
                        this.y = j;
                    }
                }
            }
        }

        //Turns rows and columns with zero in it to all zeros
        public int[,] ZeroColRow(int[,] parameterArray, int x, int y)
        {
            for (int i = 0; i < parameterArray.GetLength(1); i++)
            {
                parameterArray[x, i] = 0;
            }
            for (int j = 0; j < parameterArray.GetLength(0); j++)
            {
                parameterArray[j, y] = 0;
            }
            return parameterArray;
        }

    }

}
