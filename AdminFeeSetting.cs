using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookQuote
{
    public class AdminFeeSetting
    {
        //needs to add some form of credential validation 
        
        public int ID { get; set; }
        public double sewingSetupFee { get; set; }
        public double sig4Cost { get; set; }
        public double sig8Cost { get; set; }
        public double sig12Cost { get; set; }
        public double sig16Cost { get; set; }
        public double caseInSetupFee { get; set; }
        public double caseInPerBookCost { get; set; }
        public double perfectBindSetupFee { get; set; }
        public double perfectBindPerBookCost { get; set; }
        public double endSheetSetupFee { get; set; }
        public double endSheetPerBookCost { get; set; }
        public double caseBindingSetupFee { get; set; }
        public double caseBindingPerBookCost { get; set; }
    }
}
