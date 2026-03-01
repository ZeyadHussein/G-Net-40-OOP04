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


            #endregion
        }
    }
}
