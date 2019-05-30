// Decompiled with JetBrains decompiler
// Type: ns0.Class5
// Assembly: PuncherMachine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E071B614-9813-405E-B7EB-E2B0175D3580
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PuncherMachine-cleaned.exe

using ns1;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0
{
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  internal class Class5
  {
    private static ResourceManager resourceManager_0;
    private static CultureInfo cultureInfo_0;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager_0
    {
      get
      {
        if (object.ReferenceEquals((object) Class5.resourceManager_0, (object) null))
        {
          ResourceManager resourceManager = new ResourceManager("A.H", typeof (Class5).Assembly);
label_4:
          int num1 = 593709491;
          while (true)
          {
            int num2 = 593709490;
            switch (num1 ^ num2)
            {
              case 1:
                Class5.resourceManager_0 = resourceManager;
                num1 = 593709490;
                continue;
              case 2:
                goto label_4;
              default:
                goto label_5;
            }
          }
        }
label_5:
        return Class5.resourceManager_0;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo CultureInfo_0
    {
      get
      {
        return Class5.cultureInfo_0;
      }
      set
      {
        Class5.cultureInfo_0 = value;
      }
    }

    internal Class5()
    {
    }

    [SpecialName]
    internal static UnmanagedMemoryStream smethod_0()
    {
      // ISSUE: reference to a compiler-generated field
      return Class5.ResourceManager_0.GetStream("Computer_card_punch", Class5.cultureInfo_0);
    }

    [SpecialName]
    internal static UnmanagedMemoryStream smethod_1()
    {
      // ISSUE: reference to a compiler-generated field
      return Class5.ResourceManager_0.GetStream("fast", Class5.cultureInfo_0);
    }
  }
}
