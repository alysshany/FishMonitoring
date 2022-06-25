using System;
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
    }
}
