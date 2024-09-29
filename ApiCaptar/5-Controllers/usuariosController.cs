using apiCaptar.Data.ValueObjects;
using apiCaptar.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiCaptar.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class usuariosController : ControllerBase
{

    private IUserRepository _repository;

    public usuariosController(IUserRepository repository)
    {
        _repository = repository ?? throw new
             ArgumentNullException(nameof(repository));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UsuarioVO>>> FindAll(long id)
    {
        var users = await _repository.FindAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UsuarioVO>> FindById(long id)
    {
        var user = await _repository.FindById(id);
        if (user == null) return NotFound();
        return Ok(user);
    }
}
