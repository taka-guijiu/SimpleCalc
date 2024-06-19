using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // 変数宣言
            int valueLeft;
            int valueRight;
            int valueAnswer;
            // 値の取り込み
            InputCheck(Input1TextBox.Text, out valueLeft);
            InputCheck(Input2TextBox.Text, out valueRight);

            // 取り込んだ値の計算
            valueAnswer = valueLeft + valueRight;

            // 計算結果を出力
            AnswerTextBox.Text = valueAnswer.ToString();

        }
        private void InputCheck(string textValue, out int value)
        {
            if (int.TryParse(textValue, out value) != true)
            {
                value = 0;
            }
        }


    }

}
