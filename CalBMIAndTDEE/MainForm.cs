using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        double age, height, weight;
        bool IsMan = true;
        string Activate;

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                age = Convert.ToDouble(comboBox_Age.Text);
                weight = Convert.ToDouble(textBox_Weight.Text);
                height = Convert.ToDouble(textBox_Height.Text);
            }
            catch
            {
                age = 0; weight = 0; height = 0;
            }

            if (radioButton_Man.Checked == true)
            {
                IsMan = true;
            }
            else
            {
                IsMan = false;
            }
            CalResult calBMRandTDEE = new CalResult();
            var result = calBMRandTDEE.GetBMR(age, weight, height, IsMan);
            label_Show_BMR.Text = Convert.ToString(result);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_CalTDEE_MouseClick(object sender, MouseEventArgs e)
        {
            CalResult calTDEE = new CalResult();
            double BMR_result = Convert.ToDouble(label_Show_BMR.Text);
            Activate = comboBox_Activate.Text;
            var result = calTDEE.GetTDEE(BMR_result, Activate);
            if (result != 0)
                label_ShowTDEE.Text = Convert.ToString(result);
            else
                label_ShowTDEE.Text = "請先選擇活動量選項，才能計算TDEE哦!!!";
            label_ShowTDEE.Font = new Font("微軟正黑體", 14);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 130; i++)
                comboBox_Age.Items.Add(i);

            label_TDEEHint.Text = "請依照上述圖片說明，" + "\n" + "於下拉式選單選擇最符合的描述";

        }
    }
}
