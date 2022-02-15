static class Solution
{

    public static string NumToString(int num) => $"{num}";
    public static int MakeNegative(int num) => num > 0 ? -num : num;
    public static long[] Digitize(long n)
    {
        return $"{n}".Select(c => (long)c - '0').Reverse().ToArray();
    }
    



}