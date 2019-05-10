using System;
using System.IO;

namespace EventsExercise
{

    public class MyClass
    {
        public delegate void LogHandler(string message);
        public delegate int Sum(int x, int y);

        public event LogHandler Log;
        public event Sum SummingNumbers;

        public void Process()
        {
            OnLog("Process() begin");
            OnLog("Process() end");
            Console.WriteLine(OnSum(10, 20)); 
        }

        protected void OnLog(string message)
        {
            if (Log != null)
            {
                Log(message);
            }
        }
        protected int OnSum(int x, int y)
        {
               return SummingNumbers(x, y);
        }
    }

    public class FileLogger
    {
        FileStream fileStream;
        StreamWriter streamWriter;

        public FileLogger(string filename)
        {
            fileStream = new FileStream(filename, FileMode.Create);
            streamWriter = new StreamWriter(fileStream);
        }

        public void Logger(string s)
        {
            streamWriter.WriteLine(s);
        }

        public void Close()
        {
            streamWriter.Close();
            fileStream.Close();
        }
    }

    public class TestApplication
    {
        static void Logger(string s)
        {
            Console.WriteLine(s + " C# evenets and Delegates");
        }
        static int SumOfNumbers (int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            FileLogger fl = new FileLogger(@"C:\Users\Ne0-Ge0\Desktop\process1.log");
            MyClass myClass = new MyClass();

            myClass.Log += new MyClass.LogHandler(Logger);
            myClass.Log += new MyClass.LogHandler(fl.Logger);
            myClass.SummingNumbers += new MyClass.Sum(SumOfNumbers);

            myClass.Process();

            fl.Close();

            Console.ReadLine();
        }
    }
}