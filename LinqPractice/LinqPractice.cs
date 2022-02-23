using System.Net.NetworkInformation;

static class LinqPractice
{
    public static void Run()
    {
        var list = new List<string>(){
            "First",
            "Second",
            "Third",
            "Fourth",
            "Fifth",
            "Fourth",
            "First"
        };
        //var newlist = list.Where(x => x.Contains("F"));
        string result = new Ping().Send("vk.com").RoundtripTime.ToString();
        var newlist = list.GroupBy(g => g).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine(string.Join(", ", newlist));
        Console.WriteLine(result);
    }

}