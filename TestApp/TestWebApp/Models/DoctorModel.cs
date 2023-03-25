namespace TestWebApp.Models;

public class DoctorModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public string SpecialityName { get; set;} = null!;
    public string PriceOfServices { get; set;} = null!;
    public string ScheduleId { get; set; } = null!;
}
