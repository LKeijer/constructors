using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructors
{
    public partial class Form1 : Form
    {
        public string TextBack;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string textBack)
        {
            this.TextBack = textBack;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Text text = new constructors.Text("Hello");
            text.SendBackMessage();
             ChangeTextBoxText();
        }

        private void ChangeTextBoxText()
        {
            textBox.Text = TextBack;
        }
    }
}
