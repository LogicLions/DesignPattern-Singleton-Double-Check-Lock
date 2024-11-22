using Singleton_Design_Pattern_ThreadSafe.Helpers;

namespace Singleton_Design_Pattern_ThreadSafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Without Parellelism:-");
            Console.WriteLine(UniqueKeyGenerator.GetInstance().GetUniqueKey);
            Console.WriteLine(UniqueKeyGenerator.GetInstance().GetUniqueKey);
            Console.WriteLine(UniqueKeyGenerator.GetInstance().GetUniqueKey);

            // Invoking multiple methods parellely

            Console.WriteLine("\nWith Parellelism:-");
            Parallel.Invoke(
                    ()=> PrintUniqueKeyThreadFirst(),
                    ()=> PrintUniqueKeyThreadSecond(),
                    ()=> PrintUniqueKeyThreadThird()
                );

            Console.WriteLine("\nPress Any Key...");
            Console.ReadLine();
        }

        private static void PrintUniqueKeyThreadFirst()
        {
            Console.WriteLine("1st:" + UniqueKeyGenerator.GetInstance().GetUniqueKey);
        }

        private static void PrintUniqueKeyThreadSecond()
        {
            Console.WriteLine("2nd:" + UniqueKeyGenerator.GetInstance().GetUniqueKey);
        }

        private static void PrintUniqueKeyThreadThird()
        {
            Console.WriteLine("3rd:" + UniqueKeyGenerator.GetInstance().GetUniqueKey);
        }
    }
}
