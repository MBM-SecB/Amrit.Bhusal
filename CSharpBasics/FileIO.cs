using System;
using System.IO;

public class FileIO
{
    public void LearnFileHandling()
    {
        string filePath= @"C:\Users\dell\Desktop\Lab\Amrit.Bhusal\CSharpBasics\README.md";
        string fileWithInProject ="Inheritance.cs";
        if (File.Exists(fileWithInProject))
        {
        var fileContent = File.ReadAllLines(fileWithInProject);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(fileWithInProject);
        }
    }
    public void LearnFileWriting()
    {
        string filePath ="Abc.txt";
        File.WriteAllText(filePath,"This is random file content");



    }
    public void LearFileInfo()
    {
        string filePath = "Abc.txt";
        FileInfo fileInfo = new FileInfo(filePath);
        var size=fileInfo.Length;
        var createDate = fileInfo.CreationTime;

        Console.WriteLine(filePath);
        Console.WriteLine($"Size:{size} bytes");
        Console.WriteLine($"Created:: {createDate}");
    }

    public void LearnDirectory()
    {

        string folderPath = "MBM";
        Directory.CreateDirectory(folderPath);

        Console.WriteLine("Do you want to delete MBM folder");
        string confirm=Console.ReadLine();
        if (confirm=="Y")
        {
            Directory.Delete(folderPath);
        }
        
    }

    public void Assignment()
    {
        string rootFolderName = "Nepal";
        Directory.CreateDirectory(rootFolderName);
        string[] subFoldersName = {"Nepal","Korea","China","Russia","Pakistan","Bangladesh","Bhutan","Srilanka","Japan","Australia"};
        foreach(string sub in subFoldersName)
        {
            string subFolderNamePath = rootFolderName + "/" + sub;
            Directory.CreateDirectory(subFolderNamePath);
            string filePath = subFolderNamePath + "/" + "Test.txt";
            File.WriteAllText(filePath,sub);
        }
    }
}