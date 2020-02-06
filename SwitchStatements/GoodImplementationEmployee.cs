using System;

namespace SwitchStatements {
    public abstract class Employee {
        public abstract bool isPayDay ();
        public abstract Money calculatePay ();
        public abstract void deliverPay ();
    }

    public class Contractor : Employee {

        public DateTime StartDate { get; }

        public Contractor (DateTime startDate) {
            StartDate = startDate;
        }

        public override bool isPayDay () {
            return StartDate.AddSeconds (2) == DateTime.Now;
        }

        public override Money calculatePay () {
            return new Money {
                Amount = 150M
            };
        }

        public override void deliverPay () {
            Console.WriteLine ("pay delivered for contractor");
        }
    }

    public class Perm : Employee {

        public DateTime StartDate { get; }

        public Perm (DateTime startDate) {
            StartDate = startDate;
        }

        public override Money calculatePay () {
            return new Money {
                Amount = 150M
            };
        }

        public override void deliverPay () {
            Console.WriteLine ("pay delivered for perm");
        }

        public override bool isPayDay () {
            return StartDate.AddSeconds (10) == DateTime.Now;
        }
    }


    public interface IEmployeeFactory {
        Employee MakeEmployee(DateTime startDate, EmployeeType employeeType); 
    }

    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee MakeEmployee(DateTime startDate, EmployeeType employeeType)
        {
            switch(employeeType) {
                case EmployeeType.Contractor:
                    return new Contractor(startDate);
                default:
                    return new Perm(startDate);
            }
        }
    }


    public class Money {
        public decimal Amount { get; set; }
    }
}