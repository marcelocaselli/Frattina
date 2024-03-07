using Microsoft.AspNetCore.Mvc;
using PasswordValidatorUI.Models;
using WebApiAuth.Models;
using PasswordValidatorBL_DLL;

namespace PasswordValidatorUI.Controllers
{
    [ApiController]
    public class PasswordValidatorLayer : Controller
    {
        [HttpPost("/LayerValidation")]
        public IActionResult Post([FromBody] CreatePasswordModel model)
        {
            try
            {
                PasswordValidatorBL validator = new PasswordValidatorBL();

                List<string> errorsValidation = validator.ValidatePasswordRegularExpression(model.Password);

                if (errorsValidation.Count() == 0)
                    return Ok("Senha validada com sucesso.");
                else
                    return BadRequest(errorsValidation);
            }
            catch (Exception ex)
            {
                //Não implementei, mas erro deve ser logado
                //para que possamos verificar o que ocorreu
                Console.Write(ex.Message.ToString() + "-" + ex.StackTrace.ToString());

                //Retorno erro 500 - Internal Server Error.
                return StatusCode(500, new ErrorMessage("ErroProcessamento", "Erro no processamento da requisição. Caso persista entre em contato com equipe tecnica."));
            }
        }
    }
}
