using Microsoft.AspNetCore.Mvc;
using TestWebApp.Interfaces;
using TestWebApp.Models;
using TestWebApp.Storages;

namespace TestWebApp.Controllers;

[Route("api/[controller]")]

public class UserController : Controller
{
    private INotepadStorage<UserModel> _userStorage = new UserStorage();
    public UserController()
    {

    }

    [HttpPost("addUser")]
    public IActionResult AddText([FromBody] UserModel userModel)
    {
        _userStorage.Add(userModel); 
        return Ok();
    }
    [HttpGet("addUser")]
    public IActionResult AddText1([FromQuery] string name, [FromQuery] string surName, [FromQuery] string middleName,
    [FromQuery] string number, [FromQuery] string SNILS)
    {
        _userStorage.Add(new UserModel { FirstName = name, LastName = surName, MiddleName = "" });
        return Ok();
    }
    [HttpGet("printAll")]
    public string GetText()
    {
        return _userStorage.GetAll();
    }
    [HttpGet("byId")]
    public string GetTextById(int id)
    {
        return _userStorage.GetOne(id);
    }
    [HttpDelete("clear")]
    public IActionResult DeleteText()
    {
        _userStorage.Clear();
        return Ok();
    }
}
