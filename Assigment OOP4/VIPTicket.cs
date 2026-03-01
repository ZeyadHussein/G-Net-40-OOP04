using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP4
{
    public class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; }

        public VIPTicket(int id, string movie, bool lounge, decimal fee)
            : base(id, movie)
        {
            LoungeAccess = lounge;
            ServiceFee = fee;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee:0.00} EGP");
        }
    }
}
