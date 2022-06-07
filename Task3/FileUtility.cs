using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FileUtility
    {
        public void WriteLine(string text)
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory() + "data.txt";
            File.Create(currentDirectory);
            FileStream fileStream = File.Open(currentDirectory, FileMode.Append);
            string txt = "Hello Programmer";
            byte[] txtfile = Encoding.UTF8.GetBytes(txt);
            fileStream.Write(txtfile);
        }
    }
}
