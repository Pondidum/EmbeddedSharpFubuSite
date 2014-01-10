using FubuMVC.Core;
using FubuMVC.StructureMap;

namespace EmbeddedSharpFubuSite.Backend
{
    public class EmbeddedBackend : IApplicationSource
    {
        public FubuApplication BuildApplication()
        {
            return FubuApplication.For<EmbeddedSharpFubuSiteRegistry>().StructureMap();
        }
    }
}