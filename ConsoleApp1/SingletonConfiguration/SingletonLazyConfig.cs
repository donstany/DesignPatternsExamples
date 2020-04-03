using System;

namespace ConsoleApp1.SingletonConfiguration
{
    public sealed class SingletonLazyConfig
    {
        private static readonly Lazy<SingletonLazyConfig> lazy =  new Lazy<SingletonLazyConfig> (() => new SingletonLazyConfig());

        public static SingletonLazyConfig Instance { get { return lazy.Value; } }

        private SingletonLazyConfig()
        {
        }
    }
}
