using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGrade.Data.Repositories;
using SGrade.Models;
using SGrade.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGrade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherRepo _repo;
        private readonly IMapper _mapper;

        public TeachersController(ITeacherRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: api/Teachers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetMajors()
        {
            var res = await _repo.GetAll();
            var resDTOS = _mapper.Map<IEnumerable<IGradable>, IEnumerable<LightGradableDTO>>(res);
            return Ok(resDTOS.ToList());
        }

        // GET: api/Teachers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetTeachers(int id)
        {
            var entity = await _repo.GetSingle(id);

            if (entity == null)
            {
                return NotFound();
            }

            return _mapper.Map<Teacher, TeacherDTO>(entity);

        }


        // POST: api/Teacher
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Teacher>> PostTeacher(Teacher teacher)
        {
            _repo.Add(teacher);
            await _repo.Commit();

            return CreatedAtAction("PostTeacher", new { id = teacher.Id }, teacher);
        }

        // PUT: api/Teacher/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacher(int id, Teacher teacher)
        {
            if (id != teacher.Id)
            {
                return BadRequest();
            }

            _repo.Update(teacher);

            try
            {
                await _repo.Commit();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntityExists(id))
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

        // DELETE: api/Teacher/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            var entity = await _repo.GetSingle(id);
            if (entity == null)
            {
                return NotFound();
            }

            _repo.Delete(entity);
            await _repo.Commit();

            return NoContent();
        }

        private bool EntityExists(int id)
        {
            return _repo.GetSingle(id) != null;
        }
    }
}
