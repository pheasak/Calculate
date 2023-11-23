using System;
using System.Drawing;
using System.Text;

namespace Caculator
{
    public partial class Form1 : Form
    {
        private char op;
        double number1;
        int number2;
        string number3;
        string check = "Bin";
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
        }
        public void Operator(char signal)
        {
            switch (signal)
            {
                case '+': lbNum.Text = (number1 + double.Parse(lbNum.Text)).ToString(); break;
                case '-': lbNum.Text = (number1 - double.Parse(lbNum.Text)).ToString(); break;
                case '×': lbNum.Text = (number1 * double.Parse(lbNum.Text)).ToString(); break;
                case '÷': lbNum.Text = (number1 / double.Parse(lbNum.Text)).ToString(); break;
            }
        }
        public void pnlop(char s)
        {
            switch (s)
            {
                case '+': labelnum.Text = controller.DecimaltoBinary(controller.BinaryToDecimal(number3) + controller.BinaryToDecimal(labelnum.Text)).ToString(); break;
                case '-': labelnum.Text = controller.DecimaltoBinary(controller.BinaryToDecimal(number3) - controller.BinaryToDecimal(labelnum.Text)).ToString(); break;
                case '×': labelnum.Text = controller.DecimaltoBinary(controller.BinaryToDecimal(number3) * controller.BinaryToDecimal(labelnum.Text)).ToString(); break;
                case '÷': labelnum.Text = controller.DecimaltoBinary(controller.BinaryToDecimal(number3) / controller.BinaryToDecimal(labelnum.Text)).ToString(); break;
            }
        }
        public void octop(char s)
        {
            switch (s)
            {
                case '+': labelnum.Text = controller.DecimaltoOctal(controller.OctToDec(int.Parse(number3)) + controller.OctToDec(int.Parse(labelnum.Text))).ToString(); break;
                case '-': labelnum.Text = controller.DecimaltoOctal(controller.OctToDec(int.Parse(number3)) - controller.OctToDec(int.Parse(labelnum.Text))).ToString(); break;
                case '×': labelnum.Text = controller.DecimaltoOctal(controller.OctToDec(int.Parse(number3)) * controller.OctToDec(int.Parse(labelnum.Text))).ToString(); break;
                case '÷': labelnum.Text = controller.DecimaltoOctal(controller.OctToDec(int.Parse(number3)) / controller.OctToDec(int.Parse(labelnum.Text))).ToString(); break;
            }
        }
        public void hexop(char s)
        {
            switch (s)
            {
                case '+': labelnum.Text = controller.DecimaltoHex(controller.HextoDec(number3) + controller.HextoDec(labelnum.Text)).ToString(); break;
                case '-': labelnum.Text = controller.DecimaltoHex(controller.HextoDec(number3) - controller.HextoDec(labelnum.Text)).ToString(); break;
                case '×': labelnum.Text = controller.DecimaltoHex(controller.HextoDec(number3) * controller.HextoDec(labelnum.Text)).ToString(); break;
                case '÷': labelnum.Text = controller.DecimaltoHex(controller.HextoDec(number3) / controller.HextoDec(labelnum.Text)).ToString(); break;
            }
        }
        public void conditionOperator(string ch)
        {
            if (ch.Equals("Bin"))
            {
                pnlop(op);
            }
            else if (ch.Equals("Oct"))
            {
                octop(op);
            }
            else if (ch.Equals("Hex"))
            {
                hexop(op);
            }
        }
        public void binary()
        {
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
        }
        public void oct()
        {
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
        }
        public void dec()
        {
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
        }
        public void hex()
        {
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
        }
        public void Pow(double num)
        {
            lbNum.Text = Math.Pow(num, 2).ToString();
            lbop.Text = "(" + num + ")" + "^2".ToString();
        }
        public void Sprt(double num)
        {
            lbNum.Text = Math.Sqrt(num).ToString();
            lbop.Text = "√(" + num + ")";
        }
        public void share(double num)
        {
            lbNum.Text = (1 / num).ToString();
            lbop.Text = "1/(" + num + ")";
        }
        public void delete()
        {
            if (lbNum.Text != string.Empty)
            {
                lbNum.Text = controller.delete(lbNum.Text);
            }
        }
        public void deletepnl()
        {
            if (labelnum.Text != string.Empty)
            {
                labelnum.Text = controller.deletePro(labelnum.Text, check);
                lbbin.Text = controller.bin;
                lbdec.Text = controller.dec;
                lboct.Text = controller.oct;
                lbhex.Text = controller.hex;
            }
        }
        public void pnlchecking(string c)
        {
            labelnum.Text = controller.typing(c);
            if (labelnum.Text != null)
            {
                choise();
            }
        }
        public void choise()
        {
            controller.choose(check, labelnum.Text);
            lbbin.Text = controller.bin;
            lbdec.Text = controller.dec;
            lboct.Text = controller.oct;
            lbhex.Text = controller.hex;
        }
        public void checking(string ch)
        {
            lbNum.Text = controller.firstTyping(ch);
        }
        //==================<< Standard >>======================\\

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "0")
            {
                checking("0");
            }
            else if (btn.Text == "1")
            {
                checking("1");
                //labelnum.Text= controller.firstTyping("1").ToString();

            }
            else if (btn.Text == "2")
            {
                checking("2");
            }
            else if (btn.Text == "3")
            {
                checking("3");
            }
            else if (btn.Text == "4")
            {
                checking("4");
            }
            else if (btn.Text == "5")
            {
                checking("5");
            }
            else if (btn.Text.Equals("6"))
            {
                checking("6");
            }
            else if (btn.Text.Equals("7"))
            {
                checking("7");
            }
            else if (btn.Text.Equals("8"))
            {
                checking("8");
            }
            else if (btn.Text.Equals("9"))
            {
                checking("9");
            }
            else if (btn.Text.Equals("1/x"))
            {
                share(double.Parse(lbNum.Text));
            }
            else if (btn.Text.Equals("x²"))
            {
                Pow(double.Parse(lbNum.Text));
            }
            else
            {
                Sprt(double.Parse(lbNum.Text));
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            lbNum.Text = lbNum.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNum.Text = "-" + lbNum.Text;
            number1 = -double.Parse(lbNum.Text);
        }

        private void btnequal(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals("+"))
            {
                Operator(op);
                number1 = double.Parse(lbNum.Text);
                op = '+';
                lbop.Text = lbNum.Text + " + ";
                controller.lablenum = "0";
                lbNum.Text = "0";
            }
            else if (btn.Text.Equals("-"))
            {
                Operator(op);
                number1 = double.Parse(lbNum.Text);
                op = '-';
                lbop.Text = lbNum.Text + " - ";
                controller.lablenum = "0";
                lbNum.Text = "0";
            }
            else if (btn.Text.Equals("×"))
            {
                Operator(op);
                number1 = double.Parse(lbNum.Text);
                op = '×';
                lbop.Text = lbNum.Text + " × ";
                controller.lablenum = "0";
                lbNum.Text = "0";
            }
            else if (btn.Text.Equals("÷"))
            {
                Operator(op);
                number1 = double.Parse(lbNum.Text);
                op = '÷';
                lbop.Text = lbNum.Text + " ÷ ";
                controller.lablenum = "0";
                lbNum.Text = "0";
            }
            else if (btn.Text.Equals("="))
            {
                Operator(op);
                lbop.Text = "";
                controller.lablenum = "0";
                op = ' ';
            }
        }

        private void btncl(object sender, EventArgs e)
        {
            lbop.Text = "";
            lbNum.Text = "0";
            controller.lablenum = "";
            number1 = 0;
        }

        private void btncl11(object sender, EventArgs e)
        {
            delete();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)// combo box
        {
            if (cb1.SelectedIndex == 1)
            {
                panel1.Visible = true;
                lbselected.Text = "Binary";
            }
            else
            {
                panel1.Visible = false;
                lbselected.Text = "Standard";
            }
        }
        //========================<< ##### >>==================\\

        //========================<< Binary >>====================\\
        private void button45_Click(object sender, EventArgs e)
        {
            pnlchecking("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pnlchecking("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pnlchecking("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pnlchecking("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pnlchecking("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pnlchecking("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pnlchecking("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pnlchecking("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pnlchecking("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pnlchecking("9");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Equals("+"))
            {
                conditionOperator(check);
                number3 = labelnum.Text;
                if (check != "Hex")
                {
                    number2 = int.Parse(number3);
                }
                op = '+';
                controller.programmer = "";
                labelequal.Text = labelnum.Text + " + ";
                labelnum.Text = "0";
            }
            else if (btn.Text.Equals("-"))
            {
                conditionOperator(check);
                op = '-';
                number3 = labelnum.Text;
                if (check != "Hex")
                {
                    number2 = int.Parse(number3);
                }
                controller.programmer = "";
                labelequal.Text = labelnum.Text + " - ";
                labelnum.Text = "0";
            }
            else if (btn.Text.Equals("×"))
            {
                conditionOperator(check);
                op = '×';
                number3 = labelnum.Text;
                if (check != "Hex")
                {
                    number2 = int.Parse(number3);
                }
                labelequal.Text = labelnum.Text + " × ";
                controller.programmer = "";
                labelnum.Text = "0";
            }
            else if (btn.Text.Equals("÷"))
            {
                conditionOperator(check);
                op = '÷';
                number3 = labelnum.Text;
                if (check != "Hex")
                {
                    number2 = int.Parse(number3);
                }
                labelequal.Text = labelnum.Text + " ÷ ";
                labelnum.Text = "0";
                controller.programmer = "";
            }
            else if (btn.Text.Equals("="))
            {
                conditionOperator(check);
                number3 = "0";
                if (check != "Hex")
                {
                    number2 = 0;
                }
                op = ' ';
                controller.programmer = "0";
                labelequal.Text = "";
                if (labelnum.Text != null)
                {
                    choise();
                }
            }
        }

        private void rbBin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBin.Checked)
            {
                binary();
                check = "Bin";
            }
        }

        private void rbOct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOct.Checked)
            {
                oct();
                check = "Oct";
            }
        }

        private void rbDec_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDec.Checked)
            {
                dec();
                check = "Dec";
            }
        }

        private void rbHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHex.Checked)
            {
                hex();
                check = "Hex";
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            pnlchecking("A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            pnlchecking("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            pnlchecking("C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            pnlchecking("D");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            pnlchecking("E");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            pnlchecking("F");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            labelnum.Text = "0";
            labelequal.Text = "";
            number1 = 0.0;
            lbbin.Text = "0";
            lbdec.Text = "0";
            lbhex.Text = "0";
            lboct.Text = "0";
            controller.programmer = "";
            number2 = 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            deletepnl();
        }
    }
}