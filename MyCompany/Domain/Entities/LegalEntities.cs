using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class LegalEntities:Person
    {
        public int IDNO { get; set; }
        public double Quota  { get; set; }
       
    }
}
