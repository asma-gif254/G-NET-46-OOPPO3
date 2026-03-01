using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_46_OOPPO3
{
    internal class Ticket
    {
        private static int _ticketCounter = 0;
        private decimal _price;

        public int TicketId { get; }
        public string MovieName { get; set; }

        public decimal Price
        {
            get => _price;
            set => _price = value > 0 ? value : throw new ArgumentException("Price must be > 0");
        }

        // Computed property for 14% tax
        public decimal PriceAfterTax => Price * 1.14m;

        public Ticket(string movieName, decimal price)
        {
            _ticketCounter++;
            TicketId = _ticketCounter;
            MovieName = movieName;
            Price = price;
        }

        public static int GetTotalTickets() => _ticketCounter;

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }
    }

    // Child Classes
    public class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seatNumber)
            : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }

        public override string ToString() => base.ToString() + $" | Seat: {SeatNumber}";
    }

    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50;

        public VIPTicket(string movieName, decimal price, bool loungeAccess)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override string ToString() => base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
    }

    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3d)
            : base(movieName, price)
        {
            Is3D = is3d;
            if (Is3D) Price += 30; // Increase base price if 3D
        }

        public override string ToString() => base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
    }
}

