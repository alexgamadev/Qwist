using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
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

    [HttpPost]
    public async Task<ActionResult> CreateAsync(Checklist newChecklist)
    {
        await _checklistRepository.CreateAsync(newChecklist);
        return Ok();
    }
}
