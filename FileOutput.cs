using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_csharp_animals
{
    public class FileOutput
    {
        private StreamWriter output;
        private string _fileName;

        public FileOutput(string fileName) => _fileName = fileName;

        public void FileWrite(string line) 
        {
            try
            {
                output.WriteLine(line);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void FileClose()
        {
            if(output != null)
            {
                try
                {
                    output.Close();
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

        public void FileOpen()
        {
            if (output == null)
            {
                try
                {
                    output = new StreamWriter(_fileName);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"File Open Error: {_fileName} {ex}");
                }
            }
        }
    }
}
