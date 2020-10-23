using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QMS_Monaliza
{
    public partial class Form1 : Form
    {
        int currentOrderNumber;
        int nextOrderNumber;
        int orderNumber;

        public Form1()
        {
            InitializeComponent();
            currentOrderNumber = 0;
            nextOrderNumber = 0;
            orderNumber = 0;

            orderLbl.Text = "";
            currentOrderLbl.Text = "";
            nextOrderLbl1.Text = "";
            nextOrderLbl2.Text = "";
            nextOrderLbl3.Text = "";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String name = nameTxt.Text;
            String phone = phoneTxt.Text;

            orderNumber += 1;
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentOrderNumber += 1;
            nextOrderNumber = currentOrderNumber + 1;
            currentOrderLbl.Text = currentOrderNumber.ToString();
            nextOrderLbl1.Text = nextOrderNumber.ToString();
            nextOrderLbl2.Text = (nextOrderNumber + 1).ToString();
            nextOrderLbl3.Text = (nextOrderNumber + 2).ToString();
        }
    }
}
