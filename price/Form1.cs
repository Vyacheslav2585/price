using System;
using System.Threading;
using System.Windows.Forms;
namespace price
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Cossacks cossacks = new Cossacks();
            label1.Text = cossacks.F();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}