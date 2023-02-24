namespace uniqueit
{
    public class Identity
    {
        private static char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();
        /// <summary>
        /// Generates a string of 25 characters that use the characters in the seed as an input.
        /// </summary>
        /// <param name="seed">A list of strings can include username, name, email and any others that can effect how the UUID is generated.</param>
        /// <returns>A UUID generated based off of the data given.</returns>
        public static string GenerateUUID(List<string> seed, int? id, int length = 25)
        {
            if (id == null) id = 0;
            List<char> chars = new List<char>();
            seed.ForEach(input =>
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if(!chars.Contains(input[i]))
                    {
                        chars.Add(input[i]);
                    }
                }
            });

            string UUID = "";
            Random r = new Random((int)id);

            for (int i = 0; i < length; i++)
            {
                UUID += chars[r.Next(chars.Count)];
            }

            return UUID;
        }
        public static string RandomString(int? seed, int length = 25)
        {
            string output = "";
            Random r;
            if(seed.HasValue)
            {
                r = new Random(seed.Value);
            } else
            {
                r = new Random();
            }
            for (int i = 0; i < length; i++)
            {
                output += chars[r.Next(chars.Length)];
            }

            return output;
        }
    }
}