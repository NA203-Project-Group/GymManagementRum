using System;
using System.Collections.Generic;


namespace GymManagement.Domain.Entities
{
    public class Trainer : BaseEntity
    {
        public List<Member> Members { get; set; }
        
    }
}
