using DataStructures;

var s = new Solution();
AssertEqual(s.IsAnagram("anagram", "nagaram"), true);
AssertEqual(s.IsAnagram("rat", "car"), false);
Console.WriteLine("All test cases pass!");

static void AssertEqual(object a, object b)
{
    if (!a.Equals(b)) throw new Exception($"Assert failed. Expected {a} but found {b}.");
}

/*

Problem:
Determine whether strings are anagrams.
Description:

Approach 1:
    Maintain a set of all chars. Create 2 dicts to store letter counts for each string.
    Check that the two dicts are matching.
    Time: O(n + m). We scan each string once, then scan through all occuring characters again for 3 total passes over n + m.
    Space: O(n + m) to store count of each letter in each string
*/
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        var allChars = new HashSet<char>();

        var sCounts = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!sCounts.ContainsKey(c))
            {
                sCounts.Add(c, 0);

                if (!allChars.Contains(c))
                {
                    allChars.Add(c);
                }
            }

            sCounts[c] += 1;
        }

        var tCounts = new Dictionary<char, int>();
        foreach (char c in t)
        {
            if (!tCounts.ContainsKey(c))
            {
                tCounts.Add(c, 0);

                if (!allChars.Contains(c))
                {
                    allChars.Add(c);
                }
            }

            tCounts[c] += 1;
        }

        foreach (char c in allChars)
        {
            if (!sCounts.ContainsKey(c) ||
                !tCounts.ContainsKey(c) ||
                sCounts[c] != tCounts[c])
            {
                return false;
            }
        }

        return true;
    }
}