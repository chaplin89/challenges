// Decompiled with JetBrains decompiler
// Type: ns0.Class0
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace PuncherMachine
{
    internal static class Class0
    {
        public static volatile bool bool_0 = false;
        public static byte[] currentHash = { 60,192,33,248,188,98,62,192,245,69,12,85,65,139,161,32};
        private static ManualResetEvent manualResetEvent_0;
        public static ManualResetEvent manualResetEvent_1;
        public static ManualResetEvent manualResetEvent_2;
        private static readonly object object_0;
        private static int int_0;

        static Class0()
        {
            label_5:
            int num1 = 744585839;
            while (true)
            {
                int num2 = 744585836;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_5;
                    case 1:
                        Class0.object_0 = new object();
                        Class0.int_0 = 2;
                        num1 = 744585838;
                        continue;
                    case 2:
                        goto label_4;
                    case 3:
                        Class0.manualResetEvent_0 = new ManualResetEvent(false);
                        Class0.manualResetEvent_1 = new ManualResetEvent(false);
                        Class0.manualResetEvent_2 = new ManualResetEvent(false);
                        num1 = 744585837;
                        continue;
                    default:
                        goto label_6;
                }
            }
            label_6:
            return;
            label_4:;
        }

        [GAttribute0("8B5C690C-909B-4510-AB4C-15A0E19F73C0")]
        [STAThread]
        private static void Main()
        {
            bool createdNew = false;
            Mutex mutex = null;
            smethod_0();
            mutex = new Mutex(true, "3023912A-E3F8-4026-B6E1-3950992FAFE8", out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("Another instance is already running.");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GForm0());
            GC.KeepAlive(mutex);
        }

        [GAttribute0("2E0666AC-9D68-4C16-85DD-7442AC607D81")]
        private static void smethod_0()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(Class0.smethod_1));
            thread.IsBackground = true;
            label_4:
            int num1 = 730800274;
            while (true)
            {
                int num2 = 730800272;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_4;
                    case 2:
                        thread.Start((object)null);
                        num1 = 730800275;
                        continue;
                    case 3:
                        Class0.manualResetEvent_0.WaitOne();
                        num1 = 730800273;
                        continue;
                    default:
                        return;
                }
            }
        }

        [GAttribute0("B31431D2-B17E-404F-8F39-8356CC5D69EE")]
        private static void smethod_1(object object_1)
        {
            try
            {
                Thread thread = object_1 as Thread;
                label_23:
                int num1 = 1441150033;
                while (true)
                {
                    int num2 = 1441150032;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            Thread.Sleep(200);
                            num1 = 1441150037;
                            continue;
                        case 1:
                            int num3;
                            int num4;
                            if (thread == null)
                            {
                                int num5 = 1441150040;
                                num4 = 1441150040;
                                num3 = num5;
                            }
                            else
                            {
                                num3 = 1441150041;
                                num4 = 1441150041;
                            }
                            num1 = num3;
                            continue;
                        case 2:
                            num1 = 1441150041;
                            continue;
                        case 3:
                            if (!Debugger.IsAttached)
                            {
                                int num5;
                                int num6;
                                if (Debugger.IsLogging())
                                {
                                    int num7 = 1441150042;
                                    num6 = 1441150042;
                                    num5 = num7;
                                }
                                else
                                {
                                    num5 = 1441150039;
                                    num6 = 1441150039;
                                }
                                num1 = num5;
                                continue;
                            }
                            goto case 10;
                        case 4:
                            Class0.manualResetEvent_2.Set();
                            num1 = 1441150038;
                            continue;
                        case 5:
                            Class0.manualResetEvent_0.Set();
                            num1 = 1441150034;
                            continue;
                        case 6:
                            Thread.Sleep(500);
                            num1 = 1441150041;
                            continue;
                        case 7:
                            int num8;
                            int num9;
                            if (thread.IsAlive)
                            {
                                int num5 = 1441150038;
                                num9 = 1441150038;
                                num8 = num5;
                            }
                            else
                            {
                                num8 = 1441150036;
                                num9 = 1441150036;
                            }
                            num1 = num8;
                            continue;
                        case 8:
                            thread = new Thread(new ParameterizedThreadStart(Class0.smethod_1));
                            thread.IsBackground = true;
                            thread.Start((object)Thread.CurrentThread);
                            num1 = 1441150032;
                            continue;
                        case 10:
                            Class0.manualResetEvent_2.Set();
                            num1 = 1441150038;
                            continue;
                        case 11:
                            goto label_23;
                        default:
                            if (Class0.bool_0)
                                goto label_24;
                            else
                                goto case 3;
                    }
                }
                label_24:
                lock (Class0.object_0)
                {
                    if (--Class0.int_0 != 0)
                        return;
                    label_30:
                    int temp_51 = 1441150034;
                    while (true)
                    {
                        int temp_52 = 1441150032;
                        switch (temp_51 ^ temp_52)
                        {
                            case 0:
                                goto label_30;
                            case 1:
                                goto label_29;
                            case 2:
                                Class0.manualResetEvent_1.Set();
                                temp_51 = 1441150033;
                                continue;
                            default:
                                goto label_26;
                        }
                    }
                    label_26:
                    return;
                    label_29:;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
