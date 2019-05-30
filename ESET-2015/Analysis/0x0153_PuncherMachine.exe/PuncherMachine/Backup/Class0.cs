// Decompiled with JetBrains decompiler
// Type: ns0.Class0
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using ns1;
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
  internal static class Class0
  {
    public static volatile bool bool_0 = false;
    public static byte[] byte_0;
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
      if (Debugger.IsAttached)
        return;
label_15:
      int num1 = 1879049379;
      while (true)
      {
        int num2 = 1879049383;
        bool createdNew;
        Mutex mutex;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_18;
          case 1:
            goto label_14;
          case 2:
            Class0.smethod_0();
            mutex = new Mutex(true, "3023912A-E3F8-4026-B6E1-3950992FAFE8", out createdNew);
            num1 = 1879049391;
            continue;
          case 3:
            Application.EnableVisualStyles();
            num1 = 1879049378;
            continue;
          case 4:
            int num3;
            int num4;
            if (Debugger.IsLogging())
            {
              int num5 = 1879049383;
              num4 = 1879049383;
              num3 = num5;
            }
            else
            {
              num3 = 1879049381;
              num4 = 1879049381;
            }
            num1 = num3;
            continue;
          case 5:
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((Form) new GForm0());
            GC.KeepAlive((object) mutex);
            num1 = 1879049382;
            continue;
          case 6:
            goto label_17;
          case 7:
            goto label_15;
          case 8:
            int num6;
            int num7;
            if (!createdNew)
            {
              int num5 = 1879049377;
              num7 = 1879049377;
              num6 = num5;
            }
            else
            {
              num6 = 1879049380;
              num7 = 1879049380;
            }
            num1 = num6;
            continue;
          default:
            goto label_1;
        }
      }
label_1:
      return;
label_14:
      return;
label_18:
      return;
label_17:
      int num8 = (int) MessageBox.Show("Another instance is already running.");
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
            thread.Start((object) null);
            num1 = 730800275;
            continue;
          case 3:
            Class0.manualResetEvent_0.WaitOne();
            num1 = 730800273;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      Class0.byte_0 = Class0.smethod_2();
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
              thread.Start((object) Thread.CurrentThread);
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

    [GAttribute0("618EEF38-5CA5-4446-B432-62D48B5FD2F6")]
    private static byte[] smethod_2()
    {
      using (MD5 md5 = MD5.Create())
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: object of a compiler-generated type is created
        IEnumerator<Class7<MethodInfo, GAttribute0>> enumerator = Enumerable.Select<Class6<MethodInfo, object[]>, Class7<MethodInfo, GAttribute0>>(Enumerable.Where<Class6<MethodInfo, object[]>>(Enumerable.Select<MethodInfo, Class6<MethodInfo, object[]>>(Enumerable.SelectMany<System.Type, MethodInfo>((IEnumerable<System.Type>) Assembly.GetExecutingAssembly().GetTypes(), (Func<System.Type, IEnumerable<MethodInfo>>) (type_0 => (IEnumerable<MethodInfo>) type_0.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))), (Func<MethodInfo, Class6<MethodInfo, object[]>>) (methodInfo_0 => new Class6<MethodInfo, object[]>(methodInfo_0, methodInfo_0.GetCustomAttributes(typeof (GAttribute0), true)))), (Func<Class6<MethodInfo, object[]>, bool>) (class6_0 =>
        {
          // ISSUE: reference to a compiler-generated method
          if (class6_0.method_1() != null)
          {
            // ISSUE: reference to a compiler-generated method
            return class6_0.method_1().Length > 0;
          }
          return false;
        })), (Func<Class6<MethodInfo, object[]>, Class7<MethodInfo, GAttribute0>>) (class6_0 => new Class7<MethodInfo, GAttribute0>(class6_0.method_0(), (GAttribute0) class6_0.method_1()[0]))).GetEnumerator();
        try
        {
label_11:
          int num1;
          int num2;
          if (enumerator.MoveNext())
          {
            num1 = -1278104833;
            num2 = -1278104833;
          }
          else
            goto label_10;
label_4:
          while (true)
          {
            int num3 = -1278104836;
            // ISSUE: variable of a compiler-generated type
            Class7<MethodInfo, GAttribute0> current;
            switch (num1 ^ num3)
            {
              case 0:
                // ISSUE: reference to a compiler-generated method
                byte[] ilAsByteArray = current.method_0().GetMethodBody().GetILAsByteArray();
                md5.TransformBlock(ilAsByteArray, 0, ilAsByteArray.Length, (byte[]) null, 0);
                num1 = -1278104835;
                continue;
              case 1:
                // ISSUE: reference to a compiler-generated method
                byte[] bytes = Encoding.UTF8.GetBytes(current.method_1().string_0);
                md5.TransformBlock(bytes, 0, bytes.Length, (byte[]) null, 0);
                num1 = -1278104840;
                continue;
              case 3:
                current = enumerator.Current;
                num1 = -1278104836;
                continue;
              case 4:
                goto label_11;
              case 5:
                num1 = -1278104833;
                continue;
              default:
                goto label_17;
            }
          }
label_10:
          int num4 = -1278104834;
          num2 = -1278104834;
          num1 = num4;
          goto label_4;
        }
        finally
        {
          if (enumerator != null)
          {
label_15:
            int num1 = -1278104835;
            while (true)
            {
              int num2 = -1278104836;
              switch (num1 ^ num2)
              {
                case 1:
                  enumerator.Dispose();
                  num1 = -1278104836;
                  continue;
                case 2:
                  goto label_15;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
label_17:
        md5.TransformFinalBlock(new byte[0], 0, 0);
        return md5.Hash;
      }
    }
  }
}
