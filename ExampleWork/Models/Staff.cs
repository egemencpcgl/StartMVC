using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWork.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double IdentificationNumber { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public static List<Staff> GetStaffData()
        {
            var staff1 = new Staff
            {
                Id = 1,
                FirstName = "Egemen",
                LastName = "Capacioglu",
                IdentificationNumber = 15975346821,
                Department= "IT",
                Salary=7500
            };
            var staff2 = new Staff
            {
                Id = 2,
                FirstName = "Hakan",
                LastName = "Oz",
                IdentificationNumber = 15975346821,
                Department = "IT",
                Salary = 7500
            };
            var staff3 = new Staff
            {
                Id = 2,
                FirstName = "Kemal",
                LastName = "Aslan",
                IdentificationNumber = 15975346821,
                Department = "IT",
                Salary = 7500
            };
            List<Staff> sampleData = new List<Staff>();
            sampleData.Add(staff1);
            sampleData.Add(staff2);
            sampleData.Add(staff3);
            return sampleData;
        }
    }
    
}
