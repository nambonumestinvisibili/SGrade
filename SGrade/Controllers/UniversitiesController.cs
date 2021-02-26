using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SGrade.Data;
using SGrade.Data.Repositories;
using SGrade.Models;
using SGrade.Models.DTOs;

namespace SGrade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversitiesController : ControllerBase
    {
        private readonly IUniversityRepo _repo;
        private readonly IMapper _mapper;

        public UniversitiesController(IUniversityRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }

        // GET: api/Universities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<University>>> GetUniversities()
        {
            var res = await _repo.GetAll();
            var resDTOS = _mapper.Map<IEnumerable<IGradable>, IEnumerable<LightGradableDTO>>(res);
            return Ok(resDTOS.ToList());
        }

        // GET: api/Universities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<University>> GetUniversity(int id)
        {
            var university = await _repo.GetSingle(id);

            if (university == null)
            {
                return NotFound();
            }

            return university;
        }

        // PUT: api/Universities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUniversity(int id, University university)
        {
            if (id != university.Id)
            {
                return BadRequest();
            }

            _repo.Update(university);

            try
            {
                await _repo.Commit();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniversityExists(id))
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

        // POST: api/Universities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<University>> PostUniversity(University university)
        {
            _repo.Add(university);
            await _repo.Commit();

            return CreatedAtAction("GetUniversity", new { id = university.Id }, university);
        }

        // DELETE: api/Universities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUniversity(int id)
        {
            var university = await _repo.GetSingle(id);
            if (university == null)
            {
                return NotFound();
            }

            _repo.Delete(university);
            await _repo.Commit();

            return NoContent();
        }

        private bool UniversityExists(int id)
        {
            return _repo.GetSingle(id) != null;
        }
    }
}
