using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote
{
    static class AdminFeeSetting
    {
        //needs to add some form of credential validation 
        static public double sewingSetupFee { get; set; }
        static public double sig4Cost { get; set; }
        static public double sig8Cost { get; set; }
        static public double sig12Cost { get; set; }
        static public double sig16Cost { get; set; }
        static public double caseInSetupFee { get; set; }
        static public double caseInPerBookCost { get; set; }
        static public double perfectBindSetupFee { get; set; }
        static public double perfectBindPerBookCost { get; set; }
        static public double endSheetSetupFee { get; set; }
        static public double endSheetPerBookCost { get; set; }
        static public double caseBindingSetupFee { get; set; }
        static public double caseBindingPerBookCost { get; set; }
    }
}
