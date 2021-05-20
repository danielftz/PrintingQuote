using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote
{
    class SingleQuote
    {
        //most properties of SingleQuote public for now, will figure it out later
        public double quoteID { get; set; }
        public DateTime quoteDate { get; set; }
        public double bookCount { get; set; }
        
        public double sewingSetupFee { get; private set; }
        public double sig4Cost { get; private set; }
        public double sig8Cost { get; private set; }
        public double sig12Cost { get; private set; }
        public double sig16Cost { get; private set; }
        public double caseInSetupFee { get; private set; }
        public double caseInPerBookCost { get; private set; }
        public double perfectBindSetupFee { get; private set; }
        public double perfectBindPerBookCost { get; private set; }
        public double endSheetSetupFee { get; private set; }
        public double endSheetPerBookCost { get; private set; }
        public double caseBindingSetupFee { get; private set; }
        public double caseBindingPerBookCost { get; private set; }

        private void UpdateAdminFees()
        {
            //these values defined in AdminFeeSettings
            sewingSetupFee = AdminFeeSetting.sewingSetupFee;
            sig4Cost = AdminFeeSetting.sig4Cost;
            sig8Cost = AdminFeeSetting.sig8Cost;
            sig12Cost = AdminFeeSetting.sig12Cost;
            sig16Cost = AdminFeeSetting.sig16Cost;
            caseInSetupFee = AdminFeeSetting.caseInSetupFee;
            caseInPerBookCost = AdminFeeSetting.caseInPerBookCost;
            perfectBindSetupFee = AdminFeeSetting.perfectBindSetupFee;
            perfectBindPerBookCost = AdminFeeSetting.perfectBindPerBookCost;
            endSheetSetupFee = AdminFeeSetting.endSheetSetupFee;
            endSheetPerBookCost = AdminFeeSetting.endSheetPerBookCost;
            caseBindingSetupFee = AdminFeeSetting.caseBindingSetupFee;
            caseBindingPerBookCost = AdminFeeSetting.caseBindingPerBookCost;
        }
        
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
            UpdateAdminFees();
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
            this.perBookCost = Math.Round(this.totalCost / this.bookCount);
        }
    }
}
