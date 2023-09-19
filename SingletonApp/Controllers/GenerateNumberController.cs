using Microsoft.AspNetCore.Mvc;
using SingletonApp.Interfaces;
using System.Security.Cryptography;

namespace SingletonApp.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GenerateNumberController : ControllerBase
    {

        private readonly IRandomNumberGenerator _randomNumberGenerator;
        private readonly IScopedRandomNumberGenerator _scopedRandomNumberGenerator;
        private readonly ITransientRandomNumberGenerator _transientRandomNumberGenerator;

        public GenerateNumberController(
            IRandomNumberGenerator RandomNumberGenerator, 
            IScopedRandomNumberGenerator scopedRandomNumberGenerator, 
            ITransientRandomNumberGenerator transientRandomNumberGenerator)
        {
            _randomNumberGenerator = RandomNumberGenerator;
            _scopedRandomNumberGenerator = scopedRandomNumberGenerator;
            _transientRandomNumberGenerator = transientRandomNumberGenerator;
        }  //constructor

        [HttpGet("getSingleton")]
        public String GetSingleton()
        {
            return _randomNumberGenerator.SingletonRandomNumber.ToString();
        }

        [HttpGet("getScoped")]
        public String GetScoped()
        {
            return _scopedRandomNumberGenerator.ScopedRandomNumber.ToString();
        }

        [HttpGet("getTransient")]
        public String GetTransient()
        {
            return _transientRandomNumberGenerator.TransientRandomNumber.ToString();
        }
    }
}