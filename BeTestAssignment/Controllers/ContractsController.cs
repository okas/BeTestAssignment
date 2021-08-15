using BeTestAssignment.Data;
using BeTestAssignment.Dtos;
using BeTestAssignment.MapperExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeTestAssignment.Controllers
{
    [Route("api/companies/{companyId}/[controller]")]
    [ApiController]
    [Authorize]
    public class ContractsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContractsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContractDto>>> GetContracts(Guid companyId)
        {
            return await _context.Contracts.AsNoTracking()
                .Where(model => model.CompanyId == companyId)
                .Select(model => model.ToDTO())
                .ToListAsync();
        }

        /// <summary>
        /// Get Contract sub-resource by Company and Contract Ids.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<ContractDto>> GetContract(Guid companyId, Guid id)
        {
            var model = await _context.Contracts.AsNoTracking()
                .Where(model => model.CompanyId == companyId)
                .SingleOrDefaultAsync(model => model.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return model.ToDTO();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutContract(Guid companyId, Guid id, ContractDto dto)
        {
            if (companyId != dto.CompanyId || id != dto.Id)
            {
                return BadRequest();
            }

            _context.Entry(dto.ToModel()).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContractExists(id))
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

        /// <summary>
        /// Creates a Contract
        /// </summary>
        /// <returns>A newly created Contract</returns>
        /// <response code="201">Returns the newly created item.</response>
        /// <response code="400">Returns error, if Contract is duplicate, meaning that combination `companyID` and `userId` already exists.</response> 
        [HttpPost]
        public async Task<ActionResult<ContractDto>> PostContract(ContractNewDto newDto)
        {
            var model = _context.Contracts.Add(newDto.ToModel()).Entity;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                return HandleDbUpdateException(ex);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Some unexpected error occured. Sorry");
            }
            return CreatedAtAction("GetContract", new { model.CompanyId, model.Id }, model.ToDTO());
        }

        private bool ContractExists(Guid id)
        {
            return _context.Contracts.Any(model => model.Id == id);
        }

        private ActionResult<ContractDto> HandleDbUpdateException(DbUpdateException ex)
        {
            var errorMessage = ex.InnerException.Message.Contains("duplicat", StringComparison.InvariantCultureIgnoreCase)
                ? "Attempted to insert duplicate contract: only one Contract can exists between Company and User."
                : ex.InnerException.Message;
            ModelState.AddModelError("", errorMessage);
            return BadRequest(ModelState);
        }
    }
}
