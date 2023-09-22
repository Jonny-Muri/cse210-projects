using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayName();




        // Testing Job class before creating a single Display
        // Helps me to take things one at a time
        // This is here to help understand the concept of this learning exercise
        /*
        job1._jobTitle = "Software Engineer";
        job1._company = "(Microsoft)";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job1.DisplayTitle();
        job1.DisplayCompany();
        job1.DisplayStart();
        job1.DisplayEnd();
        */
    }
}