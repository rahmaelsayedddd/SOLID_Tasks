using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    // 2. Client need to build an application to manage data using group of SQL files.
    // a. we need to develop load text and save text functionalities for group of SQL files in the application directory.
    // b. we need a manager class that manages the load and saves the text of group of SQL files along with the SqlFile Class.

    //public abstract class File
    //{
    //    public string FilePath { get; set; }
    //    public string FileText { get; set; }
    //    public abstract string LoadText();
    //    public abstract string SaveText();
    //}
    //public class SqlFile:File
    //{
    //    public override string LoadText()
    //    {
    //        return $"Loading Text {FileText} from {FilePath} File";
    //    }

    //    public override string SaveText()
    //    {
    //        return $"Saving Text {FileText} To {FilePath} File";
    //    }
    //}

    //public class FileManager
    //{
    //    private List<File> LstFiles;
    //    public FileManager(List<File> _LstFiles)
    //    {
    //        LstFiles = _LstFiles;
    //    }
        
    //    public string GetTextFromFiles()
    //    {
    //        StringBuilder objStrBuilder = new StringBuilder();
    //        foreach (var objFile in LstFiles)
    //        {
    //            objStrBuilder.Append(objFile.LoadText());
    //        }
    //        return objStrBuilder.ToString();
    //    }
    //    public void SaveTextIntoFiles()
    //    {
    //        foreach (var objFile in LstFiles)
    //        {
    //            objFile.SaveText();
    //        }
    //    }
    //}
    //internal class Task02
    //{
    //}
}
