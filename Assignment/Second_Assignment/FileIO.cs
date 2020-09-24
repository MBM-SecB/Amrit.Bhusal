using System;
using System.IO;

public class FileIO
{
    public void Assignment()
    {
        string rootFolderName = "Nepal";
        Directory.CreateDirectory(rootFolderName);
        string[] subFoldersName = {"Nepal",
        "Korea",
        "China",
        "Russia",
        "Pakistan",
        "Bangladesh",
        "Bhutan",
        "Srilanka",
        "Japan",
        "Australia",
        };
        foreach(string sub in subFoldersName)
        {
            string subFolderNamePath = rootFolderName + "/" + sub;
            Directory.CreateDirectory(subFolderNamePath);
            string filePath = subFolderNamePath + "/" + "Test.txt";
            File.WriteAllText(filePath,sub);
        }
    }
}