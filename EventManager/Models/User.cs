using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Nickname { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string ContactDetails { get; set; }
        public List<Event.Event> UserEventList { get; set; }
    }
}
