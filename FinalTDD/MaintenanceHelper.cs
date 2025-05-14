using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalTDD;


namespace FinalTDD
{
    public static class MaintenanceHelper
    {
        public static int CountNeedsService(List<Vehicle> vehicles)
        {
            int count = 0;
            foreach (var v in vehicles)
            {
                if (v.MaintenanceStatus == "Needs Service")
                    count++;
            }
            return count;
        }
    }
}

