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
    public class MajorsController : ControllerBase
    {
        private readonly IMajorRepo _repo;
        private readonly IMapper _mapper;

        public MajorsController(IMajorRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        // GET: api/Majors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Major>>> GetMajors()
        {
            var res = await _repo.GetAll();
            var resDTOS = _mapper.Map<IEnumerable<IGradable>, IEnumerable<LightGradableDTO>>(res);
            return Ok(resDTOS.ToList());
        }

        // GET: api/Majors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MajorDTO>> GetMajor(int id)
        {
            var major = await _repo.GetPresentingMajor(id);

            if (major == null)
            {
                return NotFound();
            }

            return _mapper.Map<Major, MajorDTO>(major);
        }


        // POST: api/Majors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Major>> PostMajor(Major major)
        {
            _repo.Add(major);
            await _repo.Commit();

            return CreatedAtAction("PostMajor", new { id = major.Id }, major);
        }

        // PUT: api/Majors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMajor(int id, Major major)
        {
            if (id != major.Id)
            {
                return BadRequest();
            }

            _repo.Update(major);

            try
            {
                await _repo.Commit();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MajorExists(id))
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

        // DELETE: api/Majors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMajor(int id)
        {
            var major = await _repo.GetSingle(id);
            if (major == null)
            {
                return NotFound();
            }

            _repo.Delete(major);
            await _repo.Commit();

            return NoContent();
        }

        private bool MajorExists(int id)
        {
            return _repo.GetSingle(id) != null;
        }
    }

}

