using EnumUseWithParametr.Enums;
using MenuWithEnum.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EnumController : ControllerBase
{
    [HttpGet("getEnumValues")]
    public IActionResult GetEnumValues()
    {
        var enumModel = new EnumModel
        {
            MenuTypes = Enum.GetValues(typeof(MenuType))
                            .Cast<MenuType>()
                            .Select(type => new SelectListItem
                            {
                                Value = type.ToString(),
                                Text = Enum.GetName(typeof(MenuType), type)
                            })
                            .ToList()
        };

        return Ok(enumModel);
    }
}

