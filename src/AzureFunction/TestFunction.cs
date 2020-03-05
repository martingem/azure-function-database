using System;
using AzureFunction.Contexts;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunction
{
    public class TestFunction
    {
        private readonly TestContext context;

        public TestFunction(TestContext context)
        {
            this.context = context;
        }

        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
