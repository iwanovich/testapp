using System;
using testlib;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Speaker speaker = new SpeakerImpl();
            Console.WriteLine(speaker.sayOrder());
        }
    }
}
