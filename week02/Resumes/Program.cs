using System;

class Program
{
    static void Main(string[] args)
    {
        //Add the object job1 for the variable member _jobTitle in Job
        Job job1 = new Job();
        job1._jobTitle = "Sofware Engineer";
        //Prins the result
        Console.WriteLine(job1._jobTitle);
        
        //Add the object company1 for the variable member _company in Job
        Job company1 = new Job();
        company1._company = "Apple";
        //Prins the result
        Console.WriteLine(company1._company);

        //Another way to add an object... The job2 object for the variable member _jobTitle in Job
        Job job2 = new()
        {
            _jobTitle = "IT"
        };
        //Prins the result
        Console.WriteLine(job2._jobTitle);


        //Another way to add an object... The company2 object for the variable member _company in Job
        Job company2 = new()
        {
            _company = "Samsung"
        };
        //Prins the result
        Console.WriteLine(company2._company);

    }
}