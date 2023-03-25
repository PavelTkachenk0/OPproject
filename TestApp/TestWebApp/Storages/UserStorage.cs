using TestWebApp.Interfaces;
using TestWebApp.Models;

namespace TestWebApp.Storages;
public class UserStorage : INotepadStorage<UserModel>
{
    public string FilePath { get; set; } = "users.txt";

    public void Add(UserModel model)
    {
        StreamWriter sw = new StreamWriter(FilePath, true);
        sw.WriteLine($"{model.Id} {model.FirstName} {model.LastName} {model.MiddleName} {model.PhoneNumber} {model.Snils} {model.FormService}");
        sw.Close();
    }

    public string GetAll()
    {
        StreamReader sr = new StreamReader(FilePath);
        var data = sr.ReadToEnd().Split("\r\n").ToList();
        data.Remove("");
        sr.Close();
        string result = String.Join(", ", data);
        return result;
    }

    public void Sort()
    {
        StreamReader sr = new StreamReader(FilePath);
        var data = sr.ReadToEnd().Split("\r\n").ToList();
        sr.Close();
        List<string> sortedData = new();
        foreach (var val in data)
        {
        }
    }

    public string GetOne(int id)
    {
        StreamReader sr = new StreamReader(FilePath);
        var data = sr.ReadToEnd().Split("\r\n").ToList();
        sr.Close();
        string result = "";
        foreach (var val in data)
        {
            List<string> values = val.Split(" ").ToList();
            int idIn;
            int.TryParse(values[0], out idIn);
            if (id == idIn)
            {
                return val;
            }
        }

        return result;
    }


    public void Delete(int id)
    {
        StreamReader sr = new StreamReader(FilePath);
        var data = sr.ReadToEnd().Split("\r\n").ToList();
        sr.Close();
        foreach (var val in data)
        {
            List<string> values = val.Split(" ").ToList();
            int idIn;
            int.TryParse(values[0], out idIn);
            if (id == idIn)
            {
                data.Remove(val);
                string newContent = String.Join("\r\n", data);
                File.WriteAllText(FilePath, newContent);
                return;
            }
        }
    }

    public void Clear()
    {
        File.WriteAllText(FilePath, null);
    }
}
