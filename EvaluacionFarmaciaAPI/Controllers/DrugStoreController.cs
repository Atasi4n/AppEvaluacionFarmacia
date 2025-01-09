using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EvaluacionFarmaciaAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EvaluacionFarmaciaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrugStoresController : ControllerBase
    {
        private readonly PharmacyEvaluationDbContext _context;

        public DrugStoresController(PharmacyEvaluationDbContext context)
        {
            _context = context;
        }

        // GET: api/DrugStores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DrugStore>>> GetDrugStores()
        {
            return await _context.DrugStores.ToListAsync();
        }
    }
}
