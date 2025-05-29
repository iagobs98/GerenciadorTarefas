using GerenciadorTarefas.Application.DTO;
using GerenciadorTarefas.Application.Exceptions;
using GerenciadorTarefas.Application.Services.Interfaces;
using GerenciadorTarefas.Domain.Enum;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorTarefas.API.Controllers
{
    [Route("api/tarefas")]
    [ApiController]
    public class TarefaController : ControllerBase
    {

        private readonly ITarefaCadastroService _tarefaCadastroService;
        private readonly ITarefaConsultaService _tarefaConsultaService; 
        private readonly ITarefaEditarService _tarefaEditarService;
        private readonly ITarefaDeletarService _tarefaDeletarService;
        public TarefaController(
            ITarefaCadastroService tarefaCadastroService,
            ITarefaConsultaService tarefaConsultaService,
            ITarefaEditarService tarefaEditarService,
            ITarefaDeletarService tarefaDeletarService
        )
        {
            _tarefaCadastroService = tarefaCadastroService;
            _tarefaConsultaService = tarefaConsultaService;
            _tarefaEditarService = tarefaEditarService;
            _tarefaDeletarService = tarefaDeletarService;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CadastrarAsync([FromBody] CadastrarTarefaDTO cadastroTarefaDTO)
        {
            try
            {
                await _tarefaCadastroService.CadastrarAsync(cadastroTarefaDTO);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<TarefaConsultaDTO> Listar(EStatusTarefa? eStatusTarefa = null)
        {
            return _tarefaConsultaService.Listar(eStatusTarefa);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Obter(int id)
        {

            try
            {
                var tarefa = await _tarefaConsultaService.ObterAsync(id);
                return Ok(tarefa);
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(new { message = e.Message });
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> EditarAsync(int id, [FromBody] TarefaEditarDTO tarefaEditarDTO)
        {
            try
            {
                await _tarefaEditarService.EditarAsync(id, tarefaEditarDTO);
                return NoContent();
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(new { message = e.Message });
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeletarAsync(int id)
        {
            try
            {
                await _tarefaDeletarService.DeletarAsync(id);
                return NoContent();
            }catch(EntityNotFoundException e)
            {
                return NotFound(new { message = e.Message });
            }
            catch(Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }
    }
}
