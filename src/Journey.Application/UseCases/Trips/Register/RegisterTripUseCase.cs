using Journey.Communication.Requests;
using Journey.Communication.Responses;
using Journey.Exception;
using Journey.Exception.ExceptionsBase;
using Journey.Infrastructure;
using Journey.Infrastructure.Entities;

namespace Journey.Application.UseCases.Trips.Register
{
    public class RegisterTripUseCase
    {
      public ResponseTripJson Execute(RequestRegisterTripJson request)
        {
            ValidateRequest(request);
            var dbContext = new JourneyDbContext();

            var entity = new Trip
            {
                Name = request.Name,
                StartDate = request.StartDate,
                EndDate = request.EndDate
            };

            dbContext.Trips.Add(entity);
            dbContext.SaveChanges();

            return new ResponseTripJson
            {
                Id = entity.Id,
                Name = entity.Name,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate
            };
        }
        private void ValidateRequest(RequestRegisterTripJson request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                throw new JourneyExeption(ResourceErrorMessages.NOME_EMPTY);
            }
            if (request.StartDate.Date < DateTime.UtcNow.Date)
            {
                throw new JourneyExeption(ResourceErrorMessages.DATE_TRIP_MUST_BE_LATER_THAN_TODAY);
            }
            if (request.EndDate.Date < request.StartDate.Date)
            {
                throw new JourneyExeption(ResourceErrorMessages.END_DATE_TRIP_MUST_BE_LATER_START_DATE);
            }   
            
        }
    }

}
