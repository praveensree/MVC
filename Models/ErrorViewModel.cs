using System;

namespace first.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }

        public int EmployeeAge { get; set; }

        public double Salary { get; set; }
    }
    public class SignUp
    {
        public string EmailId { get; set; }
        public string Password { get; set; }

        public bool Agree { get; set; }

        public string Gender { get; set; }

        public States State { get; set; }

        public enum States
        {
            TamilNadu,
            Kerala,
            Karnataka,
            Andhra,
            MadhyaPradesh,
            Gujarat,
            Punjab,
            Haryana,
            Bihar,
            Delhi,
            Maharashtra,
            Goa,
            Telangana,
            Rajastan,
            Pondicherry,
            Kolkata
        }
    }

}
