using System;
using System.Diagnostics;
using static VitalsLibraries.ExpressionBooleanCheck;
using static VitalsLibraries.VitalsIndicator;

class VitalsIndicatorCheck
{
    static int Main() {
        ExpectFalse(vitalsAreOk(40, 91, 92));
        ExpectFalse(vitalsAreOk(175, 100, 60));
        ExpectFalse(vitalsAreOk(100, 85, 92));
        ExpectFalse(vitalsAreOk(100, 91, 25));
        ExpectFalse(vitalsAreOk(100, 100, 100));
        ExpectTrue(vitalsAreOk(100, 95, 60));

        Console.WriteLine("All ok");
        return 0;
    }
}