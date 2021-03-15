using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProxyPatternExampleProtection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            var proxyDocOp = new ProxyDocumentOperations("test", "test");
            var doc = proxyDocOp.GetDocument(1);

            var proxyDocOpErr = new ProxyDocumentOperations("test1", "test");
            doc.Title = "Document not saved";
            try
            {
                var isSaved = proxyDocOpErr.SaveDocument(doc);
            } catch (Exception ex)
            {
                var err = ex.Message;
            }
            
        }
    }
}
