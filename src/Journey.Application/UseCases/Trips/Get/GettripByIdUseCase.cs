﻿using Journey.Communication.Responses;
using Journey.Exception;
using Journey.Exception.ExceptionsBase;
using Journey.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Journey.Application.UseCases.Trips.Get
{
    public class GettripByIdUseCase
    {
        public ResponseTripJson Execute(Guid id)
        {
             var dbContext = new JourneyDbContext();
                
            var trip = dbContext
                .Trips
                .Include(t => t.Activities)
                .FirstOrDefault(t => t.Id == id);
            if (trip is null)
            {
                throw new NotFoundExeption(ResourceErrorMessages.TRIP_NOT_FOUND);
            }

            return new ResponseTripJson
            {
                Id = trip.Id,
                Name = trip.Name,
                StartDate = trip.StartDate,
                EndDate = trip.EndDate,
                Activities = trip.Activities.Select(a => new ResponseActivityJson
                {
                    Id = a.Id,
                    Name = a.Name,
                     Date = a.Date,
                     Status = (Communication.Enums.ActivityStatus)a.Status
                }).ToList()
                
            };
        }
    }
}
