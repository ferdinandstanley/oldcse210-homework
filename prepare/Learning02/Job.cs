using System;

public class Job
{
    public string _jobTitle = "Web Developer";
    public string _company = "Apple";
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}