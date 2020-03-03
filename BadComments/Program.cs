using System;

namespace BadComments
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();


            //Employee is eligible for full benefits
            if(employee.Flag && 
            (employee.Age > 65)) 
            {
                Console.WriteLine("employ is eligible");
            }


            if (employee.IsEligibleForFullBenefits())
            {
                Console.WriteLine("employ is eligible");
            }
        }
    }

    class Employee {
        
        public bool Flag {get;set;}
        public int Age {get;set;}

        public bool IsEligibleForFullBenefits() {
            return Flag && (Age > 65);
        }
    }
}
