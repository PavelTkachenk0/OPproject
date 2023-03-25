//using Microsoft.AspNetCore.Mvc;
//using TestWebApp.Models;

//namespace TestWebApp.Controllers;

//[Route("api/[controller]")]
//public class HomeController : Controller
//{
//    private DbService _dbService = new();
    
//    public HomeController() { }

//    [HttpPost("addUser")]
//    public IActionResult AddText([FromBody]UserModel userModel)
//    {
//        _dbService.WriteToFileTxt(userModel.Name, userModel.SurName, userModel.MiddleName, userModel.Number, userModel.SNILS); ;
//        return Ok();
//    }
//    [HttpGet("addUser")]
//    public IActionResult AddText1([FromQuery] string name, [FromQuery] string surName, [FromQuery] string middleName, 
//    [FromQuery] string number, [FromQuery] string SNILS)
//    {
//        _dbService.WriteToFileTxt(name, surName, middleName, number, SNILS);
//        return Ok();
//    }
//    [HttpGet("printAll")]
//    public string GetText()
//    {
//        return _dbService.ReadFromFileTxt();
//    }
//    [HttpGet("byId")]
//    public string GetTextById(int id)
//    {
//        return _dbService.ReadFromFileTxtById(id);
//    }
//    [HttpDelete("clear")]
//    public IActionResult DeleteText()
//    {
//        _dbService.ClearDataFile();
//        return Ok();
//    }
//}