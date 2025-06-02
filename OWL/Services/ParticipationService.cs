using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OWL.Data;
using OWL.Models;

namespace OWL.Services
{
    internal class ParticipationService
    {
        private readonly OwlDbContext _dbContext;

        public ParticipationService(OwlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Participation> GetParticipationsByEvent(int eventId)
        {
            return _dbContext.Participations
                             .Include(p => p.User)
                             .Where(p => p.EventId == eventId)
                             .ToList();
        }

        public bool AddParticipation(int userId, int eventId)
        {
            try
            {
                bool exists = _dbContext.Participations
                                        .Any(p => p.UserId == userId && p.EventId == eventId);
                if (exists)
                    return false;

                var participation = new Participation
                {
                    UserId = userId,
                    EventId = eventId,
                    RegistrationDate = DateTimeOffset.UtcNow
                };

                _dbContext.Participations.Add(participation);
                _dbContext.SaveChanges();
                return true;
            }
            catch (DbUpdateException dbEx)
            {
                var inner = dbEx.InnerException?.Message ?? dbEx.Message;
                MessageBox.Show(
                    $"Nie udało się zapisać udziału w bazie.\nSzczegóły: {inner}",
                    "Błąd zapisu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }



        public bool RemoveParticipation(int userId, int eventId)
        {
            var participation = _dbContext.Participations
                                          .FirstOrDefault(p => p.UserId == userId && p.EventId == eventId);
            if (participation == null)
                return false;

            _dbContext.Participations.Remove(participation);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
