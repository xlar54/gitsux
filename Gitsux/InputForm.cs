using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gitsux
{
    public partial class InputForm : Form
    {
        public string Prompt;
        public string Result;

        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            label1.Text = Prompt;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Result = textBox1.Text;
            this.Close();
        }
    }
}
