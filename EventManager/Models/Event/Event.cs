using EventManager.Models.Enums;
using EventManager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models.Event
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan Duration{ get; set; }
        public double Price { get; set; }
        public int PeopleLimit { get; set; }
        public EventStatus Status { get; set; }
        public IMember Organiser { get; set; }
        public List<User> Participants { get; set; }
        public string Location { get; set; }
        public EventType Type { get; set; }

    }
}
