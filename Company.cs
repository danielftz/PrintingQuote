using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote
{
    class Company
    {
        private double companyID;
        private string name;
        private string description;
        private List<QuoteJob> quoteJobs;
        private List<SingleQuote> quotes;

        public Company()
        {
            Random rand = new Random();
            this.companyID = Math.Floor(rand.NextDouble() * 1000000);

            //initialize quote list
            quotes = new List<SingleQuote>();
        }
        public string Name
        {//get and set company name
            get { return name; }
            set { name = value; }
        }

        public void addQuoteJob(QuoteJob singleJob)
        {//add to the job
            quoteJobs.Add(singleJob);
        }
        public string Description
        {//get and set company description
            get { return description; }
            set { description = value;}
        }

        public void addQuote (SingleQuote quote)
        {//method that adds a quote under the company
            quotes.Add(quote);
        }

        /*temporary method that retrieves entire list of quotes*/
        public List<SingleQuote> getQuotes()
        {
            return quotes;
        }

    }
}
