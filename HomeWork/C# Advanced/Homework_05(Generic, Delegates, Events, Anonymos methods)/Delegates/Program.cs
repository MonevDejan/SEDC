using System;
using System.IO;

namespace DelegatesExercise
{
    public delegate int MathActions1(int x, int y);
    public delegate double MathActions2(double x, double y);

    #region Classes
    public class MyClass
    {
        public delegate void LogHandler(string message);
        public delegate int Sum(int x, int y);

        public void Process(LogHandler logHandler)
        {
            logHandler?.Invoke("Process() begin");

            logHandler?.Invoke("Process() end");
        }

        public int ProcessInt(Sum SumHandler)
        {
            return SumHandler(6, 8);
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
    #endregion

    public class Program
    {
        #region Static Functions
        public static void Logger(string s)
        {
            Console.WriteLine(s);
        }
        
        public static int Sum (int x, int y)
        {
            return x + y;
        }
        
        public static int Multiyply (int x, int y)
        {
            return x * y;
        }

        public static double Devide(double x, double y )
        {
            return x / y;
        }

        public static double Average (double x, double y)
        {
            return (x + y) / 2;
        }
        #endregion

        static void Main()
        {
            MyClass myClass = new MyClass();

            MathActions1 m1 = new MathActions1(Sum);
            Console.WriteLine(m1(3, 5));
            m1 += new MathActions1(Multiyply);
            Console.WriteLine(m1(3, 5));

            MathActions2 m2 = new MathActions2(Devide);
            Console.WriteLine(m2(3.53, 6.45));
            m2 += new MathActions2(Average);
            Console.WriteLine("{0}  {1}", m2(3.53, 6.45), m2(3.53, 6.45)); //it invokes only the last function that is added because it has return value

            Console.WriteLine("_______________________________");
            
            MathActions1 m3 = new MathActions1(Multiyply);
            MathActions1 m4 = new MathActions1(Sum);

            FileLogger fl = new FileLogger(@"C:\Users\Ne0-Ge0\Desktop\process.log");
            MyClass.LogHandler myLogger = new MyClass.LogHandler(fl.Logger);

            MyClass.Sum myProduct = new MyClass.Sum(m3);
            MyClass.Sum mySum = new MyClass.Sum(m4);
            MyClass.Sum mySum2 = new MyClass.Sum(m1);

            myLogger += new MyClass.LogHandler(Logger);

            myClass.Process(myLogger); //it invokes all the functions that are void 
            Console.WriteLine(myClass.ProcessInt(myProduct));
            Console.WriteLine(myClass.ProcessInt(mySum));
            Console.WriteLine(myClass.ProcessInt(mySum2)); //it invokes only the last function that is added because it has return value

            fl.Close();

            Console.ReadLine();
        }
    }
}
