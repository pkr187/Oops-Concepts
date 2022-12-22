﻿namespace Encapsulation
{
    public class Encapsulation
    {
        // private variables declared
        // these can only be accessed by
        // public methods of class
        private String studentName;
        private int studentAge;

        // using accessors to get and 
        // set the value of studentName
        public String Name
        {
            get
            {
                return studentName;
            }
            set
            {
                studentName = value;
            }
        }
        // using accessors to get and 
        // set the value of studentAge
        public int Age
        {
            get
            {
                return studentAge;
            }
            set
            {
                studentAge = value;
            }
        }
    }
    // Driver Class
    class PKR
    {
        // Main Method
        static public void Main()
        {
            // creating object
            Encapsulation  obj = new Encapsulation();

            // calls set accessor of the property Name, 
            // and pass "Ankita" as value of the 
            // standard field 'value'
            obj.Name = "pankaj";

            // calls set accessor of the property Age, 
            // and pass "21" as value of the 
            // standard field 'value'
            obj.Age = 21;

            // Displaying values of the variables
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}