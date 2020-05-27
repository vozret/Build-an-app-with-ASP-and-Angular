// what we really want to return (not user.cs)
using System;

namespace BabyApp.API.Dtos
{
    public class UserForListDto
    {
        public int Id {get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string NameAndSurname { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string LookingFor { get; set; }
        public string AvailableHours { get; set; }
        public string City { get; set; }
        public string PhotoUrl { get; set; }
    }
}