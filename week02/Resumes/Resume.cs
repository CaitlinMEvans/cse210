using System;
using System.Collections.Generic;

// Pull together a name and a list of jobs.
public class Resume
{
    // The name of the person whose resume this is.
    public string _name;

    // A list to store all the jobs that will be included on the resume.
    public List<Job> _jobs = new List<Job>();

    // Display the resume details, including the name and all the jobs.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through each job and display it using the Job class’s Display method.
        foreach (Job job in _jobs)
        {
            job.Display(); // Call the Job class's method to display the details for this job.
        }
    }
}
