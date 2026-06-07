using kolos.dto;
using kolos.Entities;
using kolos.exception;
using kolos.service;
using Microsoft.AspNetCore.Mvc;

namespace kolos.controller;

[ApiController]
[Route("api/")]
public class ExhibitionController : ControllerBase
{
    private readonly IDBService _dbService;

    public ExhibitionController(IDBService dbService)
    {
        _dbService = dbService;
    }


    [HttpPost("exhibitions")]
    public async Task<IActionResult> createExhibition(PostDTO dto)
    {
        try
        {
            await _dbService.createExhibition(dto);
            return Ok();
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
        catch (ConflictException)
        {
            return Conflict();
        }
    }
}