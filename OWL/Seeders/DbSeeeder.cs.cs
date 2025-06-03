using System;
using System.Collections.Generic;
using System.Linq;
using OWL.Data;
using OWL.Models;
using OWL.Services;
using System.Windows.Forms; 

namespace OWL.Seeders
{
    public static class Seeder
    {

        public static void Seed()
        {
            using var context = new OwlDbContext();
            var authService = new AuthService();

            // ─── SEED UŻYTKOWNIKÓW ───────────────────────────────────────────────
            try
            {

                if (!context.Users.Any())
                {
                    var seedUsers = new List<(string Username, string Email, string Password)>
                    {
                        ("admin", "admin@firma.pl", "Admin@123"),
                        ("user1", "user1@firma.pl", "User1@123"),
                        ("user2", "user2@firma.pl", "User2@123")
                    };

                    foreach (var (username, email, password) in seedUsers)
                    {
                        
                        if (context.Users.Any(u => u.Username == username))
                        {
                            
                            continue;
                        }

                  
                        bool registered = authService.RegisterUser(username, email, password);

                        if (!registered)
                        {
                
                            MessageBox.Show(
                                $"Nie udało się dodać użytkownika '{username}'.\n" +
                                $"Sprawdź logi lub istnienie roli w PostgreSQL (być może już jest utworzona).",
                                "Seed Użytkownicy – uwaga",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
 
                string inner = ex.InnerException != null ? ex.InnerException.Message : "(brak dodatkowej informacji)";
                MessageBox.Show(
                    $"Błąd podczas seedowania tabeli Users:\n{ex.Message}\n\nInnerException:\n{inner}",
                    "Seed Error – Users",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
        
                return;
            }

            // ─── SEED WYDARZEŃ ───────────────────────────────────────────────────
            try
            {
                if (!context.Events.Any())
                {
          
                    var adminUser = context.Users.FirstOrDefault(u => u.Username == "admin");
                    if (adminUser != null)
                    {
                        var wydarzenia = new List<Event>
                        {
                            new Event
                            {
                                Title = "Owocowy Czwartek",
                                Description = "Czwartkowe śniadanie owocowe dla pracowników.",
                                Date = "2025-07-03",
                                Location = "Biuro Główne",
                                OrganizerId = adminUser.UserId
                            },
                            new Event
                            {
                                Title = "Piknik Firmowy",
                                Description = "Całodniowy piknik dla całej firmy w parku miejskim.",
                                Date = "2025-08-15",
                                Location = "Park Miejski",
                                OrganizerId = adminUser.UserId
                            }
                        };

                        context.Events.AddRange(wydarzenia);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(
                            $"Seed Events: nie znaleziono użytkownika 'admin' w tabeli Users. " +
                            "Sprawdź, czy krok seedowania użytkowników przeszedł poprawnie.",
                            "Seed Warning – Events",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                string inner = ex.InnerException != null ? ex.InnerException.Message : "(brak dodatkowej informacji)";
                MessageBox.Show(
                    $"Błąd podczas seedowania tabeli Events:\n{ex.Message}\n\nInnerException:\n{inner}",
                    "Seed Error – Events",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // ─── SEED PARTICIPATIONS ───────────────────────────────────────────────
            try
            {
                if (!context.Participations.Any())
                {
                    var owocowyEvent = context.Events.FirstOrDefault(e => e.Title == "Owocowy Czwartek");
                    var piknikEvent = context.Events.FirstOrDefault(e => e.Title == "Piknik Firmowy");
                    var user1 = context.Users.FirstOrDefault(u => u.Username == "user1");
                    var user2 = context.Users.FirstOrDefault(u => u.Username == "user2");

                    if (owocowyEvent != null && piknikEvent != null && user1 != null && user2 != null)
                    {
                        var terazUtc = DateTimeOffset.UtcNow;

                        var participations = new List<Participation>
            {
                new Participation
                {
                    EventId = owocowyEvent.EventId,
                    UserId = user1.UserId,
                    RegistrationDate = terazUtc.AddDays(-10) 
                },
                new Participation
                {
                    EventId = owocowyEvent.EventId,
                    UserId = user2.UserId,
                    RegistrationDate = terazUtc.AddDays(-9)   
                },
                new Participation
                {
                    EventId = piknikEvent.EventId,
                    UserId = user1.UserId,
                    RegistrationDate = terazUtc.AddDays(-5)   
                }
            };

                        context.Participations.AddRange(participations);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Seed Participations: brak wymaganych rekordów Users lub Events. " +
                            "Upewnij się, że tabela Users zawiera user1,user2 oraz tabela Events zawiera Owocowy Czwartek i Piknik Firmowy.",
                            "Seed Warning – Participations",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException != null ? ex.InnerException.Message : "(brak dodatkowej informacji)";
                MessageBox.Show(
                    $"Błąd podczas seedowania tabeli Participations:\n{ex.Message}\n\nInnerException:\n{inner}",
                    "Seed Error – Participations",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
