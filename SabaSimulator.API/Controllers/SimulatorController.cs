

using Microsoft.AspNetCore.Mvc;

namespace SabaSimulator.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimulatorController : ControllerBase
    {
        [HttpGet(Name = "CheckIsOnline")]
        public async Task<IActionResult> CheckIsOnline()
        {
            var result = new
            {
                error_code = 0,
                message = "",
                Data = new[]
                {
                    new
                    {
                        vendor_member_id = "vendor_member_id",
                        is_online = false
                    }
                }
            };

            return Ok(result);
        }
    }
}
