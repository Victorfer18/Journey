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
           var validator = new RegisterTripValidator();
                var result = validator.Validate(request);
           if (!result.IsValid)
                {
                var errosMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
                throw new ErrorOnValidationExeption(errosMessages);
                }
        }
    }

}
