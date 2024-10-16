using apiCaptar.Data.ValueObjects;
using apiCaptar.Repository.Implementation;
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
    public async Task<ActionResult<UsuarioVO>> FindById([FromQuery] int id)
    {
        var user = await _repository.FindById(id);
        if (user == null) return NotFound();
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] UsuarioVO userVO)
    {
        var user = await _repository.Create(userVO);
        return CreatedAtAction(nameof(FindById), new { id = user.id }, user);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UsuarioVO userVO)
    {
        userVO.id = id; // Certifique-se de que o ID está correto
        var user = await _repository.Update(userVO);
        return Ok(user);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(long id)
    {
        var result = await _repository.Delete(id);
        if (!result) return NotFound();
        return NoContent();
    }

    [HttpGet("authenticate")]
    public async Task<ActionResult<UsuarioVO>> Authenticate([FromQuery] string email, [FromQuery] string senha)
    {
        if ( string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
        {
            return BadRequest("Email and password must be provided.");
        }

        var user =  await _repository.FindByEmailAndPassword(email, senha);
        if (user == null) return Unauthorized();

        return Ok(user);
    }

}
public class AuthRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
}
