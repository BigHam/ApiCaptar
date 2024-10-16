using apiCaptar.Data.ValueObjects;
using apiCaptar.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiCaptar.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class pesquisaController : ControllerBase
{

    private IpesquisaRepository _repository;

    public pesquisaController(IpesquisaRepository repository)
    {
        _repository = repository ?? throw new
             ArgumentNullException(nameof(repository));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<pesquisaVO>>> FindAll(long id)
    {
        var pes = await _repository.FindAll();
        return Ok(pes);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<pesquisaVO>> FindById(long id)
    {
        var pes = await _repository.FindById(id);
        if (pes == null) return NotFound();
        return Ok(pes);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] pesquisaVO pesquisaVOo)
    {
        var pesquisa = await _repository.Create(pesquisaVOo);
        return CreatedAtAction(nameof(FindById), new { id = pesquisa.IdPesquisa }, pesquisa);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] pesquisaVO pesquisaVO)
    {
        pesquisaVO.IdUsuario = id; 
        var pesquisa = await _repository.Update(pesquisaVO);
        return Ok(pesquisa);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _repository.Delete(id);
        if (!result) return NotFound();
        return NoContent();
    }

}
