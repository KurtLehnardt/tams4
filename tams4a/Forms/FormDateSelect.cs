﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tams4a.Forms
{
    public partial class FormDateSelect : Form
    {
        public FormDateSelect()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public DateTime getDate()
        {
            return dateTimePicker1.Value;
        }
    }
}
