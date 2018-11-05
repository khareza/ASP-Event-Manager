using EventManager.Models.Event;
using EventManager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class EventRepository : IEventRepository
    {
        private IQueryable<EventModel> _events = new List<EventModel>
        {
            new EventModel()
            {   Id = 1,Title = "Halloween party",
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. " +
                "Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. " +
                "Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. " +
                "Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. " +
                "In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. ",
                Image = "Empty Image", StartDate = new DateTime(2018,10,31,20,00,00),
                Duration = new TimeSpan(10,0,0),Price = 10,PeopleLimit = 200,
                Status = Enums.EventStatus.Activated, Organiser = new User(),
                Participants = new List<User>(),Location = "Poland, Bielsko-Biała",
                Type = Enums.EventType.Music
            },
            new EventModel()
            {   Id = 2,Title = "O.S.T.R. Live",
                Description = " Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. " +
                "Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. " +
                "Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. ",
                Image = "Empty Image", StartDate = new DateTime(2019,2,14,19,30,00),
                Duration = new TimeSpan(4,0,0),Price = 10,PeopleLimit = 0,
                Status = Enums.EventStatus.Blocked, Organiser = new User(),
                Participants = new List<User>(),Location = "Poland, Bielsko-Biała",
                Type = Enums.EventType.Music
            },
             new EventModel()
            {   Id = 3,Title = "IT Bitad 2018",
                Description = "Quisque rutrum. Aenean imperdiet. " +
                 "Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus.",
                Image = "Empty Image", StartDate = new DateTime(2018,3,20,15,00,00),
                Duration = new TimeSpan(5,0,0),Price = 0,PeopleLimit = 100,
                Status = Enums.EventStatus.Finished, Organiser = new User(),
                Participants = new List<User>(),Location = "Poland, Bielsko-Biała",
                Type = Enums.EventType.It
            },
        }.AsQueryable<EventModel>();
        public IQueryable<EventModel> Events => _events;

        public void AddEvent(EventModel newEvent)
        {
            throw new NotImplementedException();
        }
    }
}
