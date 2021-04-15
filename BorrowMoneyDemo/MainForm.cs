using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyRecordPractice
{
    public partial class Form1 : Form
    {
        Person Me, Friend;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            Me = new Person(tbx_Myname.Text,0);
            Friend = new Person(tbx_Friendname.Text,10000);
            lab_Myname.Text = Me.Name;
            lab_Friendname.Text = Friend.Name;
            btn_BorrowMoney.Text = $"和{Friend.Name}借$1000";
            btn_PayBack.Text =$"還給{ Friend.Name}$1000 ";
            btn_BorrowMoney.Enabled = true;
            btn_PayBack.Enabled = true;
        }

        private void btn_BorrowMoney_Click(object sender, EventArgs e)
        {
            Me.Borrow(Friend,1000);
            UpdateMoney();
        }

        private void btn_PayBack_Click(object sender, EventArgs e)
        {
            Me.PayBack(Friend,1000);
            UpdateMoney();
        }

        private void UpdateMoney()
        {
            lab_MyMoney.Text = "" + Me.Money;
            lab_FriendMoney.Text = "" + Friend.Money;
        }
    }
}
