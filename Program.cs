using System;

namespace UT1_13
{
    /* Struct: Emploee
     * Purpose: Create an employee blueprint
     * Restrictions: None
     */
    struct Employee
    {
        public string sName;
        public double dSalary;
    }

    /* Class: Program
     * Author: Jonathan Karcher
     * Purpose: Manage employee information
     */
    class Program
    {
      /* Method: Main
       * Purpose: Initialize data and to test if the user will receve a raise
       * Restrictions: None
       */
        static void Main(string[] args)
        {
            // create a new employee
            Employee e = new Employee();
            // initialize the starting salary
            e.dSalary = 30000;
            // propmt the user for their name
            Console.WriteLine("What is your name?");
            // assign the input to the users name
            e.sName = Console.ReadLine();
            // check if the user enterd a specific name
            if (GiveRaise(e))
            {
                Console.WriteLine("Congrtulations you have recieved a raise.");
            }
            // display the current status of the user
            Console.WriteLine("Your salary is {0}.", e.dSalary);
        }
       /* Method: GiveRaise
        * Purpose: Check if the users name is the same as my name, give a raise accordingly
        * Restrictions: None
        */
        static bool GiveRaise(Employee e)
        {
            // check if the name entered is my name
            if (e.sName == "Jonathan Karcher")
            {
                // give a raise
                e.dSalary = 19999.99;
                return true;
            }
            return false;
        }
    }
}