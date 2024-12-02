using Exame2tds.API.MachineLearning.Models;
using Exame2tds.API.MachineLearning.Services;
using Microsoft.AspNetCore.Mvc;

namespace Exame2tds.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MLController : ControllerBase
    {
        private readonly MachineLearningService _mlService;

        public MLController(MachineLearningService mlService)
        {
            _mlService = mlService;

            // Treina o modelo na inicialização
            _mlService.TrainModel();
        }

        [HttpPost("predict")]
        public IActionResult Predict([FromBody] InputData input)
        {
            var prediction = _mlService.Predict(input);
            return Ok(new { PredictedValue = prediction });
        }
    }
}
