using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote
{
    class Company
    {
        private string name;
        private string description;
        private List<SingleQuote> quotes;

        public Company()
        {
            //initialize quote list
            quotes = new List<SingleQuote>();
        }
        public string Name
        {//get and set company name
            get { return name; }
            set { name = value; }
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
