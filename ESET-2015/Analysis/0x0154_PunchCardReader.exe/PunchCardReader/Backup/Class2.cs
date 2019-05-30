// Decompiled with JetBrains decompiler
// Type: ns0.Class2
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using ns1;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0
{
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  internal class Class2
  {
    private static ResourceManager resourceManager_0;
    private static CultureInfo cultureInfo_0;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager_0
    {
      get
      {
        if (object.ReferenceEquals((object) Class2.resourceManager_0, (object) null))
        {
label_4:
          int num1 = -1424416617;
          while (true)
          {
            int num2 = -1424416618;
            ResourceManager resourceManager;
            switch (num1 ^ num2)
            {
              case 0:
                Class2.resourceManager_0 = resourceManager;
                num1 = -1424416620;
                continue;
              case 1:
                resourceManager = new ResourceManager("A.e", typeof (Class2).Assembly);
                num1 = -1424416618;
                continue;
              case 3:
                goto label_4;
              default:
                goto label_5;
            }
          }
        }
label_5:
        return Class2.resourceManager_0;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo CultureInfo_0
    {
      get
      {
        return Class2.cultureInfo_0;
      }
      set
      {
        Class2.cultureInfo_0 = value;
      }
    }

    internal Class2()
    {
    }
  }
}
