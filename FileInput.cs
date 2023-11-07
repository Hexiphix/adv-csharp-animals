using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_csharp_animals
{
    public class FileInput
    {
        private StreamReader input;
        private string _fileName;

        public FileInput(string fileName) => _fileName = fileName;

        public void FileRead()
        {
            string line;
            try
            {
                while((line = input.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine($"File Open Error: {_fileName} {ex}");
            }
        }

        public string FileReadLine()
        {
            try
            {
                string line = input.ReadLine();
                return line;
            }
            catch(IOException ex)
            {
                Console.WriteLine($"File Open Error: {_fileName} {ex}");
                return null;
            }
        }

        public void FileClose()
        {
            if (input != null)
            {
                try
                {
                    input.Close();
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public void FileOpen()
        {
            if (input == null)
            {
                try
                {
                    input = new StreamReader(_fileName);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"File Open Error: {_fileName} {ex}");
                }
            }
        }
    }
}
