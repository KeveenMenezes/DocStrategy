namespace DocStrategy.WebApi.Filters;

public class CoreExceptionFilter(
    ILogger<CoreExceptionFilter> logger)
    : IAsyncExceptionFilter
{
    public async Task OnExceptionAsync(ExceptionContext context)
    {
        if (context.Exception is Domain.Exceptions.CoreException coreException)
        {
            logger.LogError(coreException, "NEGOCIO-WEB: {Key} - {Message}", coreException.CoreError.Key, coreException.CoreError.Message);

            context.Result = new JsonResult(coreException.CoreError)
            {
                StatusCode = 400,
                Value = coreException.CoreError,
            };
        }
        else
        {
            var url = context.HttpContext.Request.Path;
            var method = context.HttpContext.Request.Method;
            var queryParams = string.Join(", ", context.HttpContext.Request.Query.Select(q => $"{q.Key}={q.Value}"));

            var logGuid = Guid.NewGuid();

            logger.LogError(
                context.Exception,
                @"ERROR-WEB:{Message} -LogId:{LogGuid} -Method:{Method} -Url:{Url} -Query Params:{QueryParams} -StackTrace:{StackTrace}",
                context.Exception.Message,
                logGuid,
                method,
                url,
                queryParams,
                context.Exception.StackTrace);

            context.Result = new JsonResult(new
            {
                Error = "ErroInternoServidor",
                Message = "Ocorreu um erro inesperado. Por favor, tente novamente mais tarde.",
                LogId = logGuid,
            })
            {
                StatusCode = 500,
            };
        }

        context.ExceptionHandled = true;
        await Task.CompletedTask;
    }
}