using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Web Designer";
        job1._company = "Built Marketing";
        job1._startYear = 2025;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Office Manager";
        job2._company = "High Country Exteriors";
        job2._startYear = 2024;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Kaylee Godfrey";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}