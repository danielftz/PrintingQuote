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
        private Company company = new Company();
        public Quote()
        {
            InitializeComponent();
            changePresetFeesMenuItem.Click += changePresetFeesMenuItem_Click;
        }


        private void quoteButton_Click(object sender, EventArgs e)
        {
            company.Name = companyNameInput.Text;
            company.Description = description.Text;
            try
            {
                foreach (string count in bookCountList.Items)
                {
                    SingleQuote quote = new SingleQuote();
                    quote.bookCount = Convert.ToDouble(count);
                    
                    quote.sig4Count = Convert.ToDouble(sig4Count.Text);
                    
                    quote.sig8Count = Convert.ToDouble(sig8Count.Text);
                    
                    quote.sig12Count = Convert.ToDouble(sig12Count.Text);
                    
                    quote.sig16Count = Convert.ToDouble(sig16Count.Text);
                    
                    quote.calculate_Costs();
                    company.addQuote(quote);
                }
                //databind table to the list of quotes
                quoteTable.Visible = true;
                quoteTable.AutoGenerateColumns = false;
                quoteTable.DataSource = company.getQuotes();


            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error");
            }
        }

        /*functions related */
        private void enter_bookCount_to_list(object sender, KeyEventArgs e)
        {//this method add bookCount to list that will be calculated
            try
            {
                
                if (bookCount.TextLength>0 && e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true; // remove dings
                    //do this to verify the input was integer
                    bookCountList.Items.Add(Convert.ToInt32(bookCount.Text).ToString());
                    bookCount.ResetText();
                }
                
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error");
            }
        }
        private void add_bookCount_to_list (object sender, EventArgs e)
        {//this method add bookCount to list that will be calculated
            try
            {
                if (bookCount.TextLength > 0)
                {
                    //do this to verify the input was integer
                    bookCountList.Items.Add(Convert.ToInt32(bookCount.Text).ToString());
                    bookCount.ResetText();
                }
                    
            }catch(Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error");
            }
        }

        private void remove_bookCount (object sender, KeyEventArgs k)
        {
            try
            {
                if (bookCountList.SelectedItem != null && k.KeyCode==Keys.Delete)
                {
                    bookCountList.Items.Remove(bookCountList.SelectedItem);
                }        
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error");
            }
        }

        private void bookCount_onClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(bookCount.Text))
            {
                bookCount.SelectAll();
            }
        }

        private void changePresetFeesMenuItem_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.ShowDialog();

        }
    }
}
