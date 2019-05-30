using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace ExtractKey
{
    class Program
    {
        public static object A { get; private set; }

        static void Main(string[] args)
        {
            byte [] hash_1 = ComputeHashFromMethods("PuncherMachine.exe", "A.D");
            byte [] hash_2 = ComputeHashFromMethods("PunchCardReader.exe", "A.b");

            System.Console.Write("Showing hash for PuncherMachine.exe:\t");

            foreach (byte b in hash_1)
                System.Console.Write(string.Format("{0:X2}", b));
            System.Console.Write(Environment.NewLine);
            System.Console.Write("Showing hash for PunchCardReader.exe:\t");
            foreach (byte b in hash_2)
                System.Console.Write(string.Format("{0:X2}", b));
        }

        private static byte[] ComputeHashFromMethods(string path, string attribute)
        {
            string currentDir = Directory.GetCurrentDirectory() + "\\";
            Assembly currentAssembly = Assembly.LoadFile(currentDir + path);

            MD5 md5 = MD5.Create();
            try
            {
                IEnumerator<MethodAttribute_0<MethodInfo, object>> enumerator =
                    Enumerable.Select
                    (
                        Enumerable.Where
                        (
                            Enumerable.Select
                            (
                                Enumerable.SelectMany
                                (
                                    currentAssembly.GetTypes(),
                                    type_0 =>
                                        type_0.GetMethods
                                        (
                                            BindingFlags.Instance |
                                            BindingFlags.Static |
                                            BindingFlags.Public |
                                            BindingFlags.NonPublic
                                        )
                                ),
                                methodInfo_0 =>
                                    new MethodAttribute_1<MethodInfo, object[]>
                                    (
                                        methodInfo_0,
                                        methodInfo_0.GetCustomAttributes(currentAssembly.GetType(attribute), true)
                                    )
                            ),
                            h_0 => h_0.GetAttribute() != null && h_0.GetAttribute().Length > 0
                        ),
                        h_0 =>
                            new MethodAttribute_0<MethodInfo, object>
                            (
                                h_0.GetMethod(),
                                (object)h_0.GetAttribute()[0]
                            )
                    ).GetEnumerator();
                try
                {
                    Type loadedType = currentAssembly.GetType(attribute);
                    MethodAttribute_0<MethodInfo, object> current;
                    byte[] ilAsByteArray;

                    while (enumerator.MoveNext())
                    {
                        current = enumerator.Current;
                        string name = current.GetCurrentMethod().Name;
                        ilAsByteArray = current.GetCurrentMethod().GetMethodBody().GetILAsByteArray();
                        md5.TransformBlock(ilAsByteArray, 0, ilAsByteArray.Length, (byte[])null, 0);
                        string fi = (string)current.GetCurrentAttribute().GetType().GetFields()[0].GetValue(current.GetCurrentAttribute());
                        byte[] bytes = Encoding.UTF8.GetBytes(fi);
                        md5.TransformBlock(bytes, 0, bytes.Length, null, 0);
                    }
                }
                finally
                {
                    if (enumerator != null)
                        enumerator.Dispose();
                }
                md5.TransformFinalBlock(new byte[0], 0, 0);
                return md5.Hash;
            }
            finally
            {
                if (md5 != null)
                    md5.Clear();
            }
        }
    }
}
