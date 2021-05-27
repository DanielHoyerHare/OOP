using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Opgave_1
{
    public interface IVehicleInspectionInfo
    {
        public DateTime? LastInspection { get; set; }
        public DateTime? NextInspection();
    }
}
