using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class Individual:Person
    {
        public int IDNP { get; set; }
        public IEnumerable <RelationshipType> MyProperty { get; set; }
    }
}
