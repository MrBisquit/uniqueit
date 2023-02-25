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
            Guid guid = uniqueit.Identity.GuidManipulator.GenerateGuid();
            string guids = uniqueit.Identity.GuidManipulator.GenerateGuidToString();
            byte[] guidbytes = uniqueit.Identity.GuidManipulator.GuidToBytes(guid);
            Guid guidobject = uniqueit.Identity.GuidManipulator.BytesToGuid(guidbytes);
            Console.WriteLine(guid.ToString());
            Console.WriteLine(guids.ToString());
            string a = "";
            for (int i = 0; i < guidbytes.Length; i++)
            {
                a += guidbytes[i].ToString();
            }
            Console.WriteLine(a);
            Console.WriteLine(guidobject.ToString());
            Console.WriteLine(uniqueit.Identity.RandomInt(0, 100, 5));
            Console.WriteLine(uniqueit.Identity.RandomDouble(0, 100, 5));
        }
    }
}