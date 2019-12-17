using Microsoft.Extensions.Logging;
using System;

namespace netcore_starter
{
    public class Application
    {
        private readonly ILogger _logger;

        public Application(ILogger<Application> logger)
        {
            _logger = logger;
        }

        internal void Run()
        {
            _logger.LogInformation("Application Started at {dateTime}", DateTime.UtcNow);

            // application logic

            _logger.LogInformation("Application Ended at {dateTime}", DateTime.UtcNow);
        }
    }
}
