using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Diagnostics;
using System.Collections;

namespace OpenEnvLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string Bash(string command)
        {
            var escapedArgs = command.Replace("\"", "\\\"");
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            process.Dispose();
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SenseWater = Bash("gpio readall");
            if (SenseWater.Contains("|   5 |  21 | GPIO.21 |   IN | 0 | 29 |"))
            {
                土壤湿度显示.Text = "湿度过低";
            }
            else
            {
                土壤湿度显示.Text = "湿度正常";
            }
            string SenseLight = Bash("gpio readall");
            if (SenseLight.Contains("| 40 | 1 | IN   | GPIO.29 | 29  | 21  |"))
            {
                亮度显示.Text = "亮度过低";
            }
            else
            {
                亮度显示.Text = "亮度正常";
            }
        }
    }
}
