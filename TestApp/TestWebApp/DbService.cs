namespace TestWebApp;

public class DbService
{
    public DbService()
    {
        if (!File.Exists("users.txt"))
        {
            StreamWriter writer = new StreamWriter("users.txt");
            writer.Close();
        }
        
    }
    public void WriteToFileTxt(string name, string surName, string middleName, string number, string SNILS)
    {
        StreamWriter writer = new StreamWriter("users.txt", true);
        writer.WriteLine($"{name} {surName} {middleName} {number} {SNILS}");
        writer.Close();
    }

    public string ReadFromFileTxt()
    {
        StreamReader reader = new StreamReader("users.txt");

        if (!File.Exists("users.txt"))
            throw new Exception("Файла не существует!");

        List<string> dataList = reader.ReadToEnd().Split("\r\n").ToList();
        dataList.Remove("");
        string result = String.Join(", ", dataList);
        reader.Close();
        return result;
    }

    public string ReadFromFileTxtById(int id)
    {
        StreamReader reader = new StreamReader("users.txt");

        if (!File.Exists("users.txt"))
            throw new Exception("Файла не существует!");

        List<string> dataList = reader.ReadToEnd().Split("\r\n").ToList();
        reader.Close();
        
        dataList.Remove("");
        
        if (dataList.Count <= id)
            return "";
        
        return dataList[id];
    }

    public void ClearDataFile()
    {
        File.WriteAllText("users.txt", null);
    }
}