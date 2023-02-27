using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiz_Game.Models;

namespace Quiz_Game.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : ControllerBase
    {
        private readonly APIDbContext _context;

        public AnswersController(APIDbContext context)
        {
            _context = context;
        }

        // GET: api/Answers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuizAnswer>>> GetquizAnswers()
        {
            return await _context.quizAnswers.ToListAsync();
        }

        // GET: api/Answers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuizAnswer>> GetQuizAnswer(int id)
        {
            var quizAnswer = await _context.quizAnswers.FindAsync(id);

            if (quizAnswer == null)
            {
                return NotFound();
            }

            return quizAnswer;
        }

        // PUT: api/Answers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuizAnswer(int id, QuizAnswer quizAnswer)
        {
            if (id != quizAnswer.Id)
            {
                return BadRequest();
            }

            _context.Entry(quizAnswer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuizAnswerExists(id))
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

        // POST: api/Answers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<QuizAnswer>> PostQuizAnswer(QuizAnswer quizAnswer)
        {
            _context.quizAnswers.Add(quizAnswer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuizAnswer", new { id = quizAnswer.Id }, quizAnswer);
        }

        // DELETE: api/Answers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuizAnswer(int id)
        {
            var quizAnswer = await _context.quizAnswers.FindAsync(id);
            if (quizAnswer == null)
            {
                return NotFound();
            }

            _context.quizAnswers.Remove(quizAnswer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool QuizAnswerExists(int id)
        {
            return _context.quizAnswers.Any(e => e.Id == id);
        }
    }
}
