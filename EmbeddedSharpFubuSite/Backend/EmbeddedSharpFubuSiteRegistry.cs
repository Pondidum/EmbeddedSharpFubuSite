using FubuMVC.Core;
using FubuMVC.Spark;

namespace EmbeddedSharpFubuSite.Backend
{
    public class EmbeddedSharpFubuSiteRegistry : FubuRegistry
    {
        public EmbeddedSharpFubuSiteRegistry()
        {
            Import<SparkEngine>();

            Routes.IgnoreControllerNamespaceEntirely();
        }
    }
}