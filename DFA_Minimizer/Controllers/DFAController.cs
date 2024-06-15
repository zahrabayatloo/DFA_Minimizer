using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DFA_Minimizer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DFAController : Controller
    {
        [HttpPost("minimize")]
        public IActionResult MinimizeDFA([FromBody] DFAInput input)
        {
            var minimizedDFA = Minimize(input);
            return Ok(minimizedDFA);
        }

        private DFAOutput Minimize(DFAInput input)
        {
            // منطق کاهش DFA
            // برای سادگی، DFAInput و DFAOutput به صورت کلاس‌های ساده تعریف شده‌اند
            // شما باید منطق واقعی کاهش را پیاده‌سازی کنید
            return new DFAOutput();
        }
    }

    public class DFAInput
    {
        public List<string> States { get; set; }
        public List<string> Alphabet { get; set; }
        public Dictionary<string, Dictionary<string, string>> TransitionFunction { get; set; }
        public string StartState { get; set; }
        public List<string> AcceptStates { get; set; }
    }

    public class DFAOutput
    {
        public List<string> States { get; set; }
        public Dictionary<string, Dictionary<string, string>> TransitionFunction { get; set; }
        public string StartState { get; set; }
        public List<string> AcceptStates { get; set; }
    }
}
