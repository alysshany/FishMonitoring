﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishLibrary;
using ParsingLibrary;



namespace FishMonitoring
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fileName = openFileDialog.FileName;
            string[] data = Parsing.Parse(fileName);
            txtBoxDateBeg.Text = data[0];
            txtBoxTempEd.Text = data[1];
        }

        private void LstBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameOfFish = lstBoxMain.SelectedItem.ToString();
            string[] infoName = FishLibrary.Fishes.Info(nameOfFish).Split(" ");
            txtBoxMaxTemp.Text = infoName[0];
            txtBoxMaxTime.Text = infoName[1];
            txtBoxMin.Text = infoName[2];
            txtBoxMinTime.Text = infoName[3];
        }
    }
}
