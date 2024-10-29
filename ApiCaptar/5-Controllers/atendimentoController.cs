using apiCaptar._1_Domain;
using apiCaptar._6_Repository.Interface;
using apiCaptar.Configuration;
using apiCaptar.Data.ValueObjects;
using apiCaptar.Repository.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace apiCaptar.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class atendimentoController : ControllerBase
{
    private readonly MySQLContext _context;
    private readonly IMapper _mapper;
    private IAtendimentoRepository _repository;

    public atendimentoController(IAtendimentoRepository repository, MySQLContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _repository = (IAtendimentoRepository?)(repository ?? throw new
             ArgumentNullException(nameof(repository)));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<atendimentoVO>>> FindAll()
    {
        var pes = await _repository.FindAll();
        return Ok(pes);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<atendimentoVO>> FindById(long id)
    {
        var atend = await _repository.FindById(id);
        if (atend == null)
        {
            return NotFound();
        }
        return Ok(atend);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] atendimentoVO atendimentoVOO)
    {

        //var pesquisa = _mapper.Map<Pesquisa>(pesquisaVOo);
        //// Verifique se o UsuarioId está correto e se o usuário existe
        //// Por exemplo:
        //var usuario = _context.Usuarios.Find(pesquisa.Usuario);
        //if (usuario == null)
        //{
        //    throw new Exception("Usuário não encontrado.");
        //}

        //_context.Pesquisa.Add(pesquisa);
        //_context.SaveChanges();
        //return CreatedAtAction(nameof(FindById), new { id = pesquisa.Id }, pesquisa);

        var atendimentoo = await _repository.Create(atendimentoVOO);
        return CreatedAtAction(nameof(FindById), new { id = atendimentoo.id }, atendimentoo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] atendimentoVO atendimentoVO)
    {
        atendimentoVO.id = id;
        var atendimento = await _repository.Update(atendimentoVO);
        return Ok(atendimento);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _repository.Delete(id);
        if (result == null) return NotFound();
        return NoContent();
    }
}
