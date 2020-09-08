using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VitalsLibraries
{
    class VitalBoundaryReport
    {
        public static bool WhenBpmGivenThenReturnFalseForCriticalVital(float bpm) {
            if (bpm < 70 || bpm > 150)
                return false;
            else return true;
        }
        public static bool WhenSpo2GivenThenReturnFalseForCriticalVital(float spo2) {
            if (spo2 < 90)
                return false;
            else return true;
        }
        public static bool WhenRespRateGivenThenReturnFalseForCriticalVital(float respRate) {
            if (respRate < 30 || respRate > 95)
                return false;
            else return true;
        }
    }
}
