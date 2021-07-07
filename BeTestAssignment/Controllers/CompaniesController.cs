using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BeTestAssignment.Data;
using BeTestAssignment.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace BeTestAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CompaniesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CompaniesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> GetCompanies()
        {
            return await _context.Companies.AsNoTracking().Select(c => new CompanyDto(c)).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyDto>> GetCompany(Guid id)
        {
            var company = await _context.Companies.AsNoTracking().SingleOrDefaultAsync(c => c.Id == id);

            if (company == null)
            {
                return NotFound();
            }

            return new CompanyDto(company);
        }
    }
}