using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RC4
{
    public partial class MainForm : Form
    {
        Algorithm algorithm = new Algorithm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void EncButton_Click(object sender, EventArgs e)
        {
            string key = Keybox.Text;
            string input = InputBox.Text;
            int[] keyArray = new int[key.Length];
            int[] inputArray = new int[input.Length];
            algorithm.ConvertString(key, out keyArray);
            algorithm.ConvertString(input, out inputArray);
            algorithm.Setup(keyArray);
            algorithm.KSA();
            algorithm.PRGA(inputArray);
            int[] output = algorithm.Encrypt(inputArray);
            EncBox.Text = algorithm.ConvertArray(output);
        }

        private void DecButton_Click(object sender, EventArgs e)
        {
            string key = Keybox.Text;
            string input = InputBox.Text;
            int[] keyArray = new int[key.Length];
            int[] inputArray = new int[input.Length];
            algorithm.ConvertString(key, out keyArray);
            algorithm.ConvertString(input, out inputArray);
            algorithm.Setup(keyArray);
            algorithm.KSA();
            algorithm.PRGA(inputArray);
            int[] output = algorithm.Decrypt(inputArray);
            DecBox.Text = algorithm.ConvertArray(output);

        }
    }
}
