using extensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.AddContextMenu();
            richTextBox2.AddContextMenu();

        


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> rt = new List<string>();
            foreach (string line in richTextBox1.Lines)
            {
                if (line != "")
                {
                    rt.Add(line);
                }
            }

            richTextBox1.Lines = rt.ToArray();

            string replaceString = Regex.Replace(richTextBox1.Text, "\n", "','");

            richTextBox2.Text = "('" + replaceString + "')";

        }

    }
}
   
