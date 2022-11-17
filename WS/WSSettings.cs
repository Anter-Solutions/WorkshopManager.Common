using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopManager.Common.WS
{
    public record WSSettings
    {
        public WSSettings()
        {
            Name = "Default";
        }

        public string Name { get; set; }
    }
}
