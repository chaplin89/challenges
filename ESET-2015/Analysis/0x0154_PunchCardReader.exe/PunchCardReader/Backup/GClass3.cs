// Decompiled with JetBrains decompiler
// Type: ns0.GClass3
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using ns1;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace ns0
{
  public class GClass3
  {
    private static readonly object object_0 = new object();
    private ManualResetEvent manualResetEvent_0 = new ManualResetEvent(true);
    protected GClass0 gclass0_0;
    protected string[] string_0;
    protected Assembly assembly_0;
    private volatile bool bool_0;
    private GForm0 gform0_0;

    public GClass3(GForm0 gform0_1)
    {
      this.bool_0 = false;
      this.gform0_0 = gform0_1;
      try
      {
        this.gclass0_0 = new GClass0();
        Assembly assembly = this.method_1();
        if (assembly != null)
          this.assembly_0 = assembly;
        else
          this.method_5();
      }
      catch (Exception ex)
      {
        this.method_5();
      }
    }

    public bool method_0()
    {
      try
      {
        return new GClass2().method_1(GClass1.GEnum2.const_1);
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    protected Assembly method_1()
    {
      Assembly assembly1;
      try
      {
        byte[] rawAssembly = new GClass2().method_0(65285, Class3.byte_0);
label_4:
        int num1 = -791787414;
        while (true)
        {
          int num2 = -791787415;
          Assembly assembly2;
          switch (num1 ^ num2)
          {
            case 0:
              goto label_4;
            case 1:
              assembly1 = assembly2;
              num1 = -791787413;
              continue;
            case 3:
              assembly2 = Assembly.Load(rawAssembly);
              num1 = -791787416;
              continue;
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
      return assembly1;
    }

    public void method_2(GClass0.GDelegate0 gdelegate0_0)
    {
      lock (GClass3.object_0)
      {
        if (this.bool_0)
          return;
        this.manualResetEvent_0.Reset();
label_6:
        int temp_7 = 274683734;
        while (true)
        {
          int temp_8 = 274683732;
          switch (temp_7 ^ temp_8)
          {
            case 0:
              goto label_6;
            case 1:
              goto label_5;
            case 2:
              new Thread(new ParameterizedThreadStart(this.method_3)).Start((object) gdelegate0_0);
              temp_7 = 274683733;
              continue;
            default:
              goto label_9;
          }
        }
label_9:
        return;
label_5:;
      }
    }

    protected void method_3(object object_1)
    {
      try
      {
        GClass3.GDelegate1<bool> gdelegate1 = this.method_4(this.gclass0_0.method_0());
label_8:
        int num1 = -1008097531;
        while (true)
        {
          int num2 = -1008097530;
          switch (num1 ^ num2)
          {
            case 0:
              goto label_8;
            case 2:
              ((GClass0.GDelegate0) object_1)(GClass0.GEnum0.const_1, (object) null);
              num1 = -1008097529;
              continue;
            case 3:
              int num3;
              int num4;
              if (gdelegate1())
              {
                int num5 = -1008097532;
                num4 = -1008097532;
                num3 = num5;
              }
              else
              {
                num3 = -1008097529;
                num4 = -1008097529;
              }
              num1 = num3;
              continue;
            default:
              goto label_10;
          }
        }
      }
      catch (Exception ex)
      {
        ((GClass0.GDelegate0) object_1)(GClass0.GEnum0.const_2, (object) ex);
      }
label_10:
      this.manualResetEvent_0.Set();
    }

    private GClass3.GDelegate1<bool> method_4(string[] string_1)
    {
      MethodInfo method = this.assembly_0.GetType("DynMethod.DynMethodFactory").GetMethod("createMethod");
label_3:
      int num1 = 1921715491;
      DynamicMethod dynamicMethod;
      while (true)
      {
        int num2 = 1921715490;
        switch (num1 ^ num2)
        {
          case 0:
            goto label_3;
          case 1:
            dynamicMethod = (DynamicMethod) method.Invoke((object) null, new object[1]
            {
              (object) string_1
            });
            num1 = 1921715488;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (GClass3.GDelegate1<bool>) dynamicMethod.CreateDelegate(typeof (GClass3.GDelegate1<bool>));
    }

    public void method_5()
    {
      lock (GClass3.object_0)
      {
        if (this.bool_0)
          return;
label_14:
        int temp_4 = 1516620696;
        while (true)
        {
          int temp_5 = 1516620698;
          switch (temp_4 ^ temp_5)
          {
            case 0:
              goto label_14;
            case 1:
              Class3.bool_0 = true;
              temp_4 = 1516620701;
              continue;
            case 2:
              this.bool_0 = true;
              int temp_13;
              int temp_14;
              if (this.gclass0_0 != null)
              {
                int temp_15 = 1516620700;
                temp_14 = 1516620700;
                temp_13 = temp_15;
              }
              else
              {
                temp_13 = 1516620703;
                temp_14 = 1516620703;
              }
              temp_4 = temp_13;
              continue;
            case 3:
              goto label_13;
            case 4:
              Class3.manualResetEvent_2.Set();
              temp_4 = 1516620697;
              continue;
            case 5:
              this.manualResetEvent_0.WaitOne();
              temp_4 = 1516620699;
              continue;
            case 6:
              this.gclass0_0.method_2();
              temp_4 = 1516620703;
              continue;
            case 7:
              Class3.manualResetEvent_1.WaitOne();
              temp_4 = 1516620702;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return;
label_13:;
      }
    }

    public delegate T GDelegate1<T>();
  }
}
