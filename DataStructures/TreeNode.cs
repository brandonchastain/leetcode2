namespace DataStructures;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public override bool Equals(object? obj)
    {
        bool isEqual = false;
        if (obj is TreeNode otherNode)
        {
            isEqual = otherNode.val == this.val
                && (otherNode.left?.Equals(this.left) ?? true)
                && (otherNode.right?.Equals(this.right) ?? true);
            
            if (otherNode.val != this.val)
            {
                Console.WriteLine($"{this.val} does not equal {otherNode.val}");
            }
        }
        return isEqual;
    }
}
