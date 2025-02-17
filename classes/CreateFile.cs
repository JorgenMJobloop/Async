public class CreateFile
{
    public void WriteToFile(string filePath, string content)
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath);
        }
        ;
        File.WriteAllText(filePath, content);
    }

    public void WriteLogFile(string filePath, string content)
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath);
        }
        File.WriteAllText(filePath, content);
    }
}