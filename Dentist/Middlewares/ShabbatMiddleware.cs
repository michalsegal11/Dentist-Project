namespace Dentist.Api.Middlewares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ShabbatMiddleware> _logger;

        public ShabbatMiddleware(RequestDelegate next, ILogger<ShabbatMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var requestSeq = Guid.NewGuid().ToString();
            _logger.LogInformation($"Request Starts {requestSeq}");
            context.Items.Add("RequestSequence", requestSeq);
            if (DateTime.Now.DayOfWeek==DayOfWeek.Saturday)
            {
                await context.Response.WriteAsync(new HttpResponseMessage
                {
                    StatusCode = System.Net.HttpStatusCode.Status400BadRequest,
                    Content = new StringContent("Error Message...", System.Text.Encoding.UTF8, "application/json")
                }.ToString());
            }
            else
            {
                await _next(context);
                _logger.LogInformation($"Request Ends {requestSeq}");
            }
           
        }
    }
}
