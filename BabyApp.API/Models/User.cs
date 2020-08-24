using System;
using System.Collections.Generic;

namespace BabyApp.API.Models
{
    public class User
    {
        public int Id {get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string NameAndSurname { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string AvailableHours { get; set; }
        public string City { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Like> Likers { get; set; }
        public ICollection<Like> Likees { get; set; }
        public ICollection<Message> MessageSent { get; set; }
        public ICollection<Message> MessagesReceived { get; set; }
    }
}