using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

[ApiController]
public class BreakfastController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request) {
        return Ok();
    }
}