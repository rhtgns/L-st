public class program
{
    public static void Main(string[] args)
    {

        List<string> invitess = new List<string>() { "1-bulent ersoy","2-ajda pekkan","3-ebru gundes",
        "4-hadise","5-hande yener","6-tarkan","7-funda arar","8-demet akalın"};

        foreach (string i in invitess)
        {
            Console.WriteLine(i);
        }

    }
}