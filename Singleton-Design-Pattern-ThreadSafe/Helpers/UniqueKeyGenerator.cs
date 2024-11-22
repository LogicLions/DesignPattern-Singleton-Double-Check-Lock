using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern_ThreadSafe.Helpers
{
    public sealed class UniqueKeyGenerator
    {
        private static UniqueKeyGenerator instance = null!;
        private static object locking = new object();

        private Guid UniqueKey;

        private UniqueKeyGenerator(Guid uniqueKey) 
        {
            this.UniqueKey = uniqueKey;
        }

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
