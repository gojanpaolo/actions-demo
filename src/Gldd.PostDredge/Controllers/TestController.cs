using Microsoft.AspNetCore.Mvc;

namespace Gldd.PostDredge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        public object Get() => "test2";
    }
}
