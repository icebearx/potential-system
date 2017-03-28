using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLAX_Vacation
{
    class emp
    {
        private static string firstName;
        private static string lastName; 
        private static int _empNumber { get; set; }
        private string password { get; set; }
        private static int hours;
        private string _role { get; set; }
        private static int usedHours;
        private static int unit1 { get; set; }
        private static int unit2 { get; set; }
        private static int unit3 { get; set; }
        private static int unit4 { get; set; }
        private static int unit5 { get; set; }
        private static string _RestDay1 { get; set; }
        private static string _RestDay2 { get; set; }

        public emp()// Constructor that takes no arguments.
        {
            emp.firstName = "unknown"; //initialize
            emp.lastName = "unknown";//initalize
            hours = -1;//initalize
            _role = "default";
        }
        public static int get_empNumber()
        {
            return _empNumber;
        }
        public static void setEmpNumber(int value)  
        {
            _empNumber = value;
        }
        public static string getFirstName()
        {
            return firstName;
        }
        public static void setFirstName(string value)
        {
            firstName = value;
        }
        public static string getLastName()
        {
            return lastName;
        }
        public static void setLastName(string value)
        {
            lastName = value;
        }

        public static int getHoursTaken()
        {
            return usedHours;
        }
        public static int setHoursTaken(int value)
        {
            usedHours = value;
            return usedHours;
        }
        public static int setHoursAvailable(int value)
        {
            hours = value;
            return hours;
        }
        public static int getHoursAvailable()
        {
            return hours;
        }
   
        public string getAccessLevel
        {
            get { return _role; }
        }
 
        public static int setUnit1(int value)
        {
            unit1 = value;
            return value;
        }
        public static int getUnit1()
        {
            return unit1;
        }
        public static int setUnit2(int value)
        {
            unit2 = value;
            return value;
        }
        public static int getUnit2()
        {
            return unit2;
        }
        public static int setUnit3(int value)
        {
            unit3 = value;
            return value;
        }
        public static int getUnit3()
        {
            return unit3;
        }
        public static int setUnit4(int value)
        {
            unit4 = value;
            return value;
        }
        public static int getUnit4()
        {
            return unit4;
        }
        public static int setUnit5(int value)
        {
            unit5 = value;
            return value;
        }
        public static int getUnit5()
        {
            return unit5;
        }
        public emp(string fn)// Constructor that takes one argument.
        {
            firstName = fn;
        }
        public emp (string fn, string ln)
        {
            firstName = fn;
            lastName = ln;
        }
        //Fields, properties, methods and events go here...
        public static string getRestDay1()
        {
            return _RestDay1;
        }
        public static string setRestDay1(string value)
        {
            _RestDay1 = value;
            return value;
        }
        public static string setRestDay2(string value)
        {
            _RestDay2 = value;
            return value;
        }
        public static string getRestDay2()
        {
            return _RestDay2;
        }

        //public class Admin : emp
        //{
            
        //    // Employee fields, properties, methods and events are inherited
        //    // New Admin fields, properties, methods and events go here...
        //}

    }

}
