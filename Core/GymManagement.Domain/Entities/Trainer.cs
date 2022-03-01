using System;
using System.Collections.Generic;


namespace GymManagement.Domain.Entities
{
    public class Trainer:Worker
    {
        public List<Member> Members { get; set; }
        
    }
}
