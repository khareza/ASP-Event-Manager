using EventManager.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Controllers
{
    public class EventController : Controller
    {
        private IEventRepository _context;

        public EventController(IEventRepository context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Events);
        }
    }
}
