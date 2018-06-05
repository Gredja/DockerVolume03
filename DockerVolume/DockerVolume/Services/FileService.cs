using System;
using System.IO;

namespace DockerVolume.Services
{
   public class FileService : IFileService
    {
        private const string FilePath = "text/text.txt";

        public string Read()
        {
            string text;

            using (var reader = new StreamReader(Path.Combine(Environment.CurrentDirectory, FilePath)))
            {
                text = reader.ReadToEnd();
                reader.Close();
            }

            return text;
        }

        public void Write(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory, FilePath), true, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
                sw.Close();
            }
        }
    }
}
