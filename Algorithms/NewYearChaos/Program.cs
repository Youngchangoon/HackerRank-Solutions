using System;

class NewYearChaos
{
    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int swapCount = 0;
        int[] countLen = new int[q.Length];

        while (true)
        {
            bool isSwaped = false;
            for (var i = 0; i < q.Length; ++i)
            {
                if (i == 0)
                    continue;

                var curNum = q[i];
                var prevNum = q[i - 1];

                if (prevNum > curNum)
                {
                    isSwaped = true;

                    q[i - 1] = curNum;
                    q[i] = prevNum;

                    ++swapCount;
                    if (++countLen[prevNum - 1] > 2)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                }
            }

            if (isSwaped == false)
                break;
        }

        Console.WriteLine(swapCount);
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            minimumBribes(q);
        }
    }
}
