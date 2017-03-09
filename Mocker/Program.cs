using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Mocker
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "D:\\1.pdf";
            var logName = "log.txt";
            var text = HelloJianshu.PdfRender.DefaultRender.GetResultantText(fileName);
            File.WriteAllText(logName, text);
            Console.WriteLine("ok!");
        }
    }
}
