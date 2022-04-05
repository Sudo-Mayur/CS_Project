using Core_API.ModelClasses;
using Microsoft.AspNetCore.Routing;

namespace Core_API.CustomMiddleware
{

    public class LogMiddleware
    {
        public readonly RequestDelegate next;
        private  ApiDbContext ctx;
        public LogMiddleware(RequestDelegate request)
        {
            next = request;

        }
        /// <summary>
        /// The Method the contains the Middlweare logic
        /// Current Middleware will use try..catch block since it is used for exception handling 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context, ApiDbContext ctx)
        {
            await next(context); 
            this.ctx = ctx;
            RequiestInfo log = new RequiestInfo()
            {
                ControllerName=context.GetRouteValue("controller").ToString(),
                RequiestMethode = context.Request.Method.ToString(),
                DateTime = System.DateTime.Now,
            };
            await ctx.requiestInfos.AddAsync(log);
            ctx.SaveChanges();

        }
    }

    /// <summary>
    /// AN Extension CLass that provides an extension method
    /// For Registering Custom Middleare into the Http Pipeline  
    /// </summary>
    public static class LogInfoExtensions
    {
        public static void UseLogRequiest(this IApplicationBuilder builder)
        {
            // Registering the CLass as Custom Middleware
            // so that it can be used in Pipeline
            builder.UseMiddleware<LogMiddleware>();
        }
    }
}

