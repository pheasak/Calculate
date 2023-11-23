namespace Caculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbselected = new Label();
            cb1 = new ComboBox();
            lbNum = new Label();
            lbop = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnclear = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            lbhex = new Label();
            lbdec = new Label();
            lboct = new Label();
            lbbin = new Label();
            labelequal = new Label();
            rbBin = new RadioButton();
            rbOct = new RadioButton();
            rbDec = new RadioButton();
            rbHex = new RadioButton();
            labelnum = new Label();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnE = new Button();
            btnF = new Button();
            button21 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            button34 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            button38 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            button42 = new Button();
            btn1 = new Button();
            button44 = new Button();
            btn0 = new Button();
            button46 = new Button();
            button47 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbselected
            // 
            lbselected.AutoSize = true;
            lbselected.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbselected.Location = new Point(3, -1);
            lbselected.Name = "lbselected";
            lbselected.Size = new Size(170, 50);
            lbselected.TabIndex = 31;
            lbselected.Text = "Standard";
            // 
            // cb1
            // 
            cb1.AutoCompleteCustomSource.AddRange(new string[] { "Standard" });
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "Standard", "Binary" });
            cb1.Location = new Point(492, 12);
            cb1.Name = "cb1";
            cb1.Size = new Size(150, 28);
            cb1.TabIndex = 33;
            cb1.SelectedIndexChanged += cb1_SelectedIndexChanged;
            // 
            // lbNum
            // 
            lbNum.AutoSize = true;
            lbNum.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lbNum.Location = new Point(3, 162);
            lbNum.Name = "lbNum";
            lbNum.RightToLeft = RightToLeft.No;
            lbNum.Size = new Size(88, 106);
            lbNum.TabIndex = 184;
            lbNum.Text = "0";
            // 
            // lbop
            // 
            lbop.AutoSize = true;
            lbop.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbop.ForeColor = Color.Silver;
            lbop.Location = new Point(41, 88);
            lbop.Name = "lbop";
            lbop.Size = new Size(0, 54);
            lbop.TabIndex = 183;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(468, 289);
            label6.Name = "label6";
            label6.Size = new Size(47, 31);
            label6.TabIndex = 182;
            label6.Text = "MS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ScrollBar;
            label5.Location = new Point(561, 289);
            label5.Name = "label5";
            label5.Size = new Size(35, 31);
            label5.TabIndex = 181;
            label5.Text = "M";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(360, 289);
            label4.Name = "label4";
            label4.Size = new Size(44, 31);
            label4.TabIndex = 180;
            label4.Text = "M-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ScrollBar;
            label3.Location = new Point(148, 289);
            label3.Name = "label3";
            label3.Size = new Size(49, 31);
            label3.TabIndex = 179;
            label3.Text = "MR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(260, 289);
            label2.Name = "label2";
            label2.Size = new Size(51, 31);
            label2.TabIndex = 178;
            label2.Text = "M+";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ScrollBar;
            label1.Location = new Point(36, 289);
            label1.Name = "label1";
            label1.Size = new Size(49, 31);
            label1.TabIndex = 177;
            label1.Text = "MC";
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Black;
            btnclear.FlatStyle = FlatStyle.System;
            btnclear.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnclear.Location = new Point(329, 330);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(157, 52);
            btnclear.TabIndex = 176;
            btnclear.Text = "C";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btncl;
            // 
            // button22
            // 
            button22.BackColor = Color.Black;
            button22.FlatStyle = FlatStyle.System;
            button22.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button22.Location = new Point(166, 330);
            button22.Name = "button22";
            button22.Size = new Size(157, 52);
            button22.TabIndex = 175;
            button22.Text = "CE";
            button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(64, 64, 64);
            button23.FlatStyle = FlatStyle.System;
            button23.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button23.Location = new Point(492, 330);
            button23.Name = "button23";
            button23.Size = new Size(157, 52);
            button23.TabIndex = 174;
            button23.Text = "<=";
            button23.UseVisualStyleBackColor = false;
            button23.Click += btncl11;
            // 
            // button24
            // 
            button24.BackColor = Color.Black;
            button24.FlatStyle = FlatStyle.System;
            button24.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button24.Location = new Point(3, 330);
            button24.Name = "button24";
            button24.Size = new Size(157, 52);
            button24.TabIndex = 173;
            button24.Text = "%";
            button24.UseVisualStyleBackColor = false;
            button24.Click += button3_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Black;
            button17.FlatStyle = FlatStyle.System;
            button17.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(329, 388);
            button17.Name = "button17";
            button17.Size = new Size(157, 52);
            button17.TabIndex = 172;
            button17.Text = "√x";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button3_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.Black;
            button18.FlatStyle = FlatStyle.System;
            button18.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(166, 388);
            button18.Name = "button18";
            button18.Size = new Size(157, 52);
            button18.TabIndex = 171;
            button18.Text = "x²";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button3_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.Black;
            button19.FlatStyle = FlatStyle.System;
            button19.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button19.Location = new Point(492, 388);
            button19.Name = "button19";
            button19.Size = new Size(157, 52);
            button19.TabIndex = 170;
            button19.Text = "÷";
            button19.UseVisualStyleBackColor = false;
            button19.Click += btnequal;
            // 
            // button20
            // 
            button20.BackColor = Color.Black;
            button20.FlatStyle = FlatStyle.System;
            button20.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button20.Location = new Point(3, 388);
            button20.Name = "button20";
            button20.Size = new Size(157, 52);
            button20.TabIndex = 169;
            button20.Text = "1/x";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button3_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Black;
            button13.FlatStyle = FlatStyle.System;
            button13.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(329, 446);
            button13.Name = "button13";
            button13.Size = new Size(157, 52);
            button13.TabIndex = 168;
            button13.Text = "9";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button3_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.Black;
            button14.FlatStyle = FlatStyle.System;
            button14.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(166, 446);
            button14.Name = "button14";
            button14.Size = new Size(157, 52);
            button14.TabIndex = 167;
            button14.Text = "8";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button3_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.Black;
            button15.FlatStyle = FlatStyle.System;
            button15.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(492, 446);
            button15.Name = "button15";
            button15.Size = new Size(157, 52);
            button15.TabIndex = 166;
            button15.Text = "×";
            button15.UseVisualStyleBackColor = false;
            button15.Click += btnequal;
            // 
            // button16
            // 
            button16.BackColor = Color.Black;
            button16.FlatStyle = FlatStyle.System;
            button16.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(3, 446);
            button16.Name = "button16";
            button16.Size = new Size(157, 52);
            button16.TabIndex = 165;
            button16.Text = "7";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button3_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.FlatStyle = FlatStyle.System;
            button9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(329, 504);
            button9.Name = "button9";
            button9.Size = new Size(157, 52);
            button9.TabIndex = 164;
            button9.Text = "6";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button3_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Black;
            button10.FlatStyle = FlatStyle.System;
            button10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(166, 504);
            button10.Name = "button10";
            button10.Size = new Size(157, 52);
            button10.TabIndex = 163;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button3_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Black;
            button11.FlatStyle = FlatStyle.System;
            button11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(492, 504);
            button11.Name = "button11";
            button11.Size = new Size(157, 52);
            button11.TabIndex = 162;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = false;
            button11.Click += btnequal;
            // 
            // button12
            // 
            button12.BackColor = Color.Black;
            button12.FlatStyle = FlatStyle.System;
            button12.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(3, 504);
            button12.Name = "button12";
            button12.Size = new Size(157, 52);
            button12.TabIndex = 161;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatStyle = FlatStyle.System;
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(329, 562);
            button5.Name = "button5";
            button5.Size = new Size(157, 52);
            button5.TabIndex = 160;
            button5.Text = "3";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.FlatStyle = FlatStyle.System;
            button6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(166, 562);
            button6.Name = "button6";
            button6.Size = new Size(157, 52);
            button6.TabIndex = 159;
            button6.Text = "2";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button3_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.FlatStyle = FlatStyle.System;
            button7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(492, 562);
            button7.Name = "button7";
            button7.Size = new Size(157, 52);
            button7.TabIndex = 158;
            button7.Text = "+";
            button7.UseVisualStyleBackColor = false;
            button7.Click += btnequal;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.FlatStyle = FlatStyle.System;
            button8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(3, 562);
            button8.Name = "button8";
            button8.Size = new Size(157, 52);
            button8.TabIndex = 157;
            button8.Text = "1";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(329, 620);
            button4.Name = "button4";
            button4.Size = new Size(157, 52);
            button4.TabIndex = 156;
            button4.Text = ".";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(166, 620);
            button3.Name = "button3";
            button3.Size = new Size(157, 52);
            button3.TabIndex = 155;
            button3.Text = "0";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(492, 620);
            button2.Name = "button2";
            button2.Size = new Size(157, 52);
            button2.TabIndex = 154;
            button2.Text = "=";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnequal;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 620);
            button1.Name = "button1";
            button1.Size = new Size(157, 52);
            button1.TabIndex = 153;
            button1.Text = "+/-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbhex);
            panel1.Controls.Add(lbdec);
            panel1.Controls.Add(lboct);
            panel1.Controls.Add(lbbin);
            panel1.Controls.Add(labelequal);
            panel1.Controls.Add(rbBin);
            panel1.Controls.Add(rbOct);
            panel1.Controls.Add(rbDec);
            panel1.Controls.Add(rbHex);
            panel1.Controls.Add(labelnum);
            panel1.Controls.Add(btnA);
            panel1.Controls.Add(btnB);
            panel1.Controls.Add(btnC);
            panel1.Controls.Add(btnD);
            panel1.Controls.Add(btnE);
            panel1.Controls.Add(btnF);
            panel1.Controls.Add(button21);
            panel1.Controls.Add(button25);
            panel1.Controls.Add(button26);
            panel1.Controls.Add(button27);
            panel1.Controls.Add(button28);
            panel1.Controls.Add(button29);
            panel1.Controls.Add(button30);
            panel1.Controls.Add(button31);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(button34);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(button38);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(button42);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(button44);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(button46);
            panel1.Controls.Add(button47);
            panel1.Location = new Point(3, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 620);
            panel1.TabIndex = 185;
            // 
            // lbhex
            // 
            lbhex.AutoSize = true;
            lbhex.Location = new Point(69, 20);
            lbhex.Name = "lbhex";
            lbhex.Size = new Size(17, 20);
            lbhex.TabIndex = 210;
            lbhex.Text = "0";
            // 
            // lbdec
            // 
            lbdec.AutoSize = true;
            lbdec.Location = new Point(69, 50);
            lbdec.Name = "lbdec";
            lbdec.Size = new Size(17, 20);
            lbdec.TabIndex = 210;
            lbdec.Text = "0";
            // 
            // lboct
            // 
            lboct.AutoSize = true;
            lboct.Location = new Point(69, 85);
            lboct.Name = "lboct";
            lboct.Size = new Size(17, 20);
            lboct.TabIndex = 210;
            lboct.Text = "0";
            // 
            // lbbin
            // 
            lbbin.AutoSize = true;
            lbbin.Location = new Point(69, 116);
            lbbin.Name = "lbbin";
            lbbin.Size = new Size(17, 20);
            lbbin.TabIndex = 210;
            lbbin.Text = "0";
            // 
            // labelequal
            // 
            labelequal.AutoSize = true;
            labelequal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelequal.Location = new Point(20, 167);
            labelequal.Name = "labelequal";
            labelequal.Size = new Size(0, 28);
            labelequal.TabIndex = 209;
            // 
            // rbBin
            // 
            rbBin.AutoSize = true;
            rbBin.Checked = true;
            rbBin.Location = new Point(3, 113);
            rbBin.Name = "rbBin";
            rbBin.Size = new Size(54, 24);
            rbBin.TabIndex = 208;
            rbBin.TabStop = true;
            rbBin.Text = "BIN";
            rbBin.UseVisualStyleBackColor = true;
            rbBin.CheckedChanged += rbBin_CheckedChanged;
            // 
            // rbOct
            // 
            rbOct.AutoSize = true;
            rbOct.Location = new Point(3, 83);
            rbOct.Name = "rbOct";
            rbOct.Size = new Size(58, 24);
            rbOct.TabIndex = 208;
            rbOct.Text = "OCT";
            rbOct.UseVisualStyleBackColor = true;
            rbOct.CheckedChanged += rbOct_CheckedChanged;
            // 
            // rbDec
            // 
            rbDec.AutoSize = true;
            rbDec.Location = new Point(3, 48);
            rbDec.Name = "rbDec";
            rbDec.Size = new Size(58, 24);
            rbDec.TabIndex = 208;
            rbDec.Text = "DEC";
            rbDec.UseVisualStyleBackColor = true;
            rbDec.CheckedChanged += rbDec_CheckedChanged;
            // 
            // rbHex
            // 
            rbHex.AutoSize = true;
            rbHex.Location = new Point(3, 18);
            rbHex.Name = "rbHex";
            rbHex.Size = new Size(58, 24);
            rbHex.TabIndex = 208;
            rbHex.Text = "HEX";
            rbHex.UseVisualStyleBackColor = true;
            rbHex.CheckedChanged += rbHex_CheckedChanged;
            // 
            // labelnum
            // 
            labelnum.AutoSize = true;
            labelnum.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelnum.Location = new Point(3, 187);
            labelnum.Name = "labelnum";
            labelnum.Size = new Size(67, 81);
            labelnum.TabIndex = 207;
            labelnum.Text = "0";
            // 
            // btnA
            // 
            btnA.BackColor = Color.Black;
            btnA.FlatStyle = FlatStyle.System;
            btnA.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnA.Location = new Point(3, 278);
            btnA.Name = "btnA";
            btnA.Size = new Size(135, 52);
            btnA.TabIndex = 206;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = false;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.BackColor = Color.Black;
            btnB.FlatStyle = FlatStyle.System;
            btnB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnB.Location = new Point(3, 336);
            btnB.Name = "btnB";
            btnB.Size = new Size(135, 52);
            btnB.TabIndex = 205;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = false;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Black;
            btnC.FlatStyle = FlatStyle.System;
            btnC.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnC.Location = new Point(3, 394);
            btnC.Name = "btnC";
            btnC.Size = new Size(135, 52);
            btnC.TabIndex = 204;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.BackColor = Color.Black;
            btnD.FlatStyle = FlatStyle.System;
            btnD.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnD.Location = new Point(3, 452);
            btnD.Name = "btnD";
            btnD.Size = new Size(135, 52);
            btnD.TabIndex = 203;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = false;
            btnD.Click += btnD_Click;
            // 
            // btnE
            // 
            btnE.BackColor = Color.Black;
            btnE.FlatStyle = FlatStyle.System;
            btnE.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnE.Location = new Point(3, 510);
            btnE.Name = "btnE";
            btnE.Size = new Size(135, 52);
            btnE.TabIndex = 202;
            btnE.Text = "E";
            btnE.UseVisualStyleBackColor = false;
            btnE.Click += btnE_Click;
            // 
            // btnF
            // 
            btnF.BackColor = Color.Black;
            btnF.FlatStyle = FlatStyle.System;
            btnF.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnF.Location = new Point(3, 568);
            btnF.Name = "btnF";
            btnF.Size = new Size(135, 52);
            btnF.TabIndex = 201;
            btnF.Text = "F";
            btnF.UseVisualStyleBackColor = false;
            btnF.Click += btnF_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.Black;
            button21.FlatStyle = FlatStyle.System;
            button21.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button21.Location = new Point(278, 278);
            button21.Name = "button21";
            button21.Size = new Size(119, 52);
            button21.TabIndex = 200;
            button21.Text = "»";
            button21.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            button25.BackColor = Color.Black;
            button25.FlatStyle = FlatStyle.System;
            button25.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button25.Location = new Point(403, 278);
            button25.Name = "button25";
            button25.Size = new Size(117, 52);
            button25.TabIndex = 199;
            button25.Text = "CE";
            button25.UseVisualStyleBackColor = false;
            button25.Click += button25_Click;
            // 
            // button26
            // 
            button26.BackColor = Color.FromArgb(64, 64, 64);
            button26.FlatStyle = FlatStyle.System;
            button26.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button26.Location = new Point(526, 278);
            button26.Name = "button26";
            button26.Size = new Size(120, 52);
            button26.TabIndex = 198;
            button26.Text = "<=";
            button26.UseVisualStyleBackColor = false;
            button26.Click += button26_Click;
            // 
            // button27
            // 
            button27.BackColor = Color.Black;
            button27.FlatStyle = FlatStyle.System;
            button27.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button27.Location = new Point(403, 336);
            button27.Name = "button27";
            button27.Size = new Size(117, 52);
            button27.TabIndex = 197;
            button27.Text = "%";
            button27.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            button28.BackColor = Color.Black;
            button28.FlatStyle = FlatStyle.System;
            button28.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button28.Location = new Point(145, 278);
            button28.Name = "button28";
            button28.Size = new Size(127, 52);
            button28.TabIndex = 196;
            button28.Text = "«";
            button28.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            button29.BackColor = Color.Black;
            button29.FlatStyle = FlatStyle.System;
            button29.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button29.Location = new Point(278, 336);
            button29.Name = "button29";
            button29.Size = new Size(119, 52);
            button29.TabIndex = 195;
            button29.Text = ")";
            button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            button30.BackColor = Color.Black;
            button30.FlatStyle = FlatStyle.System;
            button30.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button30.Location = new Point(526, 336);
            button30.Name = "button30";
            button30.Size = new Size(120, 52);
            button30.TabIndex = 194;
            button30.Text = "÷";
            button30.UseVisualStyleBackColor = false;
            button30.Click += button30_Click;
            // 
            // button31
            // 
            button31.BackColor = Color.Black;
            button31.FlatStyle = FlatStyle.System;
            button31.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button31.Location = new Point(145, 336);
            button31.Name = "button31";
            button31.Size = new Size(127, 52);
            button31.TabIndex = 193;
            button31.Text = "(";
            button31.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Black;
            btn9.FlatStyle = FlatStyle.System;
            btn9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(403, 394);
            btn9.Name = "btn9";
            btn9.Size = new Size(117, 52);
            btn9.TabIndex = 192;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Black;
            btn8.FlatStyle = FlatStyle.System;
            btn8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(278, 394);
            btn8.Name = "btn8";
            btn8.Size = new Size(119, 52);
            btn8.TabIndex = 191;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // button34
            // 
            button34.BackColor = Color.Black;
            button34.FlatStyle = FlatStyle.System;
            button34.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button34.Location = new Point(526, 394);
            button34.Name = "button34";
            button34.Size = new Size(120, 52);
            button34.TabIndex = 190;
            button34.Text = "×";
            button34.UseVisualStyleBackColor = false;
            button34.Click += button30_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Black;
            btn7.FlatStyle = FlatStyle.System;
            btn7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(145, 394);
            btn7.Name = "btn7";
            btn7.Size = new Size(127, 52);
            btn7.TabIndex = 189;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Black;
            btn6.FlatStyle = FlatStyle.System;
            btn6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(403, 452);
            btn6.Name = "btn6";
            btn6.Size = new Size(117, 52);
            btn6.TabIndex = 188;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Black;
            btn5.FlatStyle = FlatStyle.System;
            btn5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(278, 452);
            btn5.Name = "btn5";
            btn5.Size = new Size(119, 52);
            btn5.TabIndex = 187;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // button38
            // 
            button38.BackColor = Color.Black;
            button38.FlatStyle = FlatStyle.System;
            button38.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button38.Location = new Point(526, 452);
            button38.Name = "button38";
            button38.Size = new Size(120, 52);
            button38.TabIndex = 186;
            button38.Text = "-";
            button38.UseVisualStyleBackColor = false;
            button38.Click += button30_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Black;
            btn4.FlatStyle = FlatStyle.System;
            btn4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(145, 452);
            btn4.Name = "btn4";
            btn4.Size = new Size(127, 52);
            btn4.TabIndex = 185;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Black;
            btn3.FlatStyle = FlatStyle.System;
            btn3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(403, 510);
            btn3.Name = "btn3";
            btn3.Size = new Size(117, 52);
            btn3.TabIndex = 184;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Black;
            btn2.FlatStyle = FlatStyle.System;
            btn2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(278, 510);
            btn2.Name = "btn2";
            btn2.Size = new Size(119, 52);
            btn2.TabIndex = 183;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // button42
            // 
            button42.BackColor = Color.Black;
            button42.FlatStyle = FlatStyle.System;
            button42.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button42.Location = new Point(526, 510);
            button42.Name = "button42";
            button42.Size = new Size(120, 52);
            button42.TabIndex = 182;
            button42.Text = "+";
            button42.UseVisualStyleBackColor = false;
            button42.Click += button30_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Black;
            btn1.FlatStyle = FlatStyle.System;
            btn1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(145, 510);
            btn1.Name = "btn1";
            btn1.Size = new Size(127, 52);
            btn1.TabIndex = 181;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // button44
            // 
            button44.BackColor = Color.Black;
            button44.FlatStyle = FlatStyle.System;
            button44.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button44.Location = new Point(403, 568);
            button44.Name = "button44";
            button44.Size = new Size(117, 52);
            button44.TabIndex = 180;
            button44.Text = ".";
            button44.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Black;
            btn0.FlatStyle = FlatStyle.System;
            btn0.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(278, 568);
            btn0.Name = "btn0";
            btn0.Size = new Size(119, 52);
            btn0.TabIndex = 179;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += button45_Click;
            // 
            // button46
            // 
            button46.BackColor = Color.Black;
            button46.FlatStyle = FlatStyle.System;
            button46.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button46.ForeColor = Color.White;
            button46.Location = new Point(526, 568);
            button46.Name = "button46";
            button46.Size = new Size(120, 52);
            button46.TabIndex = 178;
            button46.Text = "=";
            button46.UseVisualStyleBackColor = false;
            button46.Click += button30_Click;
            // 
            // button47
            // 
            button47.BackColor = Color.Black;
            button47.FlatStyle = FlatStyle.System;
            button47.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button47.Location = new Point(145, 568);
            button47.Name = "button47";
            button47.Size = new Size(127, 52);
            button47.TabIndex = 177;
            button47.Text = "+/-";
            button47.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(653, 675);
            Controls.Add(panel1);
            Controls.Add(lbNum);
            Controls.Add(lbop);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnclear);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cb1);
            Controls.Add(lbselected);
            ForeColor = SystemColors.Window;
            MaximumSize = new Size(671, 722);
            MinimumSize = new Size(671, 722);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbselected;
        private ComboBox cb1;
        private Label lbNum;
        private Label lbop;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnclear;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Button btnE;
        private Button btnF;
        private Button button21;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button btn9;
        private Button btn8;
        private Button button34;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button button38;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button button42;
        private Button btn1;
        private Button button44;
        private Button btn0;
        private Button button46;
        private Button button47;
        private RadioButton rbBin;
        private RadioButton rbOct;
        private RadioButton rbDec;
        private RadioButton rbHex;
        private Label labelnum;
        private Label labelequal;
        private Label lbdec;
        private Label lboct;
        private Label lbbin;
        private Label lbhex;
    }
}