static class Codewar
{

    public static string NumToString(int num) => $"{num}";
    public static int MakeNegative(int num) => num > 0 ? -num : num;
    public static long[] Digitize(long n)
    {
        return $"{n}".Select(c => (long)c - '0').Reverse().ToArray();
    }
    public static string Disemvowel(string str)
        {
            string[] vowels = {"e","u","i","o","a","E","U","I","O","A"};
            for (int i = 0; i < vowels.Length; i++)
            {
                str = str.Replace(vowels[i],"");
            }
            return str;
        }
    



}