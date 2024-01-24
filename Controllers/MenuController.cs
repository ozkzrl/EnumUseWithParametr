using EnumUseWithParametr.Enums;
using EnumUseWithParametr.Model;
using MenuWithEnum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class MenuController : ControllerBase
{
    private readonly ApplicationDbContext _context;
   

    public MenuController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpPost("selectMenu")]
    public IActionResult SelectMenu([FromBody] MenuType selectedValue)
    {
        try
        {
            var menuItem = new MenuItem
            {
                MenuType = selectedValue,
                DisplayName = Enum.GetName(typeof(MenuType), selectedValue),
                Url = $"/{selectedValue.ToString().ToLower()}"

            };

            _context.MenuItems.Add(menuItem);
            _context.SaveChanges();

            return Ok(new { success = true, message = "Menu item added to the database." });
        }
        catch (Exception ex)
        {
            return BadRequest(new { success = false, message = ex.Message });
        }
    }



    [HttpGet("getMenu")]
    public IActionResult GetMenu()
    {
        var menuItems = Enum.GetValues(typeof(MenuType))
                            .Cast<MenuType>()
                            .Select(type => new MenuItem
                            {
                                MenuType = type,
                                DisplayName = Enum.GetName(typeof(MenuType), type),
                                Url = $"/{type.ToString().ToLower()}"
                            })
                            .ToList();

        return Ok(menuItems);
    }
}