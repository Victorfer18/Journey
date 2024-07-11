using System.Net;

namespace Journey.Exception.ExceptionsBase
{
    public class NotFoundExeption : JourneyExeption
    {
        public NotFoundExeption(string message) : base(message)
        {
        }

        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.NotFound;
        }

        public override IList<string> GetErrorsMessages()
        {
            return new List<string> { Message };
        }
    }
}
