using abc.Data;
using abc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace abc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeTrackingController : ControllerBase
    {
        private readonly TimeTrackerDbContext _context;

        public TimeTrackingController(TimeTrackerDbContext context)
        {
            _context = context;
        }

        [HttpPost("checkin/{UserId}")]
        public async Task<IActionResult> CheckIn(int UserId)
        {
            var timeEntry = new TimeEntry
            {
                UserId = UserId,
                CheckIn = DateTime.Now
            };

            _context.TimeEntries.Add(timeEntry);
            await _context.SaveChangesAsync();

            return Ok(timeEntry);
        }


        private double CalculateTotalHours(DateTime CheckIn, DateTime CheckOut)
        {
            TimeSpan duration = CheckOut - CheckIn;
            return duration.TotalHours;
        }


        private int GetHour(DateTime datetime)
        {
            return datetime.Hour;
        }


        [HttpPost("checkout/{timeEntryId}")]
        /*public async Task<IActionResult> CheckOut(int timeEntryId)
        {
            var timeEntry = await _context.TimeEntries.FindAsync(timeEntryId);
            if (timeEntry == null)
            {
                return NotFound();
            }
            timeEntry.CheckOut = DateTime.Now;

            double totalHours = CalculateTotalHours(timeEntry.CheckIn, CheckOut);
            timeEntry.TotalHours = totalHours;
            
           
            await _context.SaveChangesAsync();
            return Ok(timeEntry);
        }*/


        /*public async Task<IActionResult> CheckOut(int timeEntryId)
        {
            var timeEntry = await _context.TimeEntries.FindAsync(timeEntryId);
            if (timeEntry == null)
            {
                return NotFound();
            }
            DateTime CheckOut = DateTime.Now;

            double totalHours = CalculateTotalHours(timeEntry.CheckIn, CheckOut);
            timeEntry.CheckOut = CheckOut;
            timeEntry.TotalHours = totalHours;
            
           
            await _context.SaveChangesAsync();
            return Ok(timeEntry);
        }
        */

        public async Task<IActionResult> CheckOut(int timeEntryId)
        {
            var timeEntry = await _context.TimeEntries.FindAsync(timeEntryId);
            if (timeEntry == null)
            {
                return NotFound();
            }

            timeEntry.CheckOut = DateTime.Now;

            double totalHours = CalculateTotalHours(timeEntry.CheckIn, timeEntry.CheckOut);
            timeEntry.TotalHours = totalHours;

            await _context.SaveChangesAsync();
            return Ok(timeEntry);
        }

        private double CalculateTotalHours(DateTime checkIn, DateTime? checkOut)
        {
            if (!checkOut.HasValue)
            {
                throw new ArgumentException("CheckOut time cannot be null");
            }

            TimeSpan duration = checkOut.Value - checkIn;
            return duration.TotalHours;
        }

    }
}
