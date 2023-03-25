namespace TestWebApp.Interfaces;
public interface INotepadStorage<T> where T : class, new()
{
    public string FilePath { get; set; }

    public void InitFile()
    {
        if (!File.Exists(FilePath))
        {
            StreamWriter sw = File.CreateText(FilePath);
            sw.Close();
        }
    }

    public void Add(T model)
    {
        throw new NotImplementedException();
    }

    public string GetAll()
    {
        throw new NotImplementedException();
    }

    public void Sort()
    {
        throw new NotImplementedException();
    }

    public string GetOne(int id)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }
}
