using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharpExam70_483
{
    public static class Section3
    {
        public static void Do()
        {
            var stringRW = new StringReaderWriter();
            stringRW.Do();
        }
    }

    public class StringReaderWriter
    {
        StringBuilder StringBuilder = new StringBuilder();
        public void Do()
        {
            Write();
            Read();

        }

        private void Read()
        {
            var stringReader = new StringReader(StringBuilder.ToString());
            Console.WriteLine("Reading the result");
            while (stringReader.Peek() > -1)
            {
                Console.WriteLine(stringReader.ReadLine());
            }

            stringReader.Close();
        }

        private void Write()
        {
            
            var stringWriter = new StringWriter(StringBuilder);
            stringWriter.Write("Heellooo");
            stringWriter.Flush();
            stringWriter.Close();
        }
    }
}
