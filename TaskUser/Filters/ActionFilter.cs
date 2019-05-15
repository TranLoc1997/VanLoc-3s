using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TaskUser.Filters
{
    public class ActionFilter: IActionFilter
    {
        private readonly IHttpContextAccessor _accessor;

        public ActionFilter(IHttpContextAccessor accessor) {
            _accessor = accessor;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var httpContext = _accessor.HttpContext;
            if (httpContext.Session.GetString("name") == null)
            {
                context.Result=new UnauthorizedResult();
            }
        }
 
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // our code after action executes
        }
    }
    
}