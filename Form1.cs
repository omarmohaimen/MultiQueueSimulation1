using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;
using System.Runtime.InteropServices;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SimulationSystem system = new SimulationSystem("C:/me/study/4th year/1st semster/modling/labs/Lab 2/Template_Students/MultiQueueSimulation/MultiQueueSimulation/TestCases/TestCase1.txt");

            //textBox1.Text = system.NumberOfServers.ToString();

        }
        string OpenedFilePath;
        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string OpenedFilePath;
                //Open the browsed image and display it
                OpenedFilePath = openFileDialog1.FileName;
                SimulationSystem system = new SimulationSystem(OpenedFilePath);
                textBox1.Text = system.NumberOfServers.ToString();
                //ImageMatrix = ImageOperations.OpenImage(OpenedFilePath);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
