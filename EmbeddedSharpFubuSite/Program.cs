using System;
using System.Threading.Tasks;
using EmbeddedSharpFubuSite.Backend;
using FubuMVC.Core.Packaging;
using FubuMVC.Katana;
using SomeServiceCore;
using StructureMap;

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

                var p = server.Services.GetInstance<IProcessor>();
                
                var t = new Task(p.Start);
                t.Start();

                Console.ReadKey();
            }
        }
    }
}
