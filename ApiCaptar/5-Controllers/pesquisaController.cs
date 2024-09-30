﻿using apiCaptar.Data.ValueObjects;
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

    

}
