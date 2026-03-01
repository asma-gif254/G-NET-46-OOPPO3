using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_46_OOPPO3
{
    internal class ProjectorCinema
    {
        public class Projector
        {
            public void Start() => Console.WriteLine("Projector started.");
            public void Stop() => Console.WriteLine("Projector stopped.");
        }

        public class Cinema
        {
            public string CinemaName { get; set; }
            private Projector _projector;
            private Ticket[] _tickets;
            private int _count = 0;

            public Cinema(string name)
            {
                CinemaName = name;
                _projector = new Projector(); // Composition
                _tickets = new Ticket[20];
            }

            public void AddTicket(Ticket t)
            {
                if (_count < 20)
                {
                    _tickets[_count++] = t;
                }
            }

            public void OpenCinema()
            {
                Console.WriteLine($"========== {CinemaName} Opened ==========");
                _projector.Start();
            }

            public void CloseCinema()
            {
                Console.WriteLine($"\n========== {CinemaName} Closed ==========");
                _projector.Stop();
            }

            public void PrintAllTickets()
            {
                Console.WriteLine("\n========== All Tickets ==========");
                for (int i = 0; i < _count; i++)
                {
                    Console.WriteLine(_tickets[i].ToString());
                }

                Console.WriteLine("\n========== Statistics ==========");
                Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");
            }
        }
    }
}
