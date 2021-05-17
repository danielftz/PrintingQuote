using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote
{
    class SingleQuote
    {
        //most properties of SingleQuote public for now, will figure it out later
        public double quoteID { get; set; }
        public string memo { get; set; }
        public DateTime quoteDate { get; set; }
        public double bookCount { get; set; }

        /*values that temporarily will be defined in SingleQuote
         *these values in the future will be defined in another class
         */
        public double sewingSetupFee{ get; set; }
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
        /**/

        public double sig4Count;
        public double sig8Count;
        public double sig12Count;
        public double sig16Count;

        public double totalCost { get; private set; }
        public double perBookCost { get; private set; }

        public SingleQuote()
        {
            Random rand = new Random();
            this.quoteID = Math.Floor(rand.NextDouble()*1000000);
        }

        public void calculate_Costs()
        {
            
            double setupFees = this.sewingSetupFee + 
                                this.caseInSetupFee + 
                                this.perfectBindSetupFee + 
                                this.endSheetSetupFee + 
                                this.caseBindingSetupFee;
            double sewingCost = this.sig4Count * this.sig4Cost +
                                this.sig8Count * this.sig8Cost +
                                this.sig12Count * this.sig12Cost +
                                this.sig16Count * this.sig16Cost;

            this.totalCost = setupFees + this.bookCount * (
                                sewingCost+
                                caseInPerBookCost+
                                perfectBindPerBookCost+
                                endSheetPerBookCost+
                                caseBindingPerBookCost);
            this.perBookCost = Math.Round(this.totalCost / this.bookCount,2);
        }
    }
}
