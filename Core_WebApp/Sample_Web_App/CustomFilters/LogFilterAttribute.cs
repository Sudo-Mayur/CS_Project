using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System.Diagnostics;
using Sample_Web_App.Models;
using System.Diagnostics;
namespace MVC_Assignments.CustomFilters
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        private readonly Enterprise1Context ctx;
        
        // Enterprise1Context ctx;
        //inject the DataBase
        public LogFilterAttribute(Enterprise1Context ctx)
        {
            this.ctx = ctx;
        }

        Stopwatch stopwatch = new Stopwatch();
        private void LogRequest(string currentState, RouteData route)
        {
            //var timeSpan = Stopwatch.StartNew();
            /* string message = $"Current State {currentState} for Exeuting Controller is {route.Values["controller"].ToString()} and Action is {route.Values["action"].ToString()}";
             Debug.WriteLine(message);*/
            LogTable log = new LogTable()
            {
                ControllerName = route.Values["controller"].ToString(),
                ActionName = route.Values["action"].ToString(),
                RequestDateTime = System.DateTime.Now,
                ExecutionCompletionTime = stopwatch.Elapsed.TotalMilliseconds.ToString(),
            };
            ctx.LogTables.Add(log);
            ctx.SaveChanges();
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            stopwatch.Start();
           //LogRequest("OnActionExecuting", context.RouteData);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
           // LogRequest("OnActionExecuted", context.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            //LogRequest("OnResultExecuting", context.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            stopwatch.Stop();
            LogRequest("OnResultExecuted", context.RouteData);
        }
    }
}
