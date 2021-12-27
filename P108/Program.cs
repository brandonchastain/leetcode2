using DataStructures;

var s = new Solution();
var actual = s.SortedArrayToBST(new[] {1, 3});
var expected = new TreeNode(3, new TreeNode(1));
Assert(expected.Equals(actual));

actual = s.SortedArrayToBST(new[] {-10, -3, 0, 5, 9});
expected = new TreeNode(0, new TreeNode(-3, new TreeNode(-10)), new TreeNode(9, new TreeNode(5)));
Assert(expected.Equals(actual));

Console.WriteLine("All test cases pass!");



static void Assert(bool condition)
{
    if (!condition) throw new Exception("Assert failed");
}

/*

Problem:
108. Convert Sorted Array to Binary Search Tree

Description:
Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.

A height-balanced binary tree is a binary tree in which the depth of the two subtrees of every node never differs by more than one.

Example 1:

      0
   -3   9 
-10    5

Input: nums = [-10,-3,0,5,9]
Output: [0,-3,9,-10,null,5]
Explanation: [0,-10,5,null,-3,null,9] is also accepted:

Example 2:

   3         1
1       or      3

Input: nums = [1,3]
Output: [3,1]
Explanation: [1,3] and [3,1] are both a height-balanced BSTs.

Constraints:

    1 <= nums.length <= 104
    -104 <= nums[i] <= 104
    nums is sorted in a strictly increasing order.

Approach 1:
    We know nums is sorted. We can construct a height-balanced tree by
    taking the middle value of nums as the root of the tree, then build
    the left and right subtrees by recursing on the remaining elements
    to the left and right of the middle value.
*/
public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return BuildTree(nums, 0, nums.Length);
    }

    private TreeNode BuildTree(int[] nums, int start, int length)
    {
        if (start < 0 || (start + length) > nums.Length || length <= 0)
        {
            return null;
        }

        int medIndex = start + (length / 2);
        int med = nums[medIndex];
        var root = new TreeNode(med);

        int leftLength = length / 2;
        int rightLength = length / 2;

        if (length % 2 == 0)
        {
            // right side is shorter than left side by 1
            rightLength--;
        }

        root.left = BuildTree(nums, start, leftLength);
        root.right = BuildTree(nums, medIndex + 1, rightLength);

        return root;
    }
}