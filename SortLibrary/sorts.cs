using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLibrary
{
    public static class Sorts
    {
        public static int[]  SortAndUnion(int[] A, int[] B)
        {
            if (A.Length != B.Length)
                throw new Exception("разное кол-во элементов");
            int[] C = Union(A, B);
            Sort(C);
            return C;
        }

        private static void Sort(int[] C)
        {
            for (int i = 0; i < C.Length - 1; i++)
            {
                for (int j = i + 1; j < C.Length; j++)
                {
                    if (C[j] < C[i])
                    {
                        int T = C[j];
                        C[j] = C[i];
                        C[i] = T;
                    }
                }
            }
        }

        private static int[] Union(int[] A, int[] B)
        {
            int[] C = new int[2 * A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
                C[i + A.Length] = B[i];
            }

            return C;
        }
    }
}
