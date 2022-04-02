using DataStructures;

var s = new Solution();
AssertEqual(s.ContainsDuplicate(new[] {1, 2, 3, 1}), true);
AssertEqual(s.ContainsDuplicate(new[] {1, 2, 3, 4}), false);
AssertEqual(s.ContainsDuplicate(new[] {1, 1, 1, 3, 3, 4, 3, 2, 4, 2}), true);
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
    public bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var n in nums)
        {
            if (set.Contains(n))
            {
                return true;
            }
            set.Add(n);
        }
        return false;
    }
}