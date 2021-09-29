using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class Person:IAudit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBerth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate {get; set; }
        public string CreatedBy {get; set; }
        public DateTime EditedDate {get; set; }
        public string EditedBy {get; set; }
        public DateTime DeletedDate {get; set; }
        public string DeletedBy {get; set; }
        public int Share { get; set; }

    }
}
