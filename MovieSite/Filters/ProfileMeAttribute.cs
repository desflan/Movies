using System;
using System.Web.Mvc;
using StackExchange.Profiling;

namespace MovieSite.Web.Filters
{
	public class ProfileMeAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			var profiler = MiniProfiler.Current;
			var step = profiler.Step("Action: " + filterContext.ActionDescriptor.ActionName);
			filterContext.HttpContext.Items["step"] = step;
		}

		public override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			var step = filterContext.HttpContext.Items["step"] as IDisposable;
			if (step != null)
			{
				step.Dispose();
			}
		}
	}
}