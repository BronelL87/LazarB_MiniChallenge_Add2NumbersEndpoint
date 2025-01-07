using Microsoft.AspNetCore.Mvc;

namespace LazarB_MiniChallenge_Add2NumbersEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddNumbersController : ControllerBase
    {
        public List<string> AddNumbers = new();

        [HttpPost]
        [Route("UserNumbers/{userNum1}/{userNum2}")]

        public List<string> AddingNumbers(int userNum1, int userNum2){
            AddNumbers.Add($"{userNum1} + {userNum2} = {userNum1 + userNum2}");
            return AddNumbers;
        }
    }
}