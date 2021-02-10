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
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("Full name of a created object: " + nameOfStaff);
        }
        public static string staffMessage = "This is a static message";
        public string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        //public int HoursWorked
        //{
        //    get
        //    {
        //        return hWorked;
        //    }
        //    set
        //    {
        //        if (value > 0) hWorked = value;
        //        else hWorked = 0;
        //    }
        //}
        public int HoursWorked { get; set; }
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }
        public int CalculatePay()
        {
            //int staffPay = hWorked * hourlyRate;
            int staffPay = HoursWorked * hourlyRate;
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
    } //end of class Staff

    static class printMessage
    {
        public static int number = 10;
        public static void printNumber() {
            Console.WriteLine("static class printMessage: " + number);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Staff.staffMessage);
            Staff dennis = new Staff("Dennis", "Rodman");
            dennis.HoursWorked = 20;
            Console.WriteLine("Dennis' hours worked: " + dennis.HoursWorked);
            Console.WriteLine("Dennis' pay: " + dennis.CalculatePay());
            printMessage.printNumber();
        } //end of method Main
    } //end of class Program
} // end of namespace class Demo
