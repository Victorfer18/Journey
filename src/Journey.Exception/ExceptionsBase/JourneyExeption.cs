using System.Net;

namespace Journey.Exception.ExceptionsBase
{
    public abstract class JourneyExeption : SystemException
    {
        public JourneyExeption(string message) : base(message)
        {
        }

        public abstract HttpStatusCode GetStatusCode();

        public abstract IList<string> GetErrorsMessages();
    }
}
