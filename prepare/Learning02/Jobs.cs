using System;
using System.Collections.Generic;

public class Job
{
    //defining attributes
    private string _company;
    private string _jobTitle;
    private string _startYear;
    private string _endYear;

    // Constructors
    public Job (string jobTitle, string company, string startYear, string endYear)
    {
        this._jobTitle = jobTitle;
        this._company = company;
        this._startYear = startYear;
        this._endYear = endYear;
    }
    
    //defining methods
    public void DisplayJob()
    {
     Console.WriteLine($"{_jobTitle} ({_company}): {_startYear} - {_endYear}");   
    }
}
