using System;
using System.Collections.Generic;

namespace GymManagement.Domain.Entities
{
    public class Mission:BaseEntity
    {
        public DateTime EndDateTime { get; set; }
        public DateTime Title { get; set; }
        public string Description { get; set; }
        public List<Trainer> Trainers { get; set; }
    }
}
