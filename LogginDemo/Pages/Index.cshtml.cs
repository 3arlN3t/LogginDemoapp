using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LogginDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public IndexModel(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger("DemoCategory");
        }
        public void OnGet()
        {
            //Logging Levels
            _logger.LogTrace("This is trace log");
            _logger.LogDebug("This is debug log");
            _logger.LogInformation("This is an information log");
            _logger.LogWarning("This is a warning log");
            _logger.LogError("This is a error log");
            _logger.LogCritical("This is a critical log");

            //Advance loggin messages
            //_logger.LogError("The server went down at {Time}", DateTime.UtcNow);

            //try
            //{
            //    throw new Exception("You forgot to catch me");
            //}
            //catch (Exception ex)
            //{

            //    _logger.LogCritical(ex, "There was a bad exeption at {Time}", DateTime.Now);
            //}
        }
    }

    public class LoggingId
    {
        public const int DemoCode = 1001;
    }
}
