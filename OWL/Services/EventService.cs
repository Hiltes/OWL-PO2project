﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OWL.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                {
                    throw new ArgumentException("Organizator nie istnieje w systemie");
                }

                if (_context.Events.Any(e => e.Title == title))
                {
                    return false;
                }

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
    }
    
}

