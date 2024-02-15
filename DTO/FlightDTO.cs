namespace codingchallenge.DTO
{
    public class FlightDTO
    { 
       
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string Airline { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        
        public double TicketPrice { get; set; }
    }
}
