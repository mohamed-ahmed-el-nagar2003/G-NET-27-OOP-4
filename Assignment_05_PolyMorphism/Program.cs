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
        }
    }
}
