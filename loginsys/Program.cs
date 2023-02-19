using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginsys
{
    internal class Program
    {
        static FileStream FStream;
        static StreamWriter SWriter;
        static void Main(string[] args)
        {
            demo d = new demo();
            FStream = new FileStream("F:\\employee\\login.txt", FileMode.Append, FileAccess.Write);
            SWriter = new StreamWriter(FStream);
            SWriter.WriteLine("Employee");
            SWriter.WriteLine(d.heading());
            SWriter.WriteLine(d.Name());
            SWriter.WriteLine(d.timing());
            SWriter.Flush();
            SWriter.Close();
            FStream.Close();



        }
    }
}
