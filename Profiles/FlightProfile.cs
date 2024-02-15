using AutoMapper;
using codingchallenge.DTO;

namespace codingchallenge.Profiles
{

        public class FlightProfile : Profile
        {
            public FlightProfile()
            {
                CreateMap<Flight, FlightDTO>();
                CreateMap<FlightDTO, Flight>();
            }
        }

    }

