using Assignment_04_PolyMorphism;

namespace Assignment_05_PolyMorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part_01

            #region Q_01
            //Q1 : What is the difference between static binding and dynamic binding? When does each one happen?
            /*
             
            static binding  : used in Overloading, non-virtual methods    Happen in  Compile Time

            dynamic binding : used in Overriding, interfaces  Happen in  Runtime
            
            */

            #endregion

            #region Q_02
            //Q2 :  What is the difference between method overloading and method overriding?
            /*
              Overloading  : Same method name, different parameter lists or parameter type  — within the same class. Resolved at compile time.  
              overriding   : Derived class overrides a virtual method from the base class using the override keyword.  Resolved at run time
            */
            #endregion

            #region Q_03
            //Q3 : What keywords are used for Method Overriding? What does each one mean ?
            /*
              virtual: Used in the base class to allow a method to be overridden in a derived class.
             override: Used in the derived class to provide a new implementation of a virtual method from the base class. 
            */
            #endregion

            #endregion

            #region Part_02 Cinema_System

            //Cinema cinema01 = new Cinema("City");
            //Console.WriteLine("===========================  Open Cinema  ==================================");
            //cinema01.Opencinem();

            //StandardTicket ST01 = new StandardTicket("A15", "Zaky Chann", 200);

            //VipTicket VT01 = new VipTicket(true, "Zaky Chann", 350);

            //IMAXTicket IMAXT01 = new IMAXTicket("Harly", 400, true);

            //IMAXT01.SetPrice(400 , 1.5m);
            //IMAXT01.SetPrice(520);

            //cinema01.AddTicket(ST01);
            //cinema01.AddTicket(VT01);
            //cinema01.AddTicket(IMAXT01);
            

            //Console.WriteLine("===========================  Print All Tickets ==================================");
            //cinema01.PrintallTickets();

            //Console.WriteLine("===========================  Print Ticket Use Process() Method ==================================");
            //ProcessTicket(VT01);

            //Console.WriteLine("===========================  Close Cinema ==================================");
            //cinema01.CloseCinema();

          

            #endregion
        }

        //           Process Ticket
        //public static void ProcessTicket(Ticket t)
        //{
        //    if (t != null)
        //    {
        //        Console.WriteLine($"{t.PrintTicket()}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Ticket is Null ");
        //    }

        //}
    }
}
