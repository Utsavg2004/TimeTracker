using Microsoft.AspNetCore.Mvc;

namespace abc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckInController : Controller
    {
        
            /*private readonly APIDbContext _context;

            public CheckInController(APIDbContext context)
            {
                _context = context;
            }

            // GET: api/Student
            [HttpGet]
            public async Task<ActionResult<IEnumerable<CheckIn>>> GetTime()
            {
                return await _context.Students.ToListAsync();
            }

            /*GET: api/Student/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Student>> GetStudent(int id)
            {
                var student = await _context.Students.FindAsync(id);

                if (student == null)
                {
                    return NotFound();
                }

                return student;
            }

            // PUT: api/Student/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutStudent(int id, Student student)
            {
                if (id != student.StudentID)
                {
                    return BadRequest();
                }

                _context.Entry(student).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }

            // POST: api/Student
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            public async Task<ActionResult<Student>> PostStudent(Student student)
            {
                _context.Students.Add(student);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetStudent", new { id = student.StudentID }, student);
            }

            // DELETE: api/Student/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteStudent(int id)
            {
                var student = await _context.Students.FindAsync(id);
                if (student == null)
                {
                    return NotFound();
                }

                _context.Students.Remove(student);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool StudentExists(int id)
            {
                return _context.Students.Any(e => e.StudentID == id);
            }*/
        }
    }
