// Decompiled with JetBrains decompiler
// Type: ns0.Class3
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
    internal static class Class3
    {
        public static volatile bool bool_0 = false;
        private static ManualResetEvent manualResetEvent_0 = new ManualResetEvent(false);
        public static byte[] byte_0;
        public static ManualResetEvent manualResetEvent_1;
        public static ManualResetEvent manualResetEvent_2;
        private static readonly object object_0;
        private static int int_0;

        static Class3()
        {
            label_5:
            int num1 = 1407955903;
            while (true)
            {
                int num2 = 1407955901;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_5;
                    case 1:
                        Class3.int_0 = 2;
                        num1 = 1407955902;
                        continue;
                    case 2:
                        Class3.manualResetEvent_1 = new ManualResetEvent(false);
                        Class3.manualResetEvent_2 = new ManualResetEvent(false);
                        Class3.object_0 = new object();
                        num1 = 1407955900;
                        continue;
                    case 3:
                        goto label_4;
                    default:
                        goto label_6;
                }
            }
            label_6:
            return;
            label_4:;
        }

        [GAttribute0("387EF9CD-00B1-479C-9B5A-4E0B041F2007")]
        [STAThread]
        private static void Main()
        {
            bool createdNew = true;
            Mutex mutex = null;
            int num1 = 295175216;
            goto label_8;
            label_5:
            num1 = 295175223;
            label_8:
            while (true)
            {
                int num2 = 295175222;
                switch (num1 ^ num2)
                {
                    case 0:
                        if (createdNew)
                            goto case 4;
                        else
                            goto label_11;
                    case 1:
                        goto label_7;
                    case 2:
                        goto label_5;
                    case 3:
                        Application.Run((Form)new GForm0());
                        num1 = 295175219;
                        continue;
                    case 4:
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        num1 = 295175221;
                        continue;
                    case 6:
                        goto label_10;
                    case 7:
                        mutex = new Mutex(true, "C6513807-9F93-4A38-A422-9F1EF8F30E70", out createdNew);
                        num1 = 295175222;
                        continue;
                    default:
                        goto label_12;
                }
            }
            label_7:
            return;
            label_11:
            int num3 = (int)MessageBox.Show("Another instance is already running.");
            return;
            label_12:
            GC.KeepAlive((object)mutex);
            return;
            label_10:
            Class3.smethod_0();
            num1 = 295175217;
            goto label_8;
        }

        [GAttribute0("64FAC7B6-AE8B-4D65-89FF-F9EB457BA5C6")]
        private static void smethod_0()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(Class3.smethod_1));
            label_5:
            int num1 = 1451163304;
            while (true)
            {
                int num2 = 1451163307;
                switch (num1 ^ num2)
                {
                    case 0:
                        goto label_5;
                    case 1:
                        goto label_4;
                    case 2:
                        Class3.manualResetEvent_0.WaitOne();
                        /* Senza nome1 (09/11/2015 19:49:16)
   Offset di inizio: 00000000, Offset finale: 0000000F, Lunghezza: 00000010 */

                        Class3.byte_0 = new byte []{
                            0xA2, 0x6D, 0x11, 0xDE, 0xE2, 0x94, 0x28, 0x4F, 0x38, 0xDB, 0x8A, 0x72,
                            0x4C, 0x11, 0x9D, 0x74
                        };

                        num1 = 1451163306;
                        continue;
                    case 3:
                        thread.IsBackground = true;
                        thread.Start((object)null);
                        num1 = 1451163305;
                        continue;
                    default:
                        goto label_6;
                }
            }
            label_6:
            return;
            label_4:;
        }

        [GAttribute0("82C03C09-F8AC-485C-AE32-8C2E42898C3C")]
        private static void smethod_1(object object_1)
        {
            try
            {
                Thread thread = object_1 as Thread;
                label_23:
                int num1 = -118947816;
                while (true)
                {
                    int num2 = -118947823;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            int num3;
                            int num4;
                            if (!thread.IsAlive)
                            {
                                int num5 = -118947822;
                                num4 = -118947822;
                                num3 = num5;
                            }
                            else
                            {
                                num3 = -118947817;
                                num4 = -118947817;
                            }
                            num1 = num3;
                            continue;
                        case 1:
                            thread.Start((object)Thread.CurrentThread);
                            Thread.Sleep(200);
                            Class3.manualResetEvent_0.Set();
                            num1 = -118947814;
                            continue;
                        case 2:
                            if (!Debugger.IsAttached)
                            {
                                int num5;
                                int num6;
                                if (Debugger.IsLogging())
                                {
                                    int num7 = -118947813;
                                    num6 = -118947813;
                                    num5 = num7;
                                }
                                else
                                {
                                    num5 = -118947823;
                                    num6 = -118947823;
                                }
                                num1 = num5;
                                continue;
                            }
                            goto case 10;
                        case 3:
                            Class3.manualResetEvent_2.Set();
                            num1 = -118947817;
                            continue;
                        case 4:
                            goto label_23;
                        case 6:
                            Thread.Sleep(500);
                            num1 = -118947815;
                            continue;
                        case 7:
                            thread.IsBackground = true;
                            num1 = -118947824;
                            continue;
                        case 8:
                            int num8;
                            int num9;
                            if (Class3.bool_0)
                            {
                                int num5 = -118947820;
                                num9 = -118947820;
                                num8 = num5;
                            }
                            else
                            {
                                num8 = -118947821;
                                num9 = -118947821;
                            }
                            num1 = num8;
                            continue;
                        case 9:
                            if (thread == null)
                            {
                                thread = new Thread(new ParameterizedThreadStart(Class3.smethod_1));
                                num1 = -118947818;
                                continue;
                            }
                            goto case 8;
                        case 10:
                            Class3.manualResetEvent_2.Set();
                            num1 = -118947817;
                            continue;
                        case 11:
                            num1 = -118947815;
                            continue;
                        default:
                            goto label_24;
                    }
                }
                label_24:
                lock (Class3.object_0)
                {
                    if (--Class3.int_0 != 0)
                        return;
                    label_30:
                    int temp_34 = -118947824;
                    while (true)
                    {
                        int temp_35 = -118947823;
                        switch (temp_34 ^ temp_35)
                        {
                            case 0:
                                goto label_29;
                            case 1:
                                Class3.manualResetEvent_1.Set();
                                temp_34 = -118947823;
                                continue;
                            case 2:
                                goto label_30;
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

        [GAttribute0("97C09DA9-A6E7-4A6D-819B-69B10456E731")]
        private static byte[] smethod_2()
        {
            MD5 md5 = MD5.Create();
            Class6<MethodInfo, GAttribute0> current = null;
            byte[] ilAsByteArray = null;
            try
            {
                // ISSUE: object of a compiler-generated type is created
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: object of a compiler-generated type is created
                IEnumerator<Class6<MethodInfo, GAttribute0>> enumerator = Enumerable.Select<Class5<MethodInfo, object[]>, Class6<MethodInfo, GAttribute0>>(Enumerable.Where<Class5<MethodInfo, object[]>>(Enumerable.Select<MethodInfo, Class5<MethodInfo, object[]>>(Enumerable.SelectMany<System.Type, MethodInfo>((IEnumerable<System.Type>)Assembly.GetExecutingAssembly().GetTypes(), (Func<System.Type, IEnumerable<MethodInfo>>)(type_0 => (IEnumerable<MethodInfo>)type_0.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))), (Func<MethodInfo, Class5<MethodInfo, object[]>>)(methodInfo_0 => new Class5<MethodInfo, object[]>(methodInfo_0, methodInfo_0.GetCustomAttributes(typeof(GAttribute0), true)))), (Func<Class5<MethodInfo, object[]>, bool>)(class5_0 =>
          {
            // ISSUE: reference to a compiler-generated method
            if (class5_0.method_1() != null)
              {
                // ISSUE: reference to a compiler-generated method
                return class5_0.method_1().Length > 0;
              }
              return false;
          })), (Func<Class5<MethodInfo, object[]>, Class6<MethodInfo, GAttribute0>>)(class5_0 => new Class6<MethodInfo, GAttribute0>(class5_0.method_0(), (GAttribute0)class5_0.method_1()[0]))).GetEnumerator();
                try
                {
                    label_12:
                    int num1;
                    int num2;
                    if (!enumerator.MoveNext())
                    {
                        num1 = 1566286261;
                        num2 = 1566286261;
                    }
                    else
                        goto label_11;
                    label_4:
                    while (true)
                    {
                        int num3 = 1566286263;
                        // ISSUE: variable of a compiler-generated type
                        switch (num1 ^ num3)
                        {
                            case 0:
                                goto label_12;
                            case 1:
                                // ISSUE: reference to a compiler-generated method
                                string name = current.method_0().Name;
                                num1 = 1566286257;
                                continue;
                            case 3:
                                current = enumerator.Current;
                                num1 = 1566286262;
                                continue;
                            case 4:
                                md5.TransformBlock(ilAsByteArray, 0, ilAsByteArray.Length, (byte[])null, 0);
                                // ISSUE: reference to a compiler-generated method
                                byte[] bytes = Encoding.UTF8.GetBytes(current.method_1().string_0);
                                md5.TransformBlock(bytes, 0, bytes.Length, (byte[])null, 0);
                                num1 = 1566286263;
                                continue;
                            case 5:
                                num1 = 1566286260;
                                continue;
                            case 6:
                                // ISSUE: reference to a compiler-generated method
                                ilAsByteArray = current.method_0().GetMethodBody().GetILAsByteArray();
                                num1 = 1566286259;
                                continue;
                            default:
                                goto label_18;
                        }
                    }
                    label_11:
                    int num4 = 1566286260;
                    num2 = 1566286260;
                    num1 = num4;
                    goto label_4;
                }
                finally
                {
                    if (enumerator != null)
                    {
                        label_16:
                        int num1 = 1566286261;
                        while (true)
                        {
                            int num2 = 1566286263;
                            switch (num1 ^ num2)
                            {
                                case 0:
                                    goto label_16;
                                case 2:
                                    enumerator.Dispose();
                                    num1 = 1566286262;
                                    continue;
                                default:
                                    goto label_17;
                            }
                        }
                    }
                    label_17:;
                }
                label_18:
                md5.TransformFinalBlock(new byte[0], 0, 0);
                return md5.Hash;
            }
            finally
            {
                if (md5 != null)
                {
                    label_22:
                    int num1 = 1566286261;
                    while (true)
                    {
                        int num2 = 1566286263;
                        switch (num1 ^ num2)
                        {
                            case 0:
                                goto label_22;
                            case 2:
                                md5.Clear();
                                num1 = 1566286262;
                                continue;
                            default:
                                goto label_23;
                        }
                    }
                }
                label_23:;
            }
        }
    }
}
