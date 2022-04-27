using System.Text;

namespace SpaceMarineHasher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var str = args[0];
            var hash = Hasher.CalculateHash(Encoding.UTF8.GetBytes(str));
            Console.Out.Write(Convert.ToHexString(hash));
            //Console.Out.Write(Encoding.UTF8.GetString(hash));
        }
    }
}