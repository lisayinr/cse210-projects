using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2016;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Assistant";
        job2._company = "Microsoft";
        job2._startYear = 2005;
        job2._endYear = 2020;

        Resume theResume = new Resume();
        theResume._name = "Lillis Green";
        theResume._jobs.Add(job1);
        theResume._jobs.Add(job2);
        theResume.DisplayResume();
    }
}