using System;
using System.Collections.Generic;

namespace GymManagement.Domain.Entities
{
    public class Manager:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SgkNumber { get; set; }
        public double Salary { get; set; }
        public DateTime PaymenDate { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Worker> Workers { get; set; }
    }
}
