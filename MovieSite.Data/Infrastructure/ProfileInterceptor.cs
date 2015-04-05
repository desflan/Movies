using System.Linq;
using Castle.DynamicProxy;
using StackExchange.Profiling;

namespace MovieSite.Data.Infrastructure
{
	public class ProfileInterceptor : IInterceptor
	{
		public void Intercept(IInvocation invocation)
		{
			var parameters = string.Join(", ", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray());
			var namespaceAndName = invocation.InvocationTarget.GetType().Name;

			using (MiniProfiler.Current.Step(string.Format("{0} {1}", namespaceAndName, parameters)))
			{
				invocation.Proceed();
			}
		}
	}
}
