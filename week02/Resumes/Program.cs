using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new("Software engineer", "Google", 2015, 2024);
        Job job2 = new("Full stack developer", "Amazon", 2024);
        Resume resume1 = new("Xyste Chrysologue Rabearson");
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        Job job3 = new("Customer Service", "Amazon", 2023-2025);
        Job job4 = new("Customer Specialist", "Setex Madagascar", 2025);
        Resume resume2 = new("Ernest Baggio");
        resume2._jobs.Add(job3);
        resume2._jobs.Add(job4);
        List<Resume> resumes = [resume1, resume2];
        foreach(var res in resumes)
        {
            res.Display();
        }
    }
}