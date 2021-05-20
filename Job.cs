using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote
{
    class Job
    {
        public double parentCompany { get; private set; }
        public double estiamteID { get; private set; }
        public string name;
        public string description;
        public string memo;
        public DateTime jobDate;
        public List<SingleQuote> quotes { get; private set; }

        public Job(double companyID)
        {
            //assign company id of this job
            parentCompany = companyID;
            //randomly generate estimate ID
            Random rand = new Random();
            this.estiamteID = Math.Floor(rand.NextDouble() * 1000000);
            //initialize list of single quotes
            quotes = new List<SingleQuote>();
        }

        public void addSingleQuote(SingleQuote quote)
        {
            quotes.Add(quote);
        }
    }
}
