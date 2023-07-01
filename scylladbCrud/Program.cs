using Cassandra;
using System;

namespace scylladbCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var cluster = Cluster.Builder()
                .AddContactPoints("172.17.0.2:9042")
                .Build();


            var session = cluster.Connect("sample_keyspace");

            Console.ReadKey();
        }
    }
}
