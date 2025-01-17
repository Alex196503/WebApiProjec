﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiProjec.Data;
using WebApiProjec.Models;

namespace WebApiProjec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtsController : ControllerBase
    {
        private readonly ProiectMediiBunContext _context;

        public CourtsController(ProiectMediiBunContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Court>>> GetCourt()
        {
            return await _context.Court.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Court>> GetCourt(int id)
        {
            var court = await _context.Court.FindAsync(id);

            if (court == null)
            {
                return NotFound();
            }

            return court;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourt(int id, Court court)
        {
            if (id != court.ID)
            {
                return BadRequest();
            }

            _context.Entry(court).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourtExists(id))
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


        [HttpPost]
        public async Task<ActionResult<Court>> PostCourt(Court court)
        {
            _context.Court.Add(court);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourt", new { id = court.ID }, court);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourt(int id)
        {
            var court = await _context.Court.FindAsync(id);
            if (court == null)
            {
                return NotFound();
            }

            _context.Court.Remove(court);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourtExists(int id)
        {
            return _context.Court.Any(e => e.ID == id);
        }
    }
}
