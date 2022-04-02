using DataStructures;

var s = new Solution();
AssertEqual(s.FirstBadVersion(), 0);
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
    public int FirstBadVersion(int n)
    {

    }
}