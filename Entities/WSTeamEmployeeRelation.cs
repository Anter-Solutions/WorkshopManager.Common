using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.Common.Entities
{
    public record WSTeamEmployeeRelation
    {
        public int TeamId { get; set; }
        public int EmployeeId { get; set; }
    }
}
