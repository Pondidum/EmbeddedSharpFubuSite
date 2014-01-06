using System;
using EmbeddedSharpFubuSite.Backend;
using FubuMVC.Katana;

namespace EmbeddedSharpFubuSite
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            using (var server = EmbeddedFubuMvcServer.For<SimpleApplication>())
            {
                Console.WriteLine("Some long running process, with a web-backend on :5500");
                Console.ReadKey();
            }
        }
    }
}
