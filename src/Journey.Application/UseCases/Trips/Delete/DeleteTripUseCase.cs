using Journey.Exception;
using Journey.Exception.ExceptionsBase;
using Journey.Infrastructure;

namespace Journey.Application.UseCases.Trips.Delete
{
    public class DeleteTripUseCase
    {
        public void Execute(Guid id)
        {
            var dbContext = new JourneyDbContext();
            if (dbContext.Trips.Find(id) is null)
            {
                throw new NotFoundExeption(ResourceErrorMessages.TRIP_NOT_FOUND);
            }
            dbContext.Trips.Remove(dbContext.Trips.Find(id));
            dbContext.SaveChanges();
            
        }
    }
}
