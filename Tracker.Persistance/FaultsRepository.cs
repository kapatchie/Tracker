using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.DTO;

namespace Tracker.Persistance
{
    class FaultsRepository
    {

        public static List<FaultsDTO> GetFaults()
        {
            myDBEntities db = new myDBEntities();
            var faults = db.Faults;
            List<FaultsDTO> faultList = new List<FaultsDTO>();

            foreach (var fault in faults)
            {
                var dtoFault = new FaultsDTO();
                dtoFault.Referencenumber = fault.Referencenumber;
                dtoFault.Logger = fault.Logger;
                dtoFault.Time = fault.Time;
                dtoFault.TypeofFault = fault.TypeofFault;
                dtoFault.FaultDescription = fault.FaultDescription;

                faultList.Add(dtoFault);
            }
            return faultList;
        }
    }
}
