namespace Assigment_OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            #region Q1: What is the difference between static binding and dynamic binding? When does each one happen?

            /*
            Question:
            What is the difference between static binding and dynamic binding?
            When does each one happen?

            Answer:

            Static Binding:
            Also called Compile-Time Binding. The method call is resolved at compile time.
            Happens when using:
                - Method Overloading
                - Static methods
                - Private methods
                - Non-virtual methods
            The compiler decides which method to call.

            Dynamic Binding:
            Also called Run-Time Binding.The method call is resolved at runtime.Happens when using:
                - Method Overriding
                - virtual and override keywords
            The CLR decides which method to execute based on the object type.

            */
            #endregion

            #region qouestion 2: What is the difference between method overloading and method overriding?

            /*
            Question:
            What is the difference between method overloading and method overriding?

            Answer:

            Method Overloading:
            Same method name. Different parameters (number, type, or order). Happens inside the same class. Compile-time polymorphism

            Method Overriding: Same method name. Same parameters. Happens between base and derived classes.
            Requires inheritance. Runtime polymorphism. Uses virtual and override keywords

            */
            #endregion

            #region qouestion 3: What keywords are used for Method Overriding? What does each one mean?

            /*
            Question:
            What keywords are used for Method Overriding?
            What does each one mean?

            Answer:

            virtual:  Used in base class.  Allows a method to be overridden in a child class.

            override: Used in child class. Provides a new implementation of a virtual method.

            base:Used inside child class. Calls the base class version of the method.

            */
            #endregion


            #endregion

            #region part 2 Practical (Extending the Movie Ticket Booking System)


            Cinema cinema = new Cinema();
            cinema.OpenCinema();

            StandardTicket standard = new StandardTicket(1, "Inception", "A5");
            VIPTicket vip = new VIPTicket(2, "Avengers", true, 50);
            IMAXTicket imax = new IMAXTicket(3, "Dune", true);

            Console.WriteLine("\n========== SetPrice Test ==========");

            standard.SetPrice(150);
            Console.WriteLine("Setting price directly: 150");

            vip.SetPrice(100, 1.5m);
            Console.WriteLine("Setting price with multiplier: 100 x 1.5 = 150");

            imax.SetPrice(180);

            cinema.AddTicket(standard);
            cinema.AddTicket(vip);
            cinema.AddTicket(imax);

            cinema.PrintAllTickets();

            Cinema.ProcessTicket(vip);

            cinema.CloseCinema();


            #endregion
        }
    }
}
