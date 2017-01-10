using CsvToObj.Service.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToObj
{
    class Program
    {
        static void Main(string[] args)
        {
            //testFile1();
            testFile2();
            Console.ReadLine();
        }


        static void testFile1()
        {
            var service = new TestParseServiceTextFile1();
            service.process("TextFile1.txt");
        }
        static void testFile2()
        {
            var service = new TestParseServiceTextFile2();
            service.process("TextFile2.txt");
        }
    }
}
