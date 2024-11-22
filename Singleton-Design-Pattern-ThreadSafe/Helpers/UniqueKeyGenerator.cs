namespace Singleton_Design_Pattern_ThreadSafe.Helpers
{
    //singleton design pattern class
    public sealed class UniqueKeyGenerator
    {
        private static UniqueKeyGenerator instance = null!;
        private static object locking = new object();

        private Guid UniqueKey;

        private UniqueKeyGenerator(Guid uniqueKey) 
        {
            this.UniqueKey = uniqueKey;
        }

        //public method to get the object of class
        public static UniqueKeyGenerator GetInstance()
        {
            if (instance == null)
            {
                lock (locking) 
                {
                    if (instance == null)
                    {
                        instance = new UniqueKeyGenerator(Guid.NewGuid());
                    }
                }
            }
            return instance;
        }

        public Guid GetUniqueKey { get => this.UniqueKey; }
    }
}
