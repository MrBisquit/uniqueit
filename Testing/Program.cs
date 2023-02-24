namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("mrbisquit");
            list.Add("test@example.com");
            list.Add("abcdefghjiklpoyrt256346rsdfsdbyn3a5ntg");
            Console.WriteLine(uniqueit.Identity.GenerateUUID(list, 5));
        }
    }
}