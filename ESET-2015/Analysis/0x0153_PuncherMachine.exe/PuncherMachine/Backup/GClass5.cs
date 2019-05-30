// Decompiled with JetBrains decompiler
// Type: ns0.GClass5
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using ns1;
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

namespace ns0
{
  public class GClass5
  {
    private static readonly object object_0 = new object();
    protected const string string_0 = "punchcard.bmp";
    protected GClass0 gclass0_0;
    protected string[] string_1;
    protected byte[] byte_0;
    protected Assembly assembly_0;
    private volatile bool bool_0;
    private GForm0 gform0_0;
    private ManualResetEvent manualResetEvent_0;
    protected GClass5.GDelegate2<bool, byte[], byte[]> gdelegate2_0;
    protected ArrayList arrayList_0;

    [GAttribute1("A7C4C7D2-E9B9-42AE-AC93-BFBE39333D4E")]
    public GClass5(GForm0 gform0_1)
    {
      this.bool_0 = false;
      this.gform0_0 = gform0_1;
      try
      {
        this.arrayList_0 = new ArrayList();
        this.manualResetEvent_0 = new ManualResetEvent(true);
        byte[] numArray = this.method_2();
        if (numArray != null)
        {
          File.WriteAllBytes("punchcard.bmp", numArray);
          using (MD5 md5 = MD5.Create())
            this.byte_0 = md5.ComputeHash(numArray);
        }
        else if (this.byte_0 == null)
          this.method_7();
        Assembly assembly = this.method_3();
        if (assembly != null)
          this.assembly_0 = assembly;
        else
          this.method_7();
      }
      catch (Exception ex)
      {
        this.method_7();
      }
    }

    public void method_0(string string_2, GClass0.GDelegate0 gdelegate0_0)
    {
      this.gclass0_0 = new GClass0(string_2, this.byte_0, this.assembly_0, gdelegate0_0);
    }

    [SpecialName]
    public GClass0 method_1()
    {
      return this.gclass0_0;
    }

    protected byte[] method_2()
    {
      ResourceManager resourceManager0 = Class5.ResourceManager_0;
label_5:
      int num1 = -561386174;
      byte[] numArray;
      while (true)
      {
        int num2 = -561386176;
        switch (num1 ^ num2)
        {
          case 1:
            if (numArray != null)
            {
              num1 = -561386176;
              continue;
            }
            goto label_7;
          case 2:
            numArray = (byte[]) resourceManager0.GetObject(string.Format("resource{0}", (object) 1));
            num1 = -561386175;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_6:
      return numArray;
label_7:
      GClass2 gclass2 = new GClass2();
      try
      {
        numArray = gclass2.method_0(65281, Class0.byte_0);
      }
      catch (Exception ex)
      {
      }
      try
      {
        byte[] bytes = gclass2.method_0(65282, Class0.byte_0);
        if (bytes != null)
        {
label_14:
          int num2 = -561386173;
          while (true)
          {
            int num3 = -561386176;
            // ISSUE: variable of a compiler-generated type
            GClass5.Class4 class4;
            switch (num2 ^ num3)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                this.byte_0 = Enumerable.ToArray<byte>(Enumerable.Select<int, byte>(Enumerable.Where<int>(Enumerable.Range(0, class4.string_0.Length), (Func<int, bool>) (int_0 => int_0 % 2 == 0)), new Func<int, byte>(class4.method_0)));
                num2 = -561386175;
                continue;
              case 2:
                goto label_14;
              case 3:
                // ISSUE: object of a compiler-generated type is created
                class4 = new GClass5.Class4();
                // ISSUE: reference to a compiler-generated field
                class4.string_0 = Encoding.ASCII.GetString(bytes);
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

    [GAttribute1("B5D69577-9B0C-4368-8667-6944B46CED34")]
    protected Assembly method_3()
    {
      Assembly assembly;
      try
      {
        GClass2 gclass2 = new GClass2();
label_4:
        int num1 = -969281080;
        while (true)
        {
          int num2 = -969281078;
          byte[] rawAssembly;
          switch (num1 ^ num2)
          {
            case 1:
              assembly = Assembly.Load(rawAssembly);
              num1 = -969281078;
              continue;
            case 2:
              rawAssembly = gclass2.method_0(65284, Class0.byte_0);
              num1 = -969281077;
              continue;
            case 3:
              goto label_4;
            default:
              goto label_7;
          }
        }
      }
      catch (Exception ex)
      {
      }
      return (Assembly) null;
label_7:
      return assembly;
    }

    public void method_4(string[] string_2)
    {
      lock (GClass5.object_0)
      {
        if (this.bool_0)
          return;
label_6:
        int temp_4 = 246383719;
        while (true)
        {
          int temp_5 = 246383718;
          switch (temp_4 ^ temp_5)
          {
            case 0:
              goto label_5;
            case 1:
              this.manualResetEvent_0.Reset();
              new Thread(new ParameterizedThreadStart(this.method_5)).Start((object) string_2);
              temp_4 = 246383718;
              continue;
            case 2:
              goto label_6;
            default:
              goto label_2;
          }
        }
label_2:
        return;
label_5:;
      }
    }

    private void method_5(object object_1)
    {
      try
      {
        this.gclass0_0.method_4((string[]) object_1);
      }
      catch (Exception ex)
      {
      }
      this.manualResetEvent_0.Set();
    }

    public bool method_6()
    {
      try
      {
        return new GClass2().method_1(GClass1.GEnum2.const_0);
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    public void method_7()
    {
      lock (GClass5.object_0)
      {
        if (this.bool_0)
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
              if (this.gclass0_0 != null)
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
              this.bool_0 = true;
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
