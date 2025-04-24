using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    // c. New Requirement:
    // After some time our leaders might tell us that we may have a few read-only files in the application folder, 
    // so we need to restrict the flow whenever it tries to do a save on them.
    public abstract class File
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public abstract string LoadText();
    }
    public class SqlFile : File
    {
        public override string LoadText()
        {
            return $"Loading Text {FileText} from {FilePath} File";
        }
    }

    public interface ISaveText
    {
        string SaveText();
    }

    public class WriteSqlFile : SqlFile, ISaveText
    {
        public string SaveText()
        {
            return $"Saving Text {FileText} To {FilePath} File";
        }
    }

    public class FileManager
    {
        public string GetTextFromFiles(List<File> LstFiles)
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in LstFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles(List<ISaveText> LstFiles)
        {
            foreach (var objFile in LstFiles)
            {
                objFile.SaveText();
            }
        }
    }

    internal class Task03
    {
    }

}
