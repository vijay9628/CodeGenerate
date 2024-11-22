using CodeGenerate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static CodeGenerate.Models.ApplicationDbContext;

namespace CodeGenerate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context) 
        {
            _context = context;
        }
        [HttpPost("Create")]
        public async Task<ActionResult> CreateCode(int numberOfCodes, int companyId, int productId)
        {
            try
            {
                // Execute the stored procedure with parameters
                var parameter1 = new SqlParameter("@NumberOfCodes", numberOfCodes);
                var parameter2 = new SqlParameter("@CompanyId", companyId);
                var parameter3 = new SqlParameter("@ProductId", productId);

                await _context.Database.ExecuteSqlRawAsync("EXEC GenerateSequentialCodes @NumberOfCodes, @CompanyId, @ProductId",
                    parameter1, parameter2, parameter3);

                return Ok(new { message = $"{numberOfCodes} sequential codes generated successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error generating codes.", details = ex.Message });
            }

        }
       

       
       
    }
}
