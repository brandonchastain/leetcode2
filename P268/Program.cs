using DataStructures;

var s = new Solution();
AssertEqual(s.MissingNumber(new[] {3, 0, 1}), 2);
AssertEqual(s.MissingNumber(new[] {0, 1}), 2);
AssertEqual(s.MissingNumber(new[] {9,6,4,2,3,5,7,0,1}), 8);
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
    public int MissingNumber(int[] nums)
    {
        int largest = nums.Length;
        int factorial = 0;
        while (largest > 0)
        {
            factorial += largest;
            largest--;
        }

        int sum = 0;
        foreach (int n in nums)
        {
            sum += n;
        }

        return factorial - sum;
    }
}