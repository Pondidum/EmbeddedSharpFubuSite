using SomeServiceCore;

namespace EmbeddedSharpFubuSite.Backend.Features.Home
{
    public class HomeEndpoint
    {
        private readonly IProcessor _processor;

        public HomeEndpoint(IProcessor processor)
        {
            _processor = processor;
        }

        public HomeViewModel Index()
        {
            return new HomeViewModel
            {
                Total = _processor.TotalBatchesProcessed,
            };
        }
    }
}
