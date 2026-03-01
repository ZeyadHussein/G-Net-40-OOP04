using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP4
{
    public class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(int id, string movie, string seat)
            : base(id, movie)
        {
            SeatNumber = seat;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Seat: {SeatNumber}");
        }
    }
}
