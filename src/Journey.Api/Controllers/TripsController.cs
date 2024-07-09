using Journey.Application.UseCases.Trips.Register;
using Journey.Application.UseCases.Trips.Get;
using Journey.Communication.Requests;
using Journey.Exception;
using Journey.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace Journey.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterTripJson request)
        {
            try
            {
                var registerTripUseCase = new RegisterTripUseCase();
                var response = registerTripUseCase.Execute(request);
                return Created(string.Empty, response);
            }
            catch (JourneyExeption ex)
            {
                return BadRequest(ex.Message);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ResourceErrorMessages.INTERNAL_SERVER_ERROR);
            } 
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var useCase= new GetAllTripsUsecase();
            var response = useCase.Execute();
            return Ok(response);
        }
    }
}
