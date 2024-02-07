namespace App.Server.Admin.Services
{
    public interface IMiddlewareHandler
    {
        Task HandlerAsync(string Name, TaskCompletionSource<string> taskCompletion);
    }

    public class MiddlewareHandler : IMiddlewareHandler
    {
        public Task HandlerAsync(string Name, TaskCompletionSource<string> taskCompletion)
        {
            throw new NotImplementedException();
        }
    }
}
