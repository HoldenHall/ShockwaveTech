﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// what users first see when starting program
/// </summary>
namespace mock_up
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            choice choose = new choice();
            choose.Show();
            this.Hide();
        }

        private void newBut_Click(object sender, EventArgs e)
        {
            NewChoice choice = new NewChoice();
            choice.Show();
            this.Hide();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
