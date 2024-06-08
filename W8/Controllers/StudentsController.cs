using W8.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace W8.Controllers;



[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{

    private readonly W7Context _dbContext;
    public StudentsController(W7Context dbContext)
    {
        _dbContext = dbContext;
    }
        

    [HttpGet]
    public IActionResult GetStudents()
    {
        // var dbContext = new W7Context();
        // var result = dbContext.Countries
        //     .Include(c => c.Region)
        //     .Where(c => c.CountryName.Contains("A"))
        //     .OrderBy(c => c.CountryName)
        //     .Select(c => new
        //     {
        //         Nazwa = c.CountryName
        //     });
        //include mowi "zrób mi joina i pobierz z innej tabeli"

        // var result = _dbContext.Employees.ToList();
        //
        // var result3 = from e in _dbContext.Employees
        //     where e.DepartmentId == 1
        //     select e;
        
        
        return Ok();
    }

    // [HttpPost]
    // public async Task<IActionResult> Create()
    // {
    //     // Insert - job
    //     var newJob = new Job
    //     {
    //         JobTitle = "Test",
    //         MinSalary = 1000,
    //         MaxSalary = 2000
    //     };
    //     
    //     var newJob2 = new Job
    //     {
    //         JobTitle = "Test2",
    //         MinSalary = 1000,
    //         MaxSalary = 2000
    //     };
    //
    //     await _dbContext.Jobs.AddAsync(newJob);
    //     await _dbContext.Jobs.AddAsync(newJob2);
    //
    //     await _dbContext.SaveChangesAsync(); //Insert zostaje dodany  
    //
    //     return Ok(newJob);
    // }
    //
    // // [HttpPut]
    // // public async Task<IActionResult> Update()
    // // {
    // //     //1.
    // //     var jobToUpdate = await _dbContext.Jobs.Where(j => j.JobId == 1001).FirstAsync(); //first async czyli biore pierwszy element a single np musi dostac dokladnie jeden
    // //
    // //     jobToUpdate.JobTitle = "Ala ma kota";
    // //     jobToUpdate.MaxSalary = 20000;
    // //     
    // //     //2.
    // //     await _dbContext.SaveChangesAsync(); //update jobTitle
    // //     
    // //     return Ok(jobToUpdate);
    // // }
    //
    // [HttpPut]
    // public async Task<IActionResult> Update()
    // {
    //     //jak tworzymy obiekt to update trzeba zrobic _dbContext.Attach(jobToUpdate); dodac entry i powiedziec entity co sie zmienilo
    //     var jobToUpdate = new Job
    //     {
    //         JobId = 1001,
    //         JobTitle = "wwa"
    //     };
    //
    //     _dbContext.Attach(jobToUpdate);
    //
    //     var entry = _dbContext.Entry(jobToUpdate);
    //     entry.Property(p => p.JobTitle).IsModified = true;
    //     
    //     await _dbContext.SaveChangesAsync(); 
    //     
    //     return Ok(jobToUpdate);
    // }
}