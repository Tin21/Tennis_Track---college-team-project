﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_Track
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void TxtUsername_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtUsername.SelectAll();
        }

        private void TxtPassword_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TxtPassword.SelectAll();
        }

    }
}