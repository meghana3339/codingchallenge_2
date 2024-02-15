using codingchallenge.Database;

namespace codingchallenge.Services
{

public class FlightService : IFlightService
    {
        private readonly MyContext Context;

        public FlightService(MyContext context)
        {
            Context = context;
        }

        public void CreateFlight(Flight flight)
        {
            try
            {
                Context.Flights.Add(flight);
                Context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

       

        public void UpdateFlight(Flight flight)
        {
            Context.Flights.Update(flight);
            Context.SaveChanges();
        }

        public List<Flight> GetAllFlights()
        {
            return Context.Flights.ToList();
        }

        public Flight GetFlightById(int flightId)
        {
            return Context.Flights.Find(flightId);
        }
    }

}

