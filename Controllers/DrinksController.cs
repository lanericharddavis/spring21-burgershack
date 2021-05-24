using burgershack.Services;
using Microsoft.AspNetCore.Mvc;

namespace burgershack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrinksController : ControllerBase
    {
        private readonly BurgersService _bs;

        public DrinksController(BurgersService bs)
        {
            _bs = bs;
        }

    }
}
