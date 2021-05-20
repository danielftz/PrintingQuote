using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote
{
    class Company
    {
        public double companyID { get; private set; }
        public string name;
        
        public List<Job> jobs { get; private set; }

        public Company()
        {
            //generate company ID
            Random rand = new Random();
            this.companyID = Math.Floor(rand.NextDouble() * 1000000);
            //initialize a list of jobs
            jobs = new List<Job>();
        }

        public void addQuoteJob(Job singleJob)
        {//add to the job
            jobs.Add(singleJob);
        }


    }
}
