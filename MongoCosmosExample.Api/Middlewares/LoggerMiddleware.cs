using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace MongoCosmosExample.Api.Middlewares;
public static class LoggerMiddleware
{
    public static void AddLoggerMiddleware(this IServiceCollection services)
    {
        var logger = UseLoggerMiddleware();
        logger.Write(LogEventLevel.Information, "App initialized");
    }

    private static Logger UseLoggerMiddleware() => 
        new LoggerConfiguration().WriteTo.Console().CreateLogger();
    
}
