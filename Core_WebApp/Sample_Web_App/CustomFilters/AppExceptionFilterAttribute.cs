using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Sample_Web_App.Models;
using Microsoft.AspNetCore.Routing;

using System;
using System.Diagnostics;

namespace Core_WebApp.CustomFilters
{
    public class AppExceptionFilterAttribute : ExceptionFilterAttribute
    {
        //Enterprise1Context ctx;
       
        private readonly IModelMetadataProvider modelMetadata;
        private readonly Enterprise1Context ctx;

        public AppExceptionFilterAttribute(IModelMetadataProvider modelMetadata, Enterprise1Context ctx)
        {
            this.modelMetadata = modelMetadata;
            this.ctx = ctx;
        }

        public override void OnException(ExceptionContext context)
        {
            var timeSpan = Stopwatch.StartNew();
            // 1. Handle Exception to Complete the Execution Process
            context.ExceptionHandled = true;

            // 2. Read the Exception MEssage
            Exception exception = context.Exception;

            // 3. Start the Result Generation Process
            // a. Define a ViewResult Object
            ViewResult viewResult = new ViewResult();
            if (exception.GetType() == typeof(Exception))
            {
                viewResult.ViewName = "CustomError";
            }
            else
            {
                viewResult.ViewName = "DbError";
            }

            // b. Set the View NAme (either Standard Error View or Create a Custom View)
            //viewResult.ViewName = "Error";

            // c. Since the View Needs data, we need to use the ViewDataDictionary
            // modelMetadata: The Current Model used in Request
            // ModelState: State of all Values for Model Objet in Current Request
            ViewDataDictionary valuePairs = new ViewDataDictionary(modelMetadata, context.ModelState);

            // d. define keys for ViewDataDictionary so that they can be passed to View
            valuePairs["ControllerName"] = context.RouteData.Values["controller"].ToString();
            valuePairs["ActionName"] = context.RouteData.Values["action"].ToString();
            valuePairs["Message"] = exception.Message;
            valuePairs["Type"] = exception.GetType().Name;

            // e. pass the valuePairs to ViewData property of ViewResult
            viewResult.ViewData = valuePairs;

            // f. Set the Result property of ExceptionContext to ViewResult
            context.Result = viewResult;

            ExceptionLogTable Exlog = new ExceptionLogTable()
            {
                ControllerName = valuePairs["ControllerName"].ToString(),
                ActionName = valuePairs["ActionName"].ToString(),
                RequestDateTime = System.DateTime.Now,
                ExecutionCompletionTime = timeSpan.Elapsed.TotalMilliseconds.ToString(),
                ExceptionMessage = valuePairs["Message"].ToString(),
                ExceptionType = exception.GetType().Name,

            };
            ctx.ExceptionLogTables.Add(Exlog);
            ctx.SaveChanges();

        }
    }
}

