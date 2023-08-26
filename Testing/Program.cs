using System.Text;
using uniqueit;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("test");
            list.Add("test@example.com");
            Console.WriteLine(uniqueit.Identity.UniqueID(list, 5));
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
            uniqueit.UniqueID uid = new uniqueit.UniqueID(list, 5);
            byte[] b = uid.GenerateKey();
            string c = "";
            for (int i = 0; i < guidbytes.Length; i++)
            {
                c += b[i].ToString();
            }
            Console.WriteLine(c);
            Console.WriteLine(Encoding.ASCII.GetString(b));

            Console.WriteLine(uniqueit.UUID.NewUUID6().ToString());

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(uniqueit.UUID.NewUUID6().ToString());
            }

            Console.WriteLine(((8 + 4 + 4 + 4 + 4 + 4 + 12) * (8 + 4 + 4 + 4 + 4 + 4 + 12)).ToString() + " possible combinations for UniqueID's UUID 6");

            Console.WriteLine((8 + 4 + 4 + 4 + 4 + 4 + 12).ToString());
        }
    }
}