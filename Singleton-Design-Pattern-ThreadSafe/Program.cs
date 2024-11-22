using Singleton_Design_Pattern_ThreadSafe.Helpers;

namespace Singleton_Design_Pattern_ThreadSafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueKeyGenerator.GetInstance().GetUniqueKey);
            Console.WriteLine(UniqueKeyGenerator.GetInstance().GetUniqueKey);
            Console.WriteLine(UniqueKeyGenerator.GetInstance().GetUniqueKey);
        }
    }
}
