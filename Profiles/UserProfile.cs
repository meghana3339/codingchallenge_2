using AutoMapper;
using codingchallenge.DTO;
using codingchallenge.Entities;

namespace codingchallenge.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }

    }
}
