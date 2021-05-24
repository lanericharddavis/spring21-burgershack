using burgershack.Services;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SidesController : ControllerBase
    {
        private readonly BurgersService _bs;

        public SidesController(BurgersService bs)
        {
            _bs = bs;
        }

    }
}
