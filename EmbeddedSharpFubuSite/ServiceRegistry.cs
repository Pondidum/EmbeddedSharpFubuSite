using FubuMVC.Diagnostics;
using SomeServiceCore;
using StructureMap.Configuration.DSL;

namespace EmbeddedSharpFubuSite
{
    public class ServiceRegistry : Registry
    {
        public ServiceRegistry()
        {
            var p = new Processor();

            For<IProcessor>().Singleton().Use(p);

            //Scan(x =>
            //{
            //    x.TheCallingAssembly();
            //    x.WithDefaultConventions();
            //});

        }
    }
}