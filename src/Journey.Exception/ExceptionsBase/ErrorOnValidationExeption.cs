using System.Net;

namespace Journey.Exception.ExceptionsBase
{
    public class ErrorOnValidationExeption : JourneyExeption
    {
        private readonly IList<string> _erros;
        public ErrorOnValidationExeption(IList<string> messages) : base(string.Empty)
        {
            _erros = messages;
        }

        public override HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.BadRequest;
        }

        public override IList<string> GetErrorsMessages()
        {
            return _erros;
        }
    }
}
