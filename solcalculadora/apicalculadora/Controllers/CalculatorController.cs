namespace apicalculadora.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
       [HttpPost]
        [Route("suma")]
        public int suma ([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }
        [HttpPost]
        [Route("multiplicacion")]
        public int multiplicacion ([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa * numb;
        }
        [HttpPost]
        [Route("resta")]
        public int resta ([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa - numb;
        }
        [HttpPost]
        [Route("division")]
        public int division ([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa / numb;
        }

    }
}
