// Decompiled with JetBrains decompiler
// Type: ns0.GClass5
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace PuncherMachine
{
    public class GClass5
    {
        private static readonly object object_0 = new object();
        protected GClass0 gclass0_0;
        protected byte[] md5File;
        protected Assembly loadedAssembly;
        private volatile bool IsExiting;
        private GForm0 gform0_0;
        private ManualResetEvent manualResetEvent_0;
        private GDelegate2<bool, byte[], byte[]> gdelegate2_0;
        protected ArrayList arrayList_0;

        protected GDelegate2<bool, byte[], byte[]> Gdelegate2_0
        {
            get
            {
                return gdelegate2_0;
            }

            set
            {
                gdelegate2_0 = value;
            }
        }

        [GAttribute1("A7C4C7D2-E9B9-42AE-AC93-BFBE39333D4E")]
        public GClass5(GForm0 gform0_1)
        {
            this.IsExiting = false;
            this.gform0_0 = gform0_1;
            try
            {
                this.arrayList_0 = new ArrayList();
                this.manualResetEvent_0 = new ManualResetEvent(true);
                byte[] numArray = method_2();
                if (numArray != null)
                {
                    File.WriteAllBytes("punchcard.bmp", numArray);
                    using (MD5 md5 = MD5.Create())
                        md5File = md5.ComputeHash(numArray);
                }
                else if (md5File == null)
                    ExitApp();
                string calibrationPath = Directory.GetCurrentDirectory() + @"\CalibrationDynMethod.dll";
                Assembly assembly = Assembly.LoadFile(calibrationPath);
                if (assembly != null)
                    loadedAssembly = assembly;
                else
                    ExitApp();
            }
            catch (Exception ex)
            {
                this.ExitApp();
            }
        }

        public void method_0(string fileName, GClass0.GDelegate0 gdelegate0_0)
        {
            gclass0_0 = new GClass0(fileName, md5File, loadedAssembly, gdelegate0_0);
        }

        [SpecialName]
        public GClass0 method_1()
        {
            return gclass0_0;
        }

        private sealed class B
        {
            public string A;

            public B()
            {
            }

            public byte A__(int obj0)
            {
                return Convert.ToByte(A.Substring(obj0, 2), 16);
            }
        }

        protected byte[] method_2()
        {
            byte[] numArray = null;
            numArray = (byte[])ns0.Resource.ResourceManager.GetObject(string.Format("resource{0}", 1));
            if (numArray != null)
                return numArray;
            Pipe gclass2 = new Pipe();

            try
            {
                numArray = gclass2.GetAndDecrypt(65281, Class0.currentHash);
            }
            catch (Exception)
            {
            }
            try
            {
                byte[] bytes = gclass2.GetAndDecrypt(65282, Class0.currentHash);
                if (bytes != null)
                {
                    B x = new B();
                    label_14:
                    int num2 = -561386173;
                    while (true)
                    {
                        int num3 = -561386176;
                        // ISSUE: variable of a compiler-generated type
                        switch (num2 ^ num3)
                        {
                            case 0:
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                md5File = Enumerable.ToArray
                                    (
                                        Enumerable.Select
                                            (
                                                Enumerable.Where
                                                (
                                                    Enumerable.Range
                                                        (
                                                            0,
                                                            x.A.Length
                                                        ),
                                                    int_0 => int_0 % 2 == 0
                                                ),
                                                new Func<int, byte>(x.A__)
                                           )
                                    );
                                num2 = -561386175;
                                continue;
                            case 2:
                                goto label_14;
                            case 3:
                                // ISSUE: object of a compiler-generated type is created
                                // ISSUE: reference to a compiler-generated field
                                x.A = Encoding.ASCII.GetString(bytes);
                                num2 = -561386176;
                                continue;
                            default:
                                goto label_16;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            label_16:
            return numArray;
        }

        public void ProcessText(string[] punch)
        {
            lock (object_0)
            {
                if (IsExiting)
                    return;

                manualResetEvent_0.Reset();
                new Thread(new ParameterizedThreadStart(ThreadTextProcess)).Start(punch);
            }
        }

        private void ThreadTextProcess(object object_1)
        {
            try
            {
                gclass0_0.DoIt((string[])object_1);
            }
            catch (Exception ex)
            {
            }
            this.manualResetEvent_0.Set();
        }

        public bool WriteShit()
        {
            try
            {
                return new Pipe().WriteShit(Utility.Response.const_0);
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public void ExitApp()
        {
            lock (GClass5.object_0)
            {
                if (IsExiting)
                    return;
                label_15:
                int temp_4 = 1956893484;
                while (true)
                {
                    int temp_5 = 1956893482;
                    switch (temp_4 ^ temp_5)
                    {
                        case 0:
                            Class0.bool_0 = true;
                            temp_4 = 1956893486;
                            continue;
                        case 1:
                            this.manualResetEvent_0.WaitOne();
                            temp_4 = 1956893482;
                            continue;
                        case 2:
                            int temp_15;
                            int temp_16;
                            if (gclass0_0 != null)
                            {
                                int temp_17 = 1956893481;
                                temp_16 = 1956893481;
                                temp_15 = temp_17;
                            }
                            else
                            {
                                temp_15 = 1956893483;
                                temp_16 = 1956893483;
                            }
                            temp_4 = temp_15;
                            continue;
                        case 3:
                            this.gclass0_0.method_5();
                            temp_4 = 1956893483;
                            continue;
                        case 4:
                            Class0.manualResetEvent_1.WaitOne();
                            temp_4 = 1956893474;
                            continue;
                        case 5:
                            goto label_14;
                        case 6:
                            IsExiting = true;
                            temp_4 = 1956893480;
                            continue;
                        case 7:
                            goto label_15;
                        case 8:
                            Class0.manualResetEvent_2.Set();
                            temp_4 = 1956893487;
                            continue;
                        default:
                            goto label_2;
                    }
                }
                label_2:
                return;
                label_14:;
            }
        }

        protected void method_8(List<byte> list_0)
        {
            Encoding.ASCII.GetString(list_0.ToArray(), 1, list_0.Count - 1);
        }

        public delegate T GDelegate2<T, U, V>(U gparam_0, V gparam_1);

        public delegate T GDelegate3<T, U>(U gparam_0);
    }
}
