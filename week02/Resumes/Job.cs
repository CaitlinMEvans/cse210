using System;
public class Job
{
    // Member variables to store the job’s title, company, and the years worked
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Display the job details in a clean, professional format.
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
