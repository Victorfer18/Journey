using Journey.Communication.Responses;
using Journey.Exception;
using Journey.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Journey.Api.Filters
{
    public class ExeptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is JourneyExeption exeption)
            {
                var journeyExeption = (JourneyExeption)context.Exception;
                context.HttpContext.Response.StatusCode = (int)journeyExeption.GetStatusCode();
                var responseJson = new ResponseErrosJson(journeyExeption.GetErrorsMessages());
                context.Result = new ObjectResult(responseJson);
            }
            else
            {
                context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                var responseJson = new ResponseErrosJson(new List<string> {ResourceErrorMessages.INTERNAL_SERVER_ERROR });
                context.Result = new ObjectResult(ResourceErrorMessages.INTERNAL_SERVER_ERROR);
            }
        }
    }
}
