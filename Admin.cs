using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookQuote
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void saveSettingButton_Click(object sender, EventArgs e)
        {
            AdminFeeSetting.sewingSetupFee = Convert.ToDouble(sewingSetupFee.Text);
            AdminFeeSetting.sig4Cost = Convert.ToDouble(sig4Cost.Text);
            AdminFeeSetting.sig8Cost = Convert.ToDouble(sig8Cost.Text);
            AdminFeeSetting.sig12Cost = Convert.ToDouble(sig12Cost.Text);
            AdminFeeSetting.sig16Cost = Convert.ToDouble(sig16Cost.Text);
            AdminFeeSetting.caseInSetupFee = Convert.ToDouble(caseInSetupFee.Text);
            AdminFeeSetting.caseInPerBookCost = Convert.ToDouble(caseInCost.Text);
            AdminFeeSetting.caseBindingSetupFee = Convert.ToDouble(caseBindingSetupFee.Text);
            AdminFeeSetting.caseBindingPerBookCost = Convert.ToDouble(caseBindingCost.Text);
            AdminFeeSetting.endSheetSetupFee = Convert.ToDouble(endSheetGlueSetupFee.Text);
            AdminFeeSetting.endSheetPerBookCost = Convert.ToDouble(endSheetGlueCost.Text);
            AdminFeeSetting.perfectBindSetupFee = Convert.ToDouble(perfectBindSetupFee.Text);
            AdminFeeSetting.perfectBindPerBookCost = Convert.ToDouble(perfectBindCost.Text);
        }
    }
}
