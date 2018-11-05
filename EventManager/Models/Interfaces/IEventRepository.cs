using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models.Interfaces
{
    public interface IEventRepository
    {
        IQueryable<Event.EventModel> Events { get; }
        void AddEvent(Event.EventModel newEvent);
    }
}
