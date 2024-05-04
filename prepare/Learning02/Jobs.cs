using System;
using System.Collections.Generic;

public class Job
{
    //defining attributes
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;


    
    //defining methods
    public void DisplayJob()
    {
     Console.WriteLine($"{_jobTitle} ({_company}): {_startYear} - {_endYear}");   
    }
}
