using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public interface IAudit
    {
        DateTime CreationDate { get; set; }
        string CreatedBy { get; set; }
        DateTime EditedDate { get; set; }
        string EditedBy { get; set; }
        DateTime DeletedDate { get; set; }
        string DeletedBy { get; set; }
    }
}
