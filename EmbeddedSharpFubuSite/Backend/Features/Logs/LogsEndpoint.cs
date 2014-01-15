using System.Collections.Generic;
using FubuMVC.Core.Ajax;
using FubuMVC.Core.Runtime;

namespace EmbeddedSharpFubuSite.Backend.Features.Logs
{
    public class LogsEndpoint
    {
        public LogsViewModel Index()
        {
            return new LogsViewModel();
        }

        public LogsJsonModel GetLogs()
        {
            var values = new List<Pair>();
            values.Add(new Pair { Name = "Test1" });
            values.Add(new Pair { Name = "Test2" });
            values.Add(new Pair { Name = "Test3" });

            return new LogsJsonModel { Values = values };
        }

    }
}
