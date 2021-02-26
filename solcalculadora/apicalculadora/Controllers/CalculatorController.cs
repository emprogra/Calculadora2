namespace apicalculadora.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
       [HttpPost]
        [Route("Add")]
        public int Add ([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }
        [HttpPost]
        [Route("Add2")]
        public int Add2 ([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa * numb;
        }
        [HttpPost]
        [Route("Add3")]
        public int Add3 ([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa - numb;
        }
        [HttpPost]
        [Route("Add4")]
        public int Add4 ([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa / numb;
        }

    }
}
