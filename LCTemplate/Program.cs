using DataStructures;

var s = new Solution();
AssertEqual(0, s.m1());
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
    public int m1()
    {
    }
}