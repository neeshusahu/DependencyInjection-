using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using StackExchange.Redis;
using System.Threading.Tasks;

namespace DependencyInjection.Data.Repository
{
    class Caching
    {
        private static Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {
            string cacheConnection = ConfigurationManager.AppSettings["CacheConnection"].ToString();
            return ConnectionMultiplexer.Connect(cacheConnection);
        });

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
    }
}
