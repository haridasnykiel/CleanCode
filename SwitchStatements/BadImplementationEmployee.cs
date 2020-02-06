using System;

namespace SwitchStatements {
    public class BadImplementationEmployee {
        public bool isPayDay (DateTime startDate, EmployeeType employeeType) {
            switch (employeeType) {
                case EmployeeType.Contractor:
                    return IsContractorPayday (startDate);
                default:
                    return IsPermPayday(startDate);
            }
        }

        private bool IsContractorPayday (DateTime startDate) {
            return startDate.AddSeconds (1) == DateTime.Now;
        }

        private bool IsPermPayday (DateTime startDate) {
            return startDate.AddSeconds (10) == DateTime.Now;
        }


        // and so on
    }
}