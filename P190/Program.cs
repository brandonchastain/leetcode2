using DataStructures;

var s = new Solution();
AssertEqual(s.reverseBits(0x1), 0x80000000);
AssertEqual(s.reverseBits(4294967293), 3221225471u);
AssertEqual(s.reverseBits(43261596), 964176192u);
Console.WriteLine("All test cases pass!");

static void AssertEqual(object a, object b)
{
    if (!a.Equals(b)) throw new Exception($"Assert failed. Expected {a} but found {b}.");
}

/*

Problem:
190. Reverse Bits

Description:
Reverse bits of a given 32 bits unsigned integer.

Note:

    Note that in some languages, such as Java, there is no unsigned integer type. In this case, both input and output will be given as a signed integer type. They should not affect your implementation, as the integer's internal binary representation is the same, whether it is signed or unsigned.
    In Java, the compiler represents the signed integers using 2's complement notation. Therefore, in Example 2 above, the input represents the signed integer -3 and the output represents the signed integer -1073741825.

 

Example 1:

Input: n = 00000010100101000001111010011100
Output:    964176192 (00111001011110000010100101000000)
Explanation: The input binary string 00000010100101000001111010011100 represents the unsigned integer 43261596, so return 964176192 which its binary representation is 00111001011110000010100101000000.

Example 2:

Input: n = 11111111111111111111111111111101
Output:   3221225471 (10111111111111111111111111111111)
Explanation: The input binary string 11111111111111111111111111111101 represents the unsigned integer 4294967293, so return 3221225471 which its binary representation is 10111111111111111111111111111111.

 

Constraints:

    The input must be a binary string of length 32

 

Follow up: If this function is called many times, how would you optimize it?


Approach 1:
    Get the last bit from the input, shift the output left by 1 and store it in the last bit, shift the input right by 1 and the output left by 1.

    For optimization: Cache the reversed binary string and do a lookup for multiple calls.

*/
public class Solution
{
    public uint reverseBits(uint n)
    {
        uint output = 0;
        int count = 0;
        while (count < 32)
        {
            output = output << 1;
            uint bit = n & 0x01;
            output |= bit;
            n = n >> 1;
            count++;
        }
        return output;
    }

    private void WriteBits(uint n)
    {
        var list = new List<uint>();
        int count = 0;
        while (count < 32)
        {
            uint bit = n & 0x1;
            list.Insert(0, bit);
            n = n >> 1;
            count++;
        }

        Console.WriteLine(String.Join(",", list));
    }
}