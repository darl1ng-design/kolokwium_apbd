using kolos.exception;
using kolos.service;
using Microsoft.AspNetCore.Mvc;

namespace kolos.controller;

[ApiController]
[Route("api/galleries")]
public class GalleryController : ControllerBase
{
    private readonly IDBService _dbService;

    public GalleryController(IDBService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{id}/exhibitions")]
    public async Task<IActionResult> GetExhibitions(int id)
    {
        try
        {
            var exhibitons = await _dbService.getExhibitionsByGalleryId(id);
            return Ok(exhibitons);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }
}