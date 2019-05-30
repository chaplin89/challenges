using System;
using System.IO;

namespace PunchStringDeob
{
    class Program
    {
        static void Main(string[] args)
        {
            PunchCardReader punchCardReader = new PunchCardReader();
            PuncherMachine puncherMachine = new PuncherMachine();

            if (args.Length != 2)
                return;

            foreach (var file in Directory.GetFiles(args[0], @"*.cs"))
            {
                string txt = File.ReadAllText(file);
                
                foreach (var methods in typeof(PuncherMachine).GetMethods())
                {
                    try
                    {
                        string strRep = "\"" + (string)methods.Invoke(puncherMachine, new object[] {} ) + "\"";
                        string strSub = "Class8." + methods.Name + "()";
                        txt = txt.Replace(strSub, strRep);
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex.ToString());
                    }
                }

                File.WriteAllText(file,txt);
             }
            foreach (var file in Directory.GetFiles(args[1], @"*.cs"))
            {
                string txt = File.ReadAllText(file);

                foreach (var methods in typeof(PunchCardReader).GetMethods())
                {
                    try
                    {
                        string strRep = "\"" + (string)methods.Invoke(punchCardReader, new object[] { }) + "\"";
                        string strSub = "Class7." + methods.Name + "()";
                        txt = txt.Replace(strSub, strRep);
                    }
                    catch (Exception Ex)
                    {
                        Console.WriteLine(Ex.ToString());
                    }
                }

                File.WriteAllText(file, txt);
            }
        }
    }
}
