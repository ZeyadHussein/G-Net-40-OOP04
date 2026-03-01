using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP4
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(int id, string movie, bool is3D)
            : base(id, movie)
        {
            Is3D = is3D;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"IMAX 3D: {(Is3D ? "Yes" : "No")}");
        }
    }
}
