using Microsoft.Extensions.Logging;
using System.IO;

namespace DotNetCoreConsoleLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            using ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("Esta é uma mensagem log - Diretório atual {0}", Directory.GetCurrentDirectory());
        }
    }
}
