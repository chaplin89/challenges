﻿// Decompiled with JetBrains decompiler
// Type: IlEmitHelp.IlParticlesEmitor
// Assembly: CalibrationDynMethod, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 22B0C867-D633-4DA5-B05B-C988049911F2
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\Resources\0xFF04_CalibrationDynMethod.dll\CalibrationDynMethod.dll

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace IlEmitHelp
{
  public class IlParticlesEmitor
  {
    protected ILGenerator ilGen;
    protected List<ILEmitParticle> iLParticles;

    public IlParticlesEmitor(ILGenerator ilGen)
    {
      this.ilGen = ilGen;
      this.iLParticles = new List<ILEmitParticle>();
    }

    public void addILParticle(ILEmitParticle iLEmitParticle)
    {
      this.iLParticles.Add(iLEmitParticle);
    }

    public void emitParticles()
    {
      this.iLParticles.Sort();
      foreach (ILEmitParticle ilEmitParticle in this.iLParticles)
      {
        if (ilEmitParticle.ilSyntaxElement is OpCode)
        {
          if (ilEmitParticle.arg != null)
          {
            if (ilEmitParticle.arg is Label)
            {
              this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement, (Label) ilEmitParticle.arg);
            }
            else
            {
              switch (((OpCode) ilEmitParticle.ilSyntaxElement).OperandType)
              {
                case OperandType.InlineString:
                  this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement, (string) ilEmitParticle.arg);
                  continue;
                case OperandType.ShortInlineI:
                  this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement, (byte) ilEmitParticle.arg);
                  continue;
                case OperandType.ShortInlineR:
                  this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement, (float) ilEmitParticle.arg);
                  continue;
                case OperandType.InlineI:
                  this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement, (int) ilEmitParticle.arg);
                  continue;
                case OperandType.InlineI8:
                  this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement, (long) ilEmitParticle.arg);
                  continue;
                case OperandType.InlineR:
                  this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement, (float) ilEmitParticle.arg);
                  continue;
                default:
                  if (ilEmitParticle.arg is byte)
                  {
                    this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement, (byte) ilEmitParticle.arg);
                    continue;
                  }
                  if (ilEmitParticle.arg is int)
                  {
                    this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement, (int) ilEmitParticle.arg);
                    continue;
                  }
                  if (!(ilEmitParticle.arg is MethodInfo))
                    throw new Exception("Invalid argument");
                  this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement, (MethodInfo) ilEmitParticle.arg);
                  continue;
              }
            }
          }
          else
            this.ilGen.Emit((OpCode) ilEmitParticle.ilSyntaxElement);
        }
        else if (ilEmitParticle.ilSyntaxElement is Label)
          this.ilGen.MarkLabel((Label) ilEmitParticle.ilSyntaxElement);
      }
    }
  }
}
