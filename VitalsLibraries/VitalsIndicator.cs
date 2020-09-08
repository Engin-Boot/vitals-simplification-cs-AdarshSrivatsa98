using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static VitalsLibraries.VitalBoundaryReport;
namespace VitalsLibraries
{
    class VitalsIndicator
    {   
        
        public static bool vitalsAreOk(float bpm, float spo2, float respRate)
        {   
            bool vitalFlag = 
            WhenBpmGivenThenReturnFalseForCriticalVital(bpm) &&
            WhenSpo2GivenThenReturnFalseForCriticalVital(spo2) &&
            WhenRespRateGivenThenReturnFalseForCriticalVital(respRate);

            return vitalFlag;
        }
    }
}
