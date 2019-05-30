// Decompiled with JetBrains decompiler
// Type: IlEmitHelp.ILEmitParticle
// Assembly: CalibrationDynMethod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22B0C867-D633-4DA5-B05B-C988049911F2
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\Resources\0xFF04_CalibrationDynMethod.dll\CalibrationDynMethod.dll

using System;

namespace IlEmitHelp
{
  public class ILEmitParticle : IComparable
  {
    public object ilSyntaxElement;
    public object arg;
    public object seq;

    public ILEmitParticle(object opCode, object arg, object seq)
    {
      this.ilSyntaxElement = opCode;
      this.arg = arg;
      this.seq = seq;
    }

    int IComparable.CompareTo(object x)
    {
      return string.Compare(this.seq as string, ((ILEmitParticle) x).seq as string);
    }
  }
}
