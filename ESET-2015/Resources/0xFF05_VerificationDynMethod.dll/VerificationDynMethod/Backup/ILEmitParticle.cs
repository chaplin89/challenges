// Decompiled with JetBrains decompiler
// Type: IlEmitHelp.ILEmitParticle
// Assembly: VerificationDynMethod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F97A5217-C1CC-403C-955F-4D4683896AEC
// Assembly location: C:\Users\marco.fornaro\Desktop\PunchCardReader\VerificationDynMethod.dll

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
