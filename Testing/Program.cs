namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("test");
            list.Add("test@example.com");
            Console.WriteLine(uniqueit.Identity.GenerateUUID(list, 5));
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(uniqueit.Identity.RandomString(i));
            }
        }
    }
}