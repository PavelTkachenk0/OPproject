using Microsoft.AspNetCore.Mvc;
using TestWebApp.Interfaces;
using TestWebApp.Models;
using TestWebApp.Storages;

namespace TestWebApp.Controllers;

[Route("api/[controller]")]

public class DoctorController : Controller
{
    private INotepadStorage<DoctorModel> _doctorStorage = new DoctorStorage();
    public DoctorController()
    {
        
    }

    [HttpPost("addDoctor")]
    public IActionResult AddText([FromBody] DoctorModel doctorModel)
    {
        _doctorStorage.Add(doctorModel);
        return Ok();
    }
    
    [HttpGet("printAll")]
    public string GetText()
    {
        return _doctorStorage.GetAll();
    }
    [HttpGet("byId")]
    public string GetTextById(int id)
    {
        return _doctorStorage.GetOne(id);
    }
    [HttpDelete("clear")]
    public IActionResult DeleteText()
    {
        _doctorStorage.Clear();
        return Ok();
    }
}
