﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class CustomerControl : UserControl
    {
        public CustomerControl()
        {
            InitializeComponent();
            displayCustomers();
        }

        public void displayCustomers()
        {
            customerList cData = new customerList();
            List<customerList> listData = cData.customerListData();
            dataGridView1.DataSource = listData;

        }
    }
}
