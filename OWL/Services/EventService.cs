using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OWL.Data;
using OWL.Models;

namespace OWL.Services
{
    internal class EventService
    {
        private readonly OwlDbContext _context;

        public EventService()
        {
            _context = new OwlDbContext();
        }

        public event EventHandler<Event> EventCreated;

        public bool NewEvent(string title, string description, string date, string location, User organizer)
        {
            try
            {
                var existingUser = _context.Users.Find(organizer.UserId);
                if (existingUser == null)
                    throw new ArgumentException("Organizator nie istnieje w systemie");

                if (_context.Events.Any(e => e.Title == title))
                    return false;

                var newEvent = new Event
                {
                    Title = title,
                    Description = description,
                    Date = date,
                    Location = location,
                    OrganizerId = existingUser.UserId
                };

                _context.Events.Add(newEvent);
                _context.SaveChanges();

                return true;
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"Database error: {dbEx.InnerException?.Message ?? dbEx.Message}");
                throw;
            }
        }

        public bool EditEvent(string title, string description, string date, string location, User organizer, Event editedEvent)
        {
            try
            {
                var existingUser = _context.Users.Find(organizer.UserId);
                if (existingUser == null)
                    throw new ArgumentException("Organizator nie istnieje w systemie");

                var existingEvent = _context.Events.FirstOrDefault(e => e.EventId == editedEvent.EventId);
                if (existingEvent == null)
                    return false;

                existingEvent.Title = title;
                existingEvent.Description = description;
                existingEvent.Date = date;
                existingEvent.Location = location;
                existingEvent.OrganizerId = existingUser.UserId;

                _context.SaveChanges();

                return true;
            }
            catch (DbUpdateException dbEx)
            {
                Console.WriteLine($"Database error: {dbEx.InnerException?.Message ?? dbEx.Message}");
                throw;
            }
        }
    }
}
