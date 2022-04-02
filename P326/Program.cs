using DataStructures;

var s = new Solution();
AssertEqual(s.IsPowerOfThree(9), true);
AssertEqual(s.IsPowerOfThree(11), false);
AssertEqual(s.IsPowerOfThree(0), false);
Console.WriteLine("All test cases pass!");

static void AssertEqual(object a, object b)
{
    if (!a.Equals(b)) throw new Exception($"Assert failed. Expected {a} but found {b}.");
}

/*

Problem:

Description:

Approach 1:

*/
public class Solution
{
    /// "Time Limit Exceeded" for n=1162261468
    public bool IsPowerOfThree_old(int n)
    {
        int x = 0;
        int val = (int)Math.Pow(3, x);
        while (val < n)
        {
            x++;
            val = (int)Math.Pow(3, x);
        }

        return val == n;
    }

    public bool IsPowerOfThree(int n)
    {
        if (n <= 0) return false;

        while (n > 1)
        {
            if (n % 3 > 0)
            {
                return false;
            }
            n = n / 3;
        }

        return true;
    }
}