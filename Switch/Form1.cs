using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpPcap;
using SharpPcap.LibPcap;
using System.IO;

namespace Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Device list
            CaptureDeviceList devices = CaptureDeviceList.Instance;

            if (devices.Count < 1)
            {
                richTextBox1.AppendText("Žiadne zariadenia!");
            }
                
            foreach (ICaptureDevice dev in devices)
            {
                richTextBox1.AppendText(dev.Description.ToString() + "\n"); //vypise nazov karty
                
            }

        }
       
    }
}
