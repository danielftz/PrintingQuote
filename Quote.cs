using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookQuote
{
    public partial class Quote : Form
    {
        public Quote()
        {
            InitializeComponent();
        }

        private void create_timestamp(object sender, EventArgs e)
        {
            String localTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            timestamp.Text = localTime;
            timestamp.ForeColor = Color.Black;
        }

        private void quoteButton_Click(object sender, EventArgs e)
        {
            String localTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            timestamp.Text = localTime;
            timestamp.ForeColor = Color.Black;

            double TotalCost=0;
            double SewingCost;
            double CaseInCost;
            double PerfectBindCost;
            double EndSheetGlueCost;
            double CaseBindingCost;
            try
            {
                double BookCount = Convert.ToDouble(bookCount.Text);
                double SewingSetupFee = Convert.ToDouble(sewingSetupFee.Text);
                double Sig8Cost = Convert.ToDouble(sig8Price.Text) * Convert.ToDouble(sig8Count.Text);
                double Sig12Cost = Convert.ToDouble(sig12Price.Text) * Convert.ToDouble(sig12Count.Text);
                double Sig16Cost = Convert.ToDouble(sig16Price.Text) * Convert.ToDouble(sig16Count.Text);
                SewingCost = (Sig8Cost + Sig12Cost + Sig16Cost) * BookCount + SewingSetupFee;
                CaseInCost = Convert.ToDouble(caseInSetupFee.Text) + BookCount * Convert.ToDouble(caseInCost.Text);
                PerfectBindCost = Convert.ToDouble(perfectBindSetupFee.Text) + BookCount * Convert.ToDouble(perfectBindCost.Text);
                EndSheetGlueCost = Convert.ToDouble(endSheetGlueSetupFee.Text) + BookCount * Convert.ToDouble(endSheetGlueCost.Text);
                CaseBindingCost = Convert.ToDouble(caseBindingSetupFee.Text) + BookCount * Convert.ToDouble(caseBindingCost.Text) * Convert.ToDouble(caseBindingCount.Text);

                TotalCost = SewingCost + CaseInCost + PerfectBindCost + EndSheetGlueCost + CaseBindingCost;
                totalCost.Text = TotalCost.ToString();
                perBookCost.Text = Math.Round(TotalCost / BookCount, 2).ToString();


            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message,"Error");
            }
        }
    }
}
