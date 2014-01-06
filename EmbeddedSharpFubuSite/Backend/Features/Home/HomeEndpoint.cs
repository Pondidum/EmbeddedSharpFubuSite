namespace EmbeddedSharpFubuSite.Backend.Features.Home
{
    public class HomeEndpoint
    {
        public HomeViewModel Index()
        {
            return new HomeViewModel { Method = "Index" };
        }
    }
}
