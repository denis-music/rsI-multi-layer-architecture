using CIPS.Core;
using CIPS.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIPS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradjaninController : ControllerBase
    {
        IGradjaninServices gradjaninServices;
        public GradjaninController(IGradjaninServices gradjaninServices)
        {
            this.gradjaninServices = gradjaninServices;
        }
        
        [HttpGet]   
        public IActionResult Get()
        {
            return Ok(gradjaninServices.GetAll());
        }

        [HttpPost]
        public IActionResult Post(Gradjanin gradjanin)
        {
            return Ok(gradjaninServices.Add(gradjanin));
        }
    }
}
