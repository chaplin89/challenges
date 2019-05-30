// Decompiled with JetBrains decompiler
// Type: ns0.GForm0
// Assembly: PunchCardReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DB955359-D25E-4260-9165-ACCDE21785B9
// Assembly location: C:\Users\Marco\Desktop\ESET CrackMe_2\de4dot\PunchCardReader-cleaned.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
    public class GForm0 : Form
    {
        private GClass3 gclass3_0;
        protected volatile bool bool_0;
        private IContainer icontainer_0;
        private OpenFileDialog openFileDialog_0;
        private Button button_0;

        public GForm0()
        {
            this.method_3();
        }

        [GAttribute0("9C71FD9F-5147-4F34-B3C3-EFE37A950FEC")]
        protected void method_0()
        {
            try
            {
                Class3.manualResetEvent_2.WaitOne();
                label_14:
                int num1 = -1469891950;
                while (true)
                {
                    int num2 = -1469891952;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            goto label_14;
                        case 1:
                            goto label_16;
                        case 2:
                            int num3;
                            int num4;
                            if (this.bool_0)
                            {
                                int num5 = -1469891949;
                                num4 = -1469891949;
                                num3 = num5;
                            }
                            else
                            {
                                num3 = -1469891951;
                                num4 = -1469891951;
                            }
                            num1 = num3;
                            continue;
                        case 3:
                            if (this.IsHandleCreated)
                                goto case 4;
                            else
                                goto label_13;
                        case 4:
                            int num6;
                            int num7;
                            if (!this.InvokeRequired)
                            {
                                int num5 = -1469891951;
                                num7 = -1469891951;
                                num6 = num5;
                            }
                            else
                            {
                                num6 = -1469891947;
                                num7 = -1469891947;
                            }
                            num1 = num6;
                            continue;
                        case 5:
                            this.BeginInvoke(new Action(() => Application.Exit()));
                            num1 = -1469891946;
                            continue;
                        case 6:
                            goto label_15;
                        default:
                            goto label_7;
                    }
                }
                label_13:
                return;
                label_16:
                return;
                label_7:
                return;
                label_15:;
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnLoad(EventArgs eventArgs_0)
        {
            base.OnLoad(eventArgs_0);
            this.gclass3_0 = new GClass3(this);
            new Thread(new ThreadStart(this.method_0)).Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs formClosingEventArgs_0)
        {
            try
            {
                this.bool_0 = true;
                label_7:
                int num1 = 598558055;
                while (true)
                {
                    int num2 = 598558053;
                    switch (num1 ^ num2)
                    {
                        case 1:
                            this.gclass3_0.method_5();
                            num1 = 598558053;
                            continue;
                        case 2:
                            int num3;
                            int num4;
                            if (this.gclass3_0 == null)
                            {
                                int num5 = 598558053;
                                num4 = 598558053;
                                num3 = num5;
                            }
                            else
                            {
                                num3 = 598558052;
                                num4 = 598558052;
                            }
                            num1 = num3;
                            continue;
                        case 3:
                            goto label_7;
                        default:
                            goto label_9;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            label_9:
            base.OnFormClosing(formClosingEventArgs_0);
        }

        class Class0
        {
            public GClass0.GEnum0 genum0_0;
            public object object_0;
            public GForm0 gform0_0;
            public void A_void()
            {
                this.gform0_0.method_1(this.genum0_0, this.object_0);
            }
        }

        private void method_1(GClass0.GEnum0 genum0_0, object object_0)
        {
            GClass0.GEnum0 genum0 = GClass0.GEnum0.const_0;
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GForm0.Class0 class0 = new GForm0.Class0();
            // ISSUE: reference to a compiler-generated field
            class0.genum0_0 = genum0_0;
            // ISSUE: reference to a compiler-generated field
            class0.object_0 = object_0;
            // ISSUE: reference to a compiler-generated field
            class0.gform0_0 = this;
            try
            {
                if (this.IsHandleCreated)
                    goto label_12;
                label_4:
                int num1 = 222995550;
                label_8:
                while (true)
                {
                    int num2 = 222995551;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            num1 = 222995544;
                            continue;
                        case 1:
                            goto label_15;
                        case 2:
                            switch (genum0)
                            {
                                case GClass0.GEnum0.const_1:
                                    goto label_2;
                                case GClass0.GEnum0.const_2:
                                    goto label_3;
                                default:
                                    num1 = 222995544;
                                    continue;
                            }
                        case 3:
                            goto label_4;
                        case 4:
                            goto label_12;
                        case 5:
                            goto label_10;
                        case 6:
                            label_3:
                            int num3 = (int)MessageBox.Show("Verification failed ...", "Verification error!");
                            this.button_0.Enabled = true;
                            num1 = 222995544;
                            continue;
                        case 7:
                            goto label_14;
                        case 8:
                            goto label_13;
                        case 9:
                            label_2:
                            this.gclass3_0.method_0();
                            int num4 = (int)MessageBox.Show("Verification passed ...", "Verification info");
                            this.button_0.Enabled = true;
                            num1 = 222995551;
                            continue;
                        default:
                            goto label_9;
                    }
                }
                label_13:
                return;
                label_9:
                return;
                label_15:
                return;
                label_14:
                return;
                label_10:
                // ISSUE: reference to a compiler-generated field
                genum0 = class0.genum0_0;
                num1 = 222995549;
                goto label_8;
                label_12:
                if (this.InvokeRequired)
                {
                    // ISSUE: reference to a compiler-generated method
                    this.BeginInvoke((Delegate)new MethodInvoker(class0.A_void));
                    num1 = 222995543;
                    goto label_8;
                }
                else
                    goto label_10;
            }
            catch (Exception ex)
            {
            }
        }

        private void method_2(object sender, EventArgs e)
        {
            this.button_0.Enabled = false;
            this.gclass3_0.method_2(new GClass0.GDelegate0(this.method_1));
        }

        protected override void Dispose(bool bool_1)
        {
            if (!bool_1)
                goto label_10;
            label_6:
            int num1 = 1684991464;
            label_8:
            while (true)
            {
                int num2 = 1684991468;
                switch (num1 ^ num2)
                {
                    case 0:
                        this.icontainer_0.Dispose();
                        num1 = 1684991471;
                        continue;
                    case 1:
                        goto label_9;
                    case 2:
                        goto label_6;
                    case 3:
                        goto label_10;
                    case 4:
                        int num3;
                        int num4;
                        if (this.icontainer_0 == null)
                        {
                            int num5 = 1684991471;
                            num4 = 1684991471;
                            num3 = num5;
                        }
                        else
                        {
                            num3 = 1684991468;
                            num4 = 1684991468;
                        }
                        num1 = num3;
                        continue;
                    default:
                        goto label_1;
                }
            }
            label_1:
            return;
            label_9:
            return;
            label_10:
            base.Dispose(bool_1);
            num1 = 1684991469;
            goto label_8;
        }

        private void method_3()
        {
            this.openFileDialog_0 = new OpenFileDialog();
            label_18:
            int num1 = -1730499695;
            while (true)
            {
                int num2 = -1730499689;
                switch (num1 ^ num2)
                {
                    case 0:
                        this.openFileDialog_0.FileName = "openFileDialog1";
                        num1 = -1730499706;
                        continue;
                    case 2:
                        this.AutoScaleDimensions = new SizeF(6f, 13f);
                        num1 = -1730499693;
                        continue;
                    case 3:
                        this.button_0.Location = new Point(22, 17);
                        num1 = -1730499682;
                        continue;
                    case 4:
                        this.AutoScaleMode = AutoScaleMode.Font;
                        this.AutoSize = true;
                        num1 = -1730499694;
                        continue;
                    case 5:
                        this.ClientSize = new Size(184, 52);
                        num1 = -1730499681;
                        continue;
                    case 6:
                        this.button_0 = new Button();
                        num1 = -1730499696;
                        continue;
                    case 7:
                        this.SuspendLayout();
                        num1 = -1730499689;
                        continue;
                    case 8:
                        this.Controls.Add((Control)this.button_0);
                        this.MaximizeBox = false;
                        this.MaximumSize = new Size(200, 90);
                        this.MinimizeBox = false;
                        num1 = -1730499688;
                        continue;
                    case 9:
                        this.button_0.Name = "read_punch_card_button";
                        num1 = -1730499685;
                        continue;
                    case 10:
                        this.button_0.Click += new EventHandler(this.method_2);
                        num1 = -1730499691;
                        continue;
                    case 11:
                        this.ShowIcon = false;
                        num1 = -1730499705;
                        continue;
                    case 12:
                        this.button_0.Size = new Size(140, 23);
                        this.button_0.TabIndex = 0;
                        this.button_0.Text = "Read punch cards";
                        this.button_0.UseVisualStyleBackColor = true;
                        num1 = -1730499683;
                        continue;
                    case 13:
                        goto label_18;
                    case 14:
                        this.Name = "ReaderForm";
                        num1 = -1730499684;
                        continue;
                    case 15:
                        this.MinimumSize = new Size(200, 90);
                        num1 = -1730499687;
                        continue;
                    case 16:
                        this.Text = "Punch card reader";
                        num1 = -1730499690;
                        continue;
                    case 17:
                        this.openFileDialog_0.Title = "Load puncher card";
                        num1 = -1730499692;
                        continue;
                    default:
                        goto label_19;
                }
            }
            label_19:
            this.ResumeLayout(false);
        }
    }
}
