using System;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        // Job Details
        var job1 = new Job();
        job1.company = "Apple";
        job1.jobTitle = "Developer";
        job1.startYear = 1967;
        job1.endYear = 2055;

        var job2 = new Job();
        job2.company = "MySpace";
        job2.jobTitle = "Lead Marketer";
        job2.startYear = 1997;
        job2.endYear = 2001;

        // Add jobs to list
        var myResume = new Resume();
        myResume.member = "John Doe";
        myResume.jobs.Add(job1);
        myResume.jobs.Add(job2);

        // Display my resume
        myResume.DisplayResume();

    }
}