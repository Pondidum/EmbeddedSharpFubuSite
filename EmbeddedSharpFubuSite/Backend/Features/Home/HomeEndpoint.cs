namespace EmbeddedSharpFubuSite.Backend.Features.Home
{
    public class HomeEndpoint
    {
        public string get_test()
        {
            return "Hi, I'm a test.";
        }

        public HomeViewModel get_index()
        {
            return new HomeViewModel();
        }
    }
}