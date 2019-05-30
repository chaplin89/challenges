using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PuncherMachine
{
    public class GForm0 : Form
    {
        private IContainer icontainer_0;
        private OpenFileDialog openFileDialog_0;
        private Button button_0;
        private PictureBox loadedBitmap;
        private TextBox textBox_0;
        private Button punchIt;
        private Panel panel_0;
        private Label label_0;
        private TextBox calibCode2;
        private TextBox calibCode1;
        private Button calibrate;
        private Label label_1;
        private Panel panel_1;
        private PictureBox pictureBox_1;
        private GClass5 gclass5_0;
        protected volatile bool bool_0;

        public GForm0()
        {
            this.method_0();
        }

        protected override void Dispose(bool bool_1)
        {
            if (bool_1 && this.icontainer_0 != null)
                this.icontainer_0.Dispose();
            else
                goto label_5;
            label_2:
            int num1 = 342407038;
            label_3:
            int num2 = 342407036;
            switch (num1 ^ num2)
            {
                case 0:
                    goto label_2;
                case 1:
                    return;
                case 2:
                    break;
                default:
                    return;
            }
            label_5:
            base.Dispose(bool_1);
            num1 = 342407037;
            goto label_3;
        }

        private void method_0()
        {
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
            this.openFileDialog_0 = new OpenFileDialog();
            label_72:
            int num1 = -1086550179;
            while (true)
            {
                int num2 = -1086550184;
                switch (num1 ^ num2)
                {
                    case 0:
                        this.textBox_0.Visible = false;
                        this.punchIt.Location = new Point(320, 645);
                        this.punchIt.Name = "punchItButton";
                        num1 = -1086550198;
                        continue;
                    case 1:
                        this.panel_0.PerformLayout();
                        num1 = -1086550173;
                        continue;
                    case 2:
                        this.AutoScaleDimensions = new SizeF(6f, 13f);
                        this.AutoScaleMode = AutoScaleMode.Font;
                        num1 = -1086550156;
                        continue;
                    case 3:
                        this.textBox_0.Multiline = true;
                        this.textBox_0.Name = "dataToPunchTextBox";
                        this.textBox_0.Size = new Size(592, 167);
                        num1 = -1086550180;
                        continue;
                    case 4:
                        this.textBox_0.TabIndex = 3;
                        num1 = -1086550184;
                        continue;
                    case 5:
                        this.button_0 = new Button();
                        this.loadedBitmap = new PictureBox();
                        num1 = -1086550177;
                        continue;
                    case 6:
                        this.label_0.Size = new Size(92, 13);
                        num1 = -1086550174;
                        continue;
                    case 7:
                        this.textBox_0 = new TextBox();
                        num1 = -1086550162;
                        continue;
                    case 8:
                        this.panel_0.Controls.Add((Control)this.calibCode2);
                        num1 = -1086550245;
                        continue;
                    case 9:
                        this.calibrate.UseVisualStyleBackColor = true;
                        num1 = -1086550205;
                        continue;
                    case 10:
                        this.pictureBox_1.TabIndex = 2;
                        this.pictureBox_1.TabStop = false;
                        num1 = -1086550182;
                        continue;
                    case 12:
                        this.panel_0 = new Panel();
                        this.calibrate = new Button();
                        this.label_1 = new Label();
                        this.label_0 = new Label();
                        num1 = -1086550206;
                        continue;
                    case 13:
                        this.panel_0.ResumeLayout(false);
                        num1 = -1086550183;
                        continue;
                    case 14:
                        this.button_0.UseVisualStyleBackColor = true;
                        num1 = -1086550148;
                        continue;
                    case 15:
                        this.panel_0.TabIndex = 5;
                        this.panel_0.Visible = false;
                        num1 = -1086550207;
                        continue;
                    case 16:
                        this.calibrate.TabIndex = 4;
                        this.calibrate.Text = "Calibrate!";
                        num1 = -1086550191;
                        continue;
                    case 17:
                        this.button_0.Name = "load_punch_card_button";
                        num1 = -1086550149;
                        continue;
                    case 18:
                        this.punchIt.Size = new Size(75, 23);
                        this.punchIt.TabIndex = 4;
                        this.punchIt.Text = "Punch it!";
                        this.punchIt.UseVisualStyleBackColor = true;
                        this.punchIt.Visible = false;
                        num1 = -1086550170;
                        continue;
                    case 19:
                        this.calibrate.Size = new Size(75, 23);
                        num1 = -1086550200;
                        continue;
                    case 20:
                        this.label_1.Size = new Size(92, 13);
                        num1 = -1086550164;
                        continue;
                    case 21:
                        this.calibCode2.TabIndex = 1;
                        num1 = -1086550176;
                        continue;
                    case 22:
                        panel_1.Controls.Add(button_0);
                        panel_1.Controls.Add(pictureBox_1);
                        num1 = -1086550172;
                        continue;
                    case 23:
                        ((ISupportInitialize)this.pictureBox_1).BeginInit();
                        this.SuspendLayout();
                        this.openFileDialog_0.FileName = "openFileDialog1";
                        this.openFileDialog_0.Title = "Load puncher card";
                        this.button_0.Location = new Point(449, 440);
                        num1 = -1086550199;
                        continue;
                    case 24:
                        this.panel_1.TabIndex = 6;
                        num1 = -1086550157;
                        continue;
                    case 25:
                        this.calibrate.Location = new Point(492, 38);
                        num1 = -1086550152;
                        continue;
                    case 26:
                        this.calibCode2 = new TextBox();
                        this.calibCode1 = new TextBox();
                        num1 = -1086550243;
                        continue;
                    case 27:
                        this.calibrate.Click += new EventHandler(this.Calibrate);
                        num1 = -1086550246;
                        continue;
                    case 28:
                        this.loadedBitmap.Location = new Point(840, 8);
                        num1 = -1086550171;
                        continue;
                    case 29:
                        this.panel_1.Size = new Size(672, 556);
                        num1 = -1086550208;
                        continue;
                    case 30:
                        this.label_0.Location = new Point(3, 5);
                        num1 = -1086550145;
                        continue;
                    case 31:
                        this.Controls.Add((Control)this.loadedBitmap);
                        num1 = -1086550244;
                        continue;
                    case 32:
                        this.calibrate.Name = "calibrate_button";
                        num1 = -1086550197;
                        continue;
                    case 33:
                        goto label_72;
                    case 34:
                        this.Controls.Add((Control)this.panel_1);
                        num1 = -1086550166;
                        continue;
                    case 35:
                        this.button_0.Size = new Size(117, 23);
                        this.button_0.TabIndex = 1;
                        num1 = -1086550242;
                        continue;
                    case 36:
                        button_0.Click += new EventHandler(method_3);
                        num1 = -1086550160;
                        continue;
                    case 37:
                        this.label_0.Text = "Calibration code 1";
                        num1 = -1086550159;
                        continue;
                    case 38:
                        this.panel_1.SuspendLayout();
                        num1 = -1086550193;
                        continue;
                    case 39:
                        this.label_0.Name = "label1";
                        num1 = -1086550178;
                        continue;
                    case 40:
                        this.loadedBitmap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                        num1 = -1086550204;
                        continue;
                    case 41:
                        this.calibCode2.Location = new Point(6, 59);
                        num1 = -1086550155;
                        continue;
                    case 42:
                        this.loadedBitmap.TabIndex = 2;
                        this.loadedBitmap.TabStop = false;
                        this.loadedBitmap.Visible = false;
                        this.textBox_0.Location = new Point(840, 450);
                        num1 = -1086550181;
                        continue;
                    case 43:
                        this.pictureBox_1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
                        this.pictureBox_1.Location = new Point(0, 0);
                        this.pictureBox_1.Name = "pictureBox1";
                        this.pictureBox_1.Size = new Size(606, 476);
                        num1 = -1086550190;
                        continue;
                    case 44:
                        this.AutoSize = true;
                        this.ClientSize = new Size(884, 675);
                        this.Controls.Add((Control)this.panel_0);
                        num1 = -1086550150;
                        continue;
                    case 45:
                        this.calibCode2.Name = "calibrationcode2";
                        num1 = -1086550154;
                        continue;
                    case 46:
                        this.calibCode2.Size = new Size(480, 20);
                        num1 = -1086550195;
                        continue;
                    case 47:
                        this.loadedBitmap.Size = new Size(600, 172);
                        num1 = -1086550158;
                        continue;
                    case 48:
                        ((ISupportInitialize)this.loadedBitmap).EndInit();
                        num1 = -1086550187;
                        continue;
                    case 49:
                        this.Controls.Add((Control)this.textBox_0);
                        num1 = -1086550201;
                        continue;
                    case 50:
                        this.Controls.Add((Control)this.punchIt);
                        num1 = -1086550167;
                        continue;
                    case 51:
                        this.panel_0.Location = new Point(840, 299);
                        this.panel_0.Name = "calibrate_panel";
                        this.panel_0.Size = new Size(592, 82);
                        num1 = -1086550185;
                        continue;
                    case 52:
                        this.label_1.TabIndex = 3;
                        this.label_1.Text = "Calibration code 2";
                        this.label_0.AutoSize = true;
                        num1 = -1086550202;
                        continue;
                    case 53:
                        this.pictureBox_1 = new PictureBox();
                        ((ISupportInitialize)this.loadedBitmap).BeginInit();
                        this.panel_0.SuspendLayout();
                        num1 = -1086550146;
                        continue;
                    case 54:
                        this.punchIt = new Button();
                        num1 = -1086550188;
                        continue;
                    case 55:
                        this.MinimizeBox = false;
                        num1 = -1086550247;
                        continue;
                    case 56:
                        this.calibCode1.Location = new Point(6, 21);
                        num1 = -1086550175;
                        continue;
                    case 57:
                        this.calibCode1.Name = "calibrationcode1";
                        this.calibCode1.Size = new Size(480, 20);
                        this.calibCode1.TabIndex = 0;
                        num1 = -1086550194;
                        continue;
                    case 58:
                        this.label_0.TabIndex = 2;
                        num1 = -1086550147;
                        continue;
                    case 59:
                        this.panel_1.ResumeLayout(false);
                        ((ISupportInitialize)this.pictureBox_1).EndInit();
                        num1 = -1086550189;
                        continue;
                    case 60:
                        this.panel_1.Location = new Point(3, 8);
                        this.panel_1.Name = "load_punch_card_panel";
                        num1 = -1086550203;
                        continue;
                    case 61:
                        this.loadedBitmap.Name = "punch_card_pictureBox";
                        num1 = -1086550153;
                        continue;
                    case 62:
                        this.punchIt.Click += new EventHandler(this.PunchData);
                        this.panel_0.Controls.Add((Control)this.calibrate);
                        num1 = -1086550241;
                        continue;
                    case 63:
                        this.Name = "PuncherMachineForm";
                        this.ShowIcon = false;
                        this.Text = "Puncher machine";
                        num1 = -1086550168;
                        continue;
                    case 64:
                        this.label_1.Location = new Point(3, 43);
                        this.label_1.Name = "label2";
                        num1 = -1086550196;
                        continue;
                    case 65:
                        this.MinimumSize = new Size(270, 369);
                        num1 = -1086550169;
                        continue;
                    case 66:
                        this.label_1.AutoSize = true;
                        num1 = -1086550248;
                        continue;
                    case 67:
                        this.panel_0.Controls.Add(calibCode1);
                        num1 = -1086550165;
                        continue;
                    case 68:
                        this.MaximizeBox = false;
                        this.MaximumSize = new Size(900, 800);
                        num1 = -1086550161;
                        continue;
                    case 69:
                        this.panel_1 = new Panel();
                        num1 = -1086550163;
                        continue;
                    case 70:
                        this.button_0.Text = "Load punch card";
                        num1 = -1086550186;
                        continue;
                    case 71:
                        this.panel_0.Controls.Add((Control)this.label_1);
                        this.panel_0.Controls.Add((Control)this.label_0);
                        num1 = -1086550192;
                        continue;
                    default:
                        goto label_73;
                }
            }
            label_73:
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        [GAttribute0("2EB0079C-BD4E-47D5-9CF5-3B5EA72FC31E")]
        protected void method_1()
        {
            try
            {
                Class0.manualResetEvent_2.WaitOne();
                label_13:
                int num1 = 1557544153;
                while (true)
                {
                    int num2 = 1557544159;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            if (this.InvokeRequired)
                            {
                                this.BeginInvoke(new Action(() => Application.Exit()));
                                num1 = 1557544155;
                                continue;
                            }
                            goto label_15;
                        case 1:
                            goto label_14;
                        case 2:
                            goto label_12;
                        case 3:
                            goto label_13;
                        case 4:
                            goto label_17;
                        case 5:
                            int num3;
                            int num4;
                            if (this.IsHandleCreated)
                            {
                                int num5 = 1557544159;
                                num4 = 1557544159;
                                num3 = num5;
                            }
                            else
                            {
                                num3 = 1557544157;
                                num4 = 1557544157;
                            }
                            num1 = num3;
                            continue;
                        case 6:
                            int num6;
                            int num7;
                            if (!this.bool_0)
                            {
                                int num5 = 1557544158;
                                num7 = 1557544158;
                                num6 = num5;
                            }
                            else
                            {
                                num6 = 1557544154;
                                num7 = 1557544154;
                            }
                            num1 = num6;
                            continue;
                        default:
                            goto label_18;
                    }
                }
                label_15:
                return;
                label_18:
                return;
                label_14:
                return;
                label_12:
                return;
                label_17:;
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnLoad(EventArgs eventArgs_0)
        {
            this.panel_0.Location = new Point(57, 449);
            label_12:
            int num1 = 1346910991;
            while (true)
            {
                int num2 = 1346910990;
                switch (num1 ^ num2)
                {
                    case 0:
                        this.textBox_0.Location = new Point(0, 260);
                        num1 = 1346910980;
                        continue;
                    case 1:
                        this.panel_1.Location = new Point(0, 0);
                        num1 = 1346910986;
                        continue;
                    case 2:
                        new Thread(new ThreadStart(this.method_1)).Start();
                        num1 = 1346910982;
                        continue;
                    case 3:
                        this.panel_0.Location = new Point(10, 310);
                        num1 = 1346910990;
                        continue;
                    case 4:
                        this.MaximumSize = new Size(600, 500);
                        this.MinimumSize = new Size(600, 500);
                        num1 = 1346910984;
                        continue;
                    case 5:
                        this.loadedBitmap.Size = new Size(600, 259);
                        num1 = 1346910989;
                        continue;
                    case 6:
                        this.loadedBitmap.Location = new Point(0, 0);
                        num1 = 1346910987;
                        continue;
                    case 7:
                        this.gclass5_0 = new GClass5(this);
                        num1 = 1346910988;
                        continue;
                    case 8:
                        goto label_11;
                    case 9:
                        goto label_12;
                    case 10:
                        this.punchIt.Location = new Point(260, 430);
                        base.OnLoad(eventArgs_0);
                        num1 = 1346910985;
                        continue;
                    default:
                        goto label_13;
                }
            }
            label_13:
            return;
            label_11:;
        }

        protected override void OnFormClosing(FormClosingEventArgs formClosingEventArgs_0)
        {
            try
            {
                this.bool_0 = true;
                label_4:
                int num1 = 355395057;
                while (true)
                {
                    int num2 = 355395059;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            goto label_4;
                        case 2:
                            if (this.gclass5_0 != null)
                            {
                                this.gclass5_0.ExitApp();
                                num1 = 355395058;
                                continue;
                            }
                            goto label_6;
                        default:
                            goto label_6;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            label_6:
            base.OnFormClosing(formClosingEventArgs_0);
        }

        public class Class1
        {
            public GClass0.GEnum0 genum0_0;
            public object object_0;
            public GForm0 gform0_0;
            public void method_2()
            {
                this.gform0_0.PunchIt(this.genum0_0, this.object_0);
            }
        }

        private void PunchIt(GClass0.GEnum0 genum0_0, object object_0)
        {
            // ISSUE: object of a compiler-generated type is created
            // ISSUE: variable of a compiler-generated type
            GForm0.Class1 class1 = new GForm0.Class1();
            label_3:
            int num1 = 1111764131;
            while (true)
            {
                int num2 = 1111764130;
                switch (num1 ^ num2)
                {
                    case 1:
                        // ISSUE: reference to a compiler-generated field
                        class1.genum0_0 = genum0_0;
                        num1 = 1111764130;
                        continue;
                    case 2:
                        goto label_3;
                    default:
                        goto label_4;
                }
            }
            label_4:
            // ISSUE: reference to a compiler-generated field
            class1.object_0 = object_0;
            // ISSUE: reference to a compiler-generated field
            class1.gform0_0 = this;
            try
            {
                if (this.IsHandleCreated)
                    goto label_16;
                else
                    goto label_8;
                label_6:
                // ISSUE: reference to a compiler-generated field
                int num2 = (int)MessageBox.Show(((Exception)class1.object_0).Message, "Punch error!");
                this.punchIt.Enabled = true;
                int num3 = 1111764139;
                goto label_11;
                label_7:
                punchIt.Enabled = true;
                num3 = 1111764139;
                goto label_11;
                label_8:
                num3 = 1111764138;
                goto label_11;
                label_10:
                // ISSUE: reference to a compiler-generated field
                this.loadedBitmap.Image = (Image)class1.object_0;
                num3 = 1111764131;
                label_11:
                while (true)
                {
                    int num4 = 1111764130;
                    switch (num3 ^ num4)
                    {
                        case 0:
                            goto label_10;
                        case 1:
                            this.loadedBitmap.Refresh();
                            num3 = 1111764139;
                            continue;
                        case 2:
                            goto label_13;
                        case 3:
                            goto label_6;
                        case 4:
                            goto label_16;
                        case 5:
                            goto label_8;
                        case 6:
                            goto label_7;
                        case 7:
                            goto label_19;
                        case 8:
                            goto label_18;
                        case 9:
                            goto label_17;
                        default:
                            goto label_14;
                    }
                }
                label_17:
                return;
                label_14:
                return;
                label_19:
                return;
                label_18:
                return;
                label_13:
                // ISSUE: reference to a compiler-generated field
                switch (class1.genum0_0)
                {
                    case GClass0.GEnum0.const_0:
                        goto label_10;
                    case GClass0.GEnum0.const_1:
                        goto label_7;
                    case GClass0.GEnum0.PunchError:
                        goto label_6;
                    default:
                        num3 = 1111764139;
                        goto label_11;
                }
                label_16:
                if (this.InvokeRequired)
                {
                    Invoke(new MethodInvoker(class1.method_2));
                    num3 = 1111764133;
                    goto label_11;
                }
                else
                    goto label_13;
            }
            catch (Exception ex)
            {
            }
        }

        private void method_3(object sender, EventArgs e)
        {
            if (openFileDialog_0.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                gclass5_0.method_0(openFileDialog_0.FileName, new GClass0.GDelegate0(PunchIt));
                loadedBitmap.Load(openFileDialog_0.FileName);
                panel_1.Visible = false;
                label_6:
                int num1 = 257145980;
                while (true)
                {
                    int num2 = 257145983;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            goto label_6;
                        case 1:
                            goto label_10;
                        case 2:
                            this.loadedBitmap.Visible = true;
                            num1 = 257145982;
                            continue;
                        case 3:
                            this.panel_0.Visible = true;
                            num1 = 257145981;
                            continue;
                        default:
                            goto label_7;
                    }
                }
                label_7:
                return;
                label_10:;
            }
            catch (GException0 ex)
            {
                label_12:
                int num1 = 257145981;
                while (true)
                {
                    int num2 = 257145983;
                    switch (num1 ^ num2)
                    {
                        case 0:
                            goto label_12;
                        case 1:
                            goto label_5;
                        case 2:
                            int num3 = (int)MessageBox.Show(ex.Message, "Error!");
                            num1 = 257145982;
                            continue;
                        default:
                            goto label_14;
                    }
                }
                label_14:
                return;
                label_5:;
            }
        }

        private void PunchData(object sender, EventArgs e)
        {
            try
            {
                punchIt.Enabled = false;
                gclass5_0.ProcessText(textBox_0.Text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
                return;
            }
            catch (GException0 ex)
            {
            }
        }

        private void Calibrate(object sender, EventArgs e)
        {
            if (gclass5_0.method_1().GenerateHashtable1(calibCode1.Text, calibCode2.Text))
            {
                loadedBitmap.Visible = true;
                pictureBox_1.Visible = false;
                button_0.Visible = false;
            }
            else
            {
                MessageBox.Show("Calibration error!", "Error!");
                return;
            }
            this.panel_0.Visible = false;
            this.punchIt.Visible = true;
            this.textBox_0.Visible = true;
            this.gclass5_0.WriteShit();
        }
    }
}
