using AprendendoRabbitMq.Models;
using AprendendoRabbitMq.Models.Requests;
using AprendendoRabbitMq.Services;
using Microsoft.AspNetCore.Mvc;

namespace AprendendoRabbitMq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly IServiceTarefa _serviceTarefa;
        public TarefaController(IServiceTarefa serviceToDo)
        {
            _serviceTarefa = serviceToDo;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]TarefaRequest tr)
        {
            Tarefa tarefa = new Tarefa(tr.Nome);

            var response = await _serviceTarefa.PostAsync(tarefa);
            if (response == null) {

                return BadRequest(response);
            }
            Send.Main("Exchange1", "c", response);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<Tarefa> ressultado = await _serviceTarefa.GetAllAsync();
            return Ok(ressultado);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            Tarefa ressultado = await _serviceTarefa.GetByIdAsync(id);
            if (ressultado == null)
            {
                return NotFound();
            }

            return Ok(ressultado);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromRoute]Tarefa tarefa)
        {
            Tarefa ressultado = await _serviceTarefa.PutAsync(tarefa);
            if (ressultado == null)
            {
                return NotFound();
            }

            return Ok(ressultado);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            _serviceTarefa.DeleteAsync(id);
            
            return Ok();
        }
    }
}
