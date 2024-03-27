using abc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace abc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotalTimeTracker : ControllerBase
    {
        public object TimeCalculator { get; private set; }

        /* public static List<Models.CheckIn> listOfCategories = new List<CheckIn>
{


};

[HttpGet]
public IEnumerable<CheckIn> Get()
{
return listOfCategories;
}

[HttpPost]
public void Post([FromBody] CheckIn checkIn)
{
listOfCategories.Add(checkIn);
}*/

        /*[HttpGet]
        public IActionResult GetTotalTime(DateTime checckIn, DateTime checkOut)
        {
            TimeSpan totalTime = TimeCalculator.CalculateTotalTime(checckIn, checkOut);
            return Ok(totalTime);
        }
        */
    }
}






