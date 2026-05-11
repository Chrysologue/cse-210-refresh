using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }
    public Job(string company, string jobTitle, int startYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
    }
    public string Display()
    {
        if(_endYear != 0)
        {
            return $"{_jobTitle} ({_company}) {_startYear}-{_endYear}";
        }
        DateTime today = DateTime.Now;
    
        return $"{_jobTitle} ({_company}) {_startYear}-{today.Year}";
    }
}