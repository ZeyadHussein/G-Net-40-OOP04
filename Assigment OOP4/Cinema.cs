using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP4
{
    public class Cinema
    {
        private Ticket[] tickets = new Ticket[10];
        private int count = 0;

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ==========");
            Console.WriteLine("Projector started.");
        }
        public void CloseCinema()
        {
            Console.WriteLine("\n========== Cinema Closed ==========");
            Console.WriteLine("Projector stopped.");
        }

        public void AddTicket(Ticket ticket)
        {
            if (count < tickets.Length)
            {
                tickets[count++] = ticket;
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n========== All Tickets ==========");
            for (int i = 0; i < count; i++)
            {
                tickets[i].PrintTicket();
            }
        }


        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n========== Process Single Ticket ==========");
            t.PrintTicket();
        }
    }
}
