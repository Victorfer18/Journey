using Journey.Communication.Responses;
using Journey.Infrastructure;

namespace Journey.Application.UseCases.Trips.Get
{
    public class GetAllTripsUsecase
    {
        public ResponseTripsJson Execute()
        {
            var dbContext = new JourneyDbContext();
            var trips = dbContext.Trips.ToList();

            return new ResponseTripsJson
            {
                Trips = trips.Select(t => new ResponseShortTripJson
                {
                    Id = t.Id,
                    Name = t.Name,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate
                }).ToList()
            };

        }
    }
}
