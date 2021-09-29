using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        public override string Title { get; set; } 
        public override string Subtitle { get; set; } 
        public override string Text { get; set; }

    }
}
