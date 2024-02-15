

namespace codingchallenge.Controllers
{
    using AutoMapper;
    using codingchallenge.DTO;
    using codingchallenge.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService flightService;
        private readonly IMapper _mapper;
        private readonly IConfiguration configuration;
        private ILogger<FlightController> logger;

        public FlightController(IFlightService flightService, IMapper mapper, IConfiguration configuration, ILogger<FlightController> logger)
        {
            this.flightService = flightService;
            _mapper = mapper;
            this.configuration = configuration;
            this.logger = logger;
        }

        [HttpGet, Route("GetAllFlights")]
        public IActionResult GetAllFlights()
        {
            try
            {
                List<Flight> flights = flightService.GetAllFlights();
                List<FlightDTO> flightDTOs = _mapper.Map<List<FlightDTO>>(flights);
                return Ok(flightDTOs);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost, Route("CreateFlight")]
        public IActionResult CreateFlight(Flight flight)
        {
            try
            {
                Flight _flight = _mapper.Map<Flight>(flight);
                flightService.CreateFlight(_flight);
                return StatusCode(200, _flight);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

              [HttpGet, Route("GetFlightById")]
             //[Authorize(Roles = "Admin")]
             public IActionResult GetFlightById(int flightId)
             {
            try
            {
                Flight flight = flightService.GetFlightById(flightId);
                FlightDTO flightDTO = _mapper.Map<FlightDTO>(flight);
                if (flight != null)
                {
                    return Ok(flightDTO);
                }
                else
                    return StatusCode(404, new JsonResult("Invalid Id"));
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut, Route("EditFlight")]
        public IActionResult EditFlight(Flight flight)
        {
            try
            {
                Flight _flight = _mapper.Map<Flight>(flight);
                flightService.UpdateFlight(_flight);
                return StatusCode(200, flight);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

    }

}
