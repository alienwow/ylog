using System;

namespace YLog.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Debugger.Debug("Debugger.Debug");
            Debugger.Info("Debugger.Info");
            Debugger.Warn("Debugger.Warn");
            Debugger.Error("Debugger.Error");
            Debugger.Fatal("Debugger.Fatal");



            Trace.Debug("Trace.Debug");
            Trace.Info("Trace.Info");
            Trace.Warn("Trace.Warn");
            Trace.Error("Trace.Error", new Exception("异常信息啊"));
            Trace.Fatal("Trace.Fatal");
            Trace.Write("Trace.Write");

            Console.ReadLine();
        }
    }
}
