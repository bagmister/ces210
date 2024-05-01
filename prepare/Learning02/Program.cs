using System;

class Program
{
    static void Main(string[] args)
    {
        var job1 = new Job();
        var job2 = new Job();
        var resume = new Resume();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2021;
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._name = "Nate Bedopadope";

    resume.DisplayResume();

    }
}

