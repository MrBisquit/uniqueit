namespace uniqueit
{
    public class Identity
    {
        private static char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();
        /// <summary>
        /// Generates a string of 25 characters that use the characters in the seed as an input.
        /// </summary>
        /// <param name="seed">A list of strings can include username, name, email and any others that can effect how the UniqueID is generated.</param>
        /// <returns>A UniqueID generated based off of the data given.</returns>
        public static string UniqueID(List<string> seed, int? id, int length = 25)
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
        /// <summary>
        /// Generates a random string
        /// </summary>
        /// <param name="seed">A seed for the random class can use</param>
        /// <param name="length">How long the string is (defaulted to 25)</param>
        /// <returns>A string generated using the parameters provided</returns>
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
        public class GuidManipulator
        {
            /// <summary>
            /// Creates a GUID object.
            /// </summary>
            /// <returns>A GUID object</returns>
            public static Guid GenerateGuid()
            {
                return Guid.NewGuid();
            }
            /// <summary>
            /// Creates a GUID object and puts it into a string.
            /// </summary>
            /// <returns>A GUID string</returns>
            public static string GenerateGuidToString()
            {
                return Guid.NewGuid().ToString();
            }
            /// <summary>
            /// Converts a GUID object to an array of bytes.
            /// </summary>
            /// <param name="guid">A GUID object</param>
            /// <returns>An array of bytes that came from the GUID object</returns>
            public static byte[] GuidToBytes(Guid guid)
            {
                return guid.ToByteArray();
            }
            /// <summary>
            /// Converts bytes to a GUID
            /// </summary>
            /// <param name="bytes">An array of bytes</param>
            /// <returns>A GUID object</returns>
            public static Guid BytesToGuid(byte[] bytes)
            {
                return new Guid(bytes);
            }
        }
        /// <summary>
        /// Generates a random integer.
        /// </summary>
        /// <param name="minValue">The minimum value for the random integer</param>
        /// <param name="maxValue">The maximum value for the random integer</param>
        /// <param name="seed">The seed for the random class to use. (You can leave this blank)</param>
        /// <returns>A randomly generated integer generated with the parameters you provided.</returns>
        public static int RandomInt(int minValue, int maxValue, int? seed)
        {
            Random r;
            if (seed.HasValue)
            {
                r = new Random(seed.Value);
            }
            else
            {
                r = new Random();
            }
            return r.Next(minValue, maxValue);
        }
        /// <summary>
        /// Generates a random double.
        /// </summary>
        /// <param name="minValue">The minimum value for the random double</param>
        /// <param name="maxValue">The maximum value for the random double</param>
        /// <param name="seed">The seed for the random class to use. (You can leave this blank)</param>
        /// <returns>A randomly generated double generated with the parameters you provided.</returns>
        public static double RandomDouble(double minValue, double maxValue, int? seed)
        {
            Random r;
            if(seed.HasValue)
            {
                r = new Random(seed.Value);
            } else
            {
                r = new Random();
            }
            return r.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}