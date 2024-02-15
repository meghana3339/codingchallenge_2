namespace codingchallenge.Services
{
    
    public interface IFlightService
    {
        void CreateFlight(Flight flight);
        List<Flight> GetAllFlights();
        Flight GetFlightById(int flightId);
        void UpdateFlight(Flight flight);
        
    }

}
