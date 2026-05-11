using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    public List<Job> _jobs = [];

    public Resume(string name)
    {
        _name = name;
    }

    public void Display()
    {
        Console.WriteLine($"--{_name}--");
        Console.WriteLine("List of jobs");
        foreach(var job in _jobs)
        {
            Console.WriteLine(job.Display());
        }
    }
}