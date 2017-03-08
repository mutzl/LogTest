using System.Collections.Generic;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using log4net;

namespace LogTest.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly ILog Logger = LogManager.GetLogger("MyLogger");

        [SwaggerOperation("GetAll")]
        public IEnumerable<string> Get()
        {
            // log4net logger will use AzureTraceAppender (see cs file) 
            // and transform logging levels do different Trace.XXX methods
            Logger.Info("Hello new World"); 
            //Trace.TraceInformation("Tracing the world");
            return new string[] { "value1", "value2" };
        }


    }
}
