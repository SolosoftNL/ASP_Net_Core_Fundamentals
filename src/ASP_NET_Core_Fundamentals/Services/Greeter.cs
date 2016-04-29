using Microsoft.Extensions.Configuration;

namespace ASP_NET_Core_Fundamentals.Services
{
    public class Greeter : IGreeter
    {
        string _greeting;

        public Greeter(IConfiguration configuration)
        {
            _greeting = configuration["greeting"];
        }

        public string GetGreeting()
        {
            return _greeting;
        }
    }
}
