using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MCQ_Generator;

namespace MCQWebAPI.Controllers
{
    

    [ApiController]
    [Route("api/quiz")]
    public class QuizController : ControllerBase
    {
        private readonly OpenAIService _openAIService;

        public QuizController(OpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        [HttpPost("generate")]
        public async Task<IActionResult> GenerateQuiz(
            [FromBody] QuizRequest request)
        {
            var result =
                await _openAIService.GenerateQuiz(request);

            return Ok(result);
        }
    }
}
