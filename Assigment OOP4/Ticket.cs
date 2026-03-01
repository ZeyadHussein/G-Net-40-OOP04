using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP4
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        protected decimal Price;
        public static decimal TaxRate = 0.10m;

        public decimal PriceAfterTax
        {
            get { return Price + (Price * TaxRate); }
        }

        public Ticket(int id, string movie)
        {
            TicketId = id;
            MovieName = movie;
        }

        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
        }

        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price:0.00} EGP | After Tax: {PriceAfterTax:0.00} EGP");
        }
    }
}
