using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp8Features
{
    public class Demo
    {
        public Demo()
        {


            
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



}
