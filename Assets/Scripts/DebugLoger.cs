using System;
using System.Text;
using System.IO;

sealed class DebugLoger
{
    private static DebugLoger single = null;
    private StringBuilder _logs = new StringBuilder();

    protected DebugLoger(){}

    public static DebugLoger GetInstance()
    {
        if (single == null)
            single = new DebugLoger();

        return single;
    }

    public void Write(string text)
    {
        single._logs.AppendLine(text);
        SaveFile(Path.Combine(Directory.GetCurrentDirectory(), "DebugLog.log"));
    }

    public string Read() => single._logs.ToString();

    private void SaveFile(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                var create = File.Create(filePath);
                create.Close();
            }

            File.WriteAllText(filePath, Read());
        }
        catch(IOException ex)
        {
            //TODO
        }
    }
}
