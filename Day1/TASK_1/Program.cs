/*
Create a Class Employee with the following specifications
Properties
----------
string Name -> no blank names should be allowed
int EmpNo -> must be greater than 0
decimal Basic -> must be between some range
short DeptNo -> must be > 0

Methods
-------
decimal GetNetSalary() -> returns calculated net salary (Use any formula to get net salary based on Basic salary)
*/


using System;

namespace TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Employee obj=new Employee();
            obj.Name = "Aryan";
            obj.Deptno = 1110;
            obj.Empno = 101;
            obj.Basic = 120000.56M;
            obj.GetNetSalary();
            obj.display();
        }
    }

    public class Employee
    {
        private string name;
        private int empno;
        private decimal basic;
        private short deptno;

        //public Employee(string name,int empno,decimal basic,short deptno)
        //{
        //    Empno = empno;
        //    Basic = basic;
        //    Deptno = deptno;
        //    Name = name;

        //}

        public string Name
        {
            set
            {
                if (value == null || value=="")
                    Console.WriteLine("Entered Name is Invalid ");
                else
                    name = value;
            }

            get
            {
                return name;
            }
        }

        public int Empno
        {
            set
            {
                if (value > 0)
                    empno = value;
                else
                    Console.WriteLine("Value must be greater than 0");
            }
            get
            {
                return empno;
            }
        }

        public decimal Basic
        {
            set
            {
                if (value > 0 && value <= 1000000)
                    basic = value;
                else
                    Console.WriteLine("Basic Salary Must be greater than 0 and less than 300000");
            }
            get
            {
                return basic;
            }
        }

        public short Deptno
        {
            set
            {
                if (value > 0)
                    deptno = value;
                else
                    Console.WriteLine("DeptNo should be greater than 0");
            }
            get
            {
                return deptno;
            }
        }


        

        public decimal GetNetSalary()
        {
            decimal hra = Basic * 20/100; 
            decimal da = Basic * 10/100;  
            decimal tax = Basic * 5/100;  
            decimal netSalary = Basic + hra + da - tax;

            return netSalary;
        }

        public void display()
        {
            Console.WriteLine("Employee Name: "+Name);
            Console.WriteLine("EmpNo: "+Empno);
            Console.WriteLine("Employee Basic Salary: "+Basic);
            Console.WriteLine("Employee DeptNo: " + Deptno);
            Console.WriteLine("Net Salary of Employee: "+ GetNetSalary());
        }
    }
}

