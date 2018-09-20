using System;
using System.IO;

namespace AllStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StreamPlayground sp = new StreamPlayground();
            sp.Filestreams();
        }
    }

    class StreamPlayground
    {
        public void Filestreams()
        {
            string f = Path.GetFullPath(".");
            f = Path.GetPathRoot(".");
            f = Path.GetRandomFileName();
            f = Path.GetTempFileName();
            


            //FileStream fs = new FileStream();

        }
    }
}
