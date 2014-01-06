using FubuMVC.Core;
using FubuMVC.StructureMap;

namespace EmbeddedSharpFubuSite.Backend
{
    public class SimpleApplication : IApplicationSource
    {
        public FubuApplication BuildApplication()
        {
            return FubuApplication.For<EmbeddedSharpFubuSiteRegistry>().StructureMap();
        }
    }
}