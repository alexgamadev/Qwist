using Checklists.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using MongoDB.Bson;
using Qwist.API.DataAccess.Models;
using Qwist.API.DataAccess.Repositories;

namespace Qwist.API.Controllers;

/// <summary>
/// The checklists controller
/// </summary>
[Route("api/checklists")]
[ApiController]
public class ChecklistsController : ControllerBase
{
    private readonly IChecklistRepository _checklistRepository;

    /// <summary>
    /// Checklists controller constructor
    /// </summary>
    /// <param name="checklistRepository">The injected checklist repository</param>
    public ChecklistsController(IChecklistRepository checklistRepository)
    {
        _checklistRepository = checklistRepository;
    }

    /// <summary>
    /// Gets all checklists
    /// </summary>
    /// <returns>An action result</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Checklist>>> GetAllAsync()
    {
        var items = await _checklistRepository.GetAllAsync();
        return Ok(items );
    }

    /// <summary>
    /// Gets all checklists
    /// </summary>
    /// <returns>An action result</returns>
    [HttpGet("{id}", Name = "Get")]
    public async Task<ActionResult<IEnumerable<Checklist>>> GetAsync(string id)
    {
        var item = await _checklistRepository.GetAsync(id);
        if (item is null)
        {
            return NotFound();
        }

        return Ok(item);
    }

    /// <summary>
    /// Creates a checklist
    /// </summary>
    /// <param name="newChecklist">The checklist data to use</param>
    /// <returns>An action result</returns>
    [HttpPost]
    public async Task<ActionResult> CreateAsync(ChecklistCreateDto newChecklist)
    {
        // Temporary before Dtos created
        var checklist = new Checklist()
        {
            Id = ObjectId.GenerateNewId().ToString(),
            Name = newChecklist.Name,
            CreatorId = newChecklist.CreatorId,
            Items = newChecklist.Items
        };

        await _checklistRepository.CreateAsync(checklist);

        return CreatedAtRoute("Get", new { id = checklist.Id }, checklist);
    }
}
