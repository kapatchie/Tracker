using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.DTO
{
    public class FaultsDTO
    {
               
            public System.Guid Referencenumber { get; set; }
            public string Logger { get; set; }
            public System.DateTime Time { get; set; }
            public string TypeofFault { get; set; }
            public string FaultDescription { get; set; }
        
    }
}

