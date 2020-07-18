using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace CSharp8Features
{
    public class Demo
    {

        #region switch expressions
        public enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        } 
        #endregion


        public Demo()
        {
            #region Indices and ranges
            /*
                string[] months =
                {                   // From Start       From End
                    "January",      // 0                ^12
                    "February",     // 1                ^11
                    "March",        // 2                ^10
                    "April",        // 3                ^9
                    "May",          // 4                ^8
                    "June",         // 5                ^7
                    "July",         // 6                ^6
                    "August",       // 7                ^5
                    "September",    // 8                ^4
                    "October",      // 9                ^3
                    "November",     // 10               ^2
                    "December"      // 11               ^1
                };

                WriteLine(months[3]);   // From array start
                WriteLine(months[^12]); // From array end

                var slice = months[^4..^0];
                foreach (var s in slice) WriteLine(s);

                WriteLine(months[months.Length - 1]);
                WriteLine(months[^1]);

                var year = months[..];
                foreach (var s in year) WriteLine(s); // January to December

                var quarter = months[..3];
                foreach (var s in quarter) WriteLine(s); // Quarter 1 - January to March

                var restOfYear = months[3..];
                foreach (var s in restOfYear) WriteLine(s); // April to December


                WriteLine(months[^5]);
                WriteLine(months[months.Length - 5]);

                var yr = months[0..^0];
                foreach (var s in yr) WriteLine(s);

                var july = ^6;
                WriteLine(months[july]); // July

                var firstSemester = 0..6;
                var semester = months[firstSemester];
                foreach (var s in semester) WriteLine(s); // January to June

                var lstmonths = new List<string>
                {
                    "January", "February", "March", "April",
                    "May", "June", "July", "August",
                    "September", "October", "November", "December"
                };

                WriteLine(lstmonths[^2]);
                */
            #endregion

            #region switch expressions
            //WriteLine(GetBirthstone(Months.January));
            //WriteLine(GetBirthstone(Months.February)); 
            #endregion

            #region readonly members
            //var d = new DaysSince() { GivenDate = DateTime.Now.AddMonths(-13) };
            //WriteLine(d); 
            #endregion
        }



        #region nullable reference types
        private void ListStudents(IEnumerable<Student?> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.FirstName);
            }
        }

        #region null-forgiving operator
        private void GetStudentName(Student? student)
        {
            if (student.IsValid())
            {
                Console.WriteLine(student!.FirstName);
            }
        }
        #endregion

        #endregion

        #region switch expressions
        //private string GetBirthstone(Months month)
        //{
        //    switch (month)
        //    {
        //        case Months.January:
        //            return "Ruby or Rose Quartz";
        //        case Months.March:
        //            return "Bloodstone and Aquamarine";
        //        case Months.April:
        //            return "Diamond";
        //        case Months.May:
        //            return "Emerald";
        //        case Months.June:
        //            return "Pearl, Alexandrite, and Moonstone";
        //        case Months.July:
        //            return "Ruby";
        //        case Months.August:
        //            return "Sardonyx and Peridot";
        //        case Months.September:
        //            return "Sapphire";
        //        case Months.October:
        //            return "Opal and The Tourmaline";
        //        case Months.November:
        //            return "Topaz";
        //        case Months.December:
        //            return "Turquoise and Zircon";
        //        default:
        //            return $"Did not find a birth stone for {month}";
        //    }
        //}

        private string GetBirthstone(Months month) =>
            month switch
            {
                Months.January => "Ruby or Rose Quartz",
                Months.March => "Bloodstone and Aquamarine",
                Months.April => "Diamond",
                Months.May => "Emerald",
                Months.June => "Pearl, Alexandrite, and Moonstone",
                Months.July => "Ruby",
                Months.August => "Sardonyx and Peridot",
                Months.September => "Sapphire",
                Months.October => "Opal and The Tourmaline",
                Months.November => "Topaz",
                Months.December => "Turquoise and Zircon",
                _ => $"Did not find a birth stone for {month}",
            }; 
        #endregion






    }





    #region default interface methods
    public class SalesOrder : IOrder
    {
        public void CreateOrder(DateTime orderDate) { }
    }

    public interface IOrder
    {
        void CreateOrder(DateTime orderDate);
        void CreateOrder() => CreateOrder(DateTime.Now);
    }
    #endregion

    #region nullable reference types
    public class Student
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
    #endregion

    #region readonly members
    //public struct DaysSince
    //{
    //    public DateTime GivenDate { get; set; }
    //    public double Number => Math.Round((DateTime.Now - GivenDate).TotalDays, 0);

    //    public override string ToString() => $"Days since {GivenDate} = {Number} days";
    //}


    public struct DaysSince
    {
        public DateTime GivenDate { get; set; }
        public readonly double Number => Math.Round((DateTime.Now - GivenDate).TotalDays, 0);

        public readonly override string ToString() => $"Days since {GivenDate} = {Number} days";
    } 
    #endregion

}
