using System;

namespace ClassDemo
{
    class Staff
    {
        public Staff(string name) {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("---------------------------");
        }
        public Staff(string firstName, string lastName) {
            nameOfStaff = firstName + lastName;
            Console.WriteLine("Full name of a created object: " + nameOfStaff);
        }
        public string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0) hWorked = value;
                else hWorked = 0;
            }
        } 
        //public int HoursWorked { get; set; }
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }
        public int CalculatePay ()
        {
            int staffPay = hWorked * hourlyRate;
            PrintMessage();
            return staffPay;
        }
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();
            return hWorked * hourlyRate + bonus + allowance;
        }
        public override string ToString()
        {
            return "Name of Staff: " + nameOfStaff + "hourly rate: " +
                hourlyRate + " hours worked: " + hWorked;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Staff dennis = new Staff("Dennis", "Rodman");
            dennis.HoursWorked = 15;
            Console.WriteLine("Dennis' pay: " + dennis.CalculatePay());
        }     
    }


}
