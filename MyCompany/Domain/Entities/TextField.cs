using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        public string CodeWord { get; set; }
        public override string Title { get; set; } = "Information page";
        public override string Text { get; set; } = "Information fill in by administrator";
    }
}
