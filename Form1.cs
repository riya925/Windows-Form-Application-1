using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Form_2
{
    public partial class Form1 : Form
    {

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Selected File Name:" + opd.FileName);
            }
        }
    }
}
