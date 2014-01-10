using System;
using EmbeddedSharpFubuSite.Backend;
using FubuMVC.Core.Packaging;
using FubuMVC.Katana;

namespace EmbeddedSharpFubuSite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FubuMvcPackageFacility.PhysicalRootPath = @"Backend\";

            using (var server = EmbeddedFubuMvcServer.For<EmbeddedBackend>(FubuMvcPackageFacility.PhysicalRootPath))
            {

                Console.WriteLine("Some long running process, with a web-backend on :5500");
                Console.ReadKey();
            }
        }
    }
}
